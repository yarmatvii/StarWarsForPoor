using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using StarWarsForPoor.Helpers;
using StarWarsForPoor.Objects.InSpace.HealAndAmmo;

namespace StarWarsForPoor.Objects.InSpace
{
    public class Asteroid : MyObject, IPunch, IShipMod
    {
        ChangePicture ChangeAsteroidImg;
        ChangeVector ChangeAsteroidVector;
        const int ImgAmount = 3;
        static int MinSpeedY = 1;
        static int MaxSpeedY = 6;
        static int MaxSpeedX = 2;
        public int Damage = 0;
        public Asteroid
          (
          Bitmap appearance,
          Point coordinates,
          Point vector,
          int lives
          ) : base(appearance, coordinates, vector, lives)
        {
            if (vector.X == 0)
            {
                ChangeAsteroidVector += ChangeVectorZeroVector;
            }
            else
            {
                ChangeAsteroidVector += ChangeVectorInvert;
            }
            ChangeAsteroidImg += ChangeAsteroid1;
            ChangeAsteroidImg += ChangeRotate;
        }

        public static Asteroid RandNewAsteroid(Bitmap baseImg)
        {
            Bitmap img = new Bitmap($@"img\Asteroid{RngProvider.Random.Next(0, ImgAmount)}.png");

            Point coordinates = new Point(RngProvider.Random.Next(0, baseImg.Width), -img.Height);

            Point vector = new Point(RngProvider.Random.Next(-MaxSpeedX, MaxSpeedX), RngProvider.Random.Next(Asteroid.MinSpeedY, Asteroid.MaxSpeedY));

            Asteroid newAsteroid = new Asteroid(img, coordinates, vector, 1);

            return newAsteroid;
        }
        public void Change(object obj)
        {
            Asteroid asteroid = (Asteroid)obj;

            if (ChangeAsteroidVector == null || ChangeAsteroidImg == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                this.ChangeAsteroidVector(asteroid.Vector);
                this.ChangeAsteroidImg(asteroid.Appearance);
            }
        }
        public void Punch(object obj)
        {
            if(obj is Ammo||obj is Heal || this is Ammo || this is Heal)
            {
                return;
            }

            Asteroid asteroid = (Asteroid)obj;
            Point vector = asteroid.Vector;

            if (this.IsDifDirection(asteroid))
            {
                this.ChangeAsteroidVector(vector);
                asteroid.ChangeAsteroidVector(this.Vector);
            }
            else
            {
                return;
            }

        }
        void ChangeAsteroid1(Bitmap img)
        {
            Color color;
            int a = RngProvider.Random.Next(0, 2);
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    color = img.GetPixel(i, j);
                    if (color.Name == "ffffff")
                    {
                        continue;
                    }

                    if (a == 0)
                    {
                        img.SetPixel(i, j, Color.FromArgb(color.ToArgb() >> 1));
                    }
                    else if (a == 1)
                    {
                        img.SetPixel(i, j, Color.FromArgb(color.ToArgb() << 1));
                    }
                    else
                    {
                        img.SetPixel(i, j, Color.Black);
                    }
                }
            }
            this.Appearance = img;
        }
        void ChangeRotate(Bitmap img)
        {
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            this.Appearance = img;
        }
        void ChangeVectorInvert(Point vector)
        {
            if (vector.X == 0)
            {
                this.Vector.Y += 1;
                this.ChangeAsteroidImg(this.Appearance);
            }
            this.Vector.X = -this.Vector.X;
        }
        void ChangeVectorZeroVector(Point vector)
        {
            this.Vector.X = vector.X;
            this.Vector.Y += 1;
        }
        public void CheckCoordinates(Bitmap filed)
        {
            if (this.Coordinates.X >= filed.Width || this.Coordinates.Y >= filed.Height)
            {
                this.Lives = 0;
            }
            if (this.Coordinates.X < -this.Size.X || this.Coordinates.Y < -this.Size.Y)
            {
                this.Lives = 0;
            }
        }
        public void ChangeThisAsteroid(Asteroid asteroid)
        {
            this.ChangeThisAsteroid(asteroid.Appearance, asteroid.Coordinates, asteroid.Vector);
        }
        void ChangeThisAsteroid(Bitmap img,
                                 Point coordinates,
                                 Point vector)
        {
            this.Appearance = img;
            this.Coordinates = coordinates;
            this.Vector = vector;
        }
        public bool IsDifDirection(Asteroid asteroid)
        {
            if (asteroid.Vector.X > 0 && this.Vector.X < 0)
            {
                return true;
            }
            else if (asteroid.Vector.X < 0 && this.Vector.X > 0)
            {
                return false;
            }
            else if (asteroid.Vector.X < 0 && this.Vector.X < 0)
            {
                this.Vector = asteroid.Vector;
                return false;
            }
            else if (asteroid.Vector.X > 0 && this.Vector.X > 0)
            {
                this.Vector = asteroid.Vector;
                return false;
            }
            else
            {
                return true;
            }
        }
        virtual public void Modificate(Ship ship)
        {
            this.Lives = 0;
            ship.Lives -= this.Damage;
        }
    }
}
