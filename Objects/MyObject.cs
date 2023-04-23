using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StarWarsForPoor
{
    public delegate void ChangePicture(Bitmap img);
    public delegate void ChangeVector(Point vector);
    public abstract class MyObject : ILives
    {
        public int Lives;
        private Bitmap appearance;
        public Bitmap Appearance
        {
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.Size.X = value.Width;
                    this.Size.Y = value.Height;
                    this.appearance = value;
                }
            }
            get
            {
                return this.appearance;
            }
        }
        public Point Coordinates;
        public Point Vector;
        public Point Size;
        public MyObject
            (
            Bitmap appearance,
            Point coordinates,
            Point vector,
            int lives
            )
        {
            this.Appearance = appearance;
            this.Coordinates = coordinates;
            this.Vector = vector;
            this.Lives = lives;
        }
        public Bitmap Draw(Bitmap img)
        {
            if(this.Lives <=0)
            {
                return img;
            }
            for (int i = this.Coordinates.X; i < this.Coordinates.X + this.Size.X; i++)
            {
                for (int j = this.Coordinates.Y; j < this.Coordinates.Y + this.Size.Y; j++)
                {
                    Color color = this.appearance.GetPixel(i - this.Coordinates.X, j - this.Coordinates.Y);

                    if (color.Name == "ffffff")
                    {
                        continue;
                    }

                    if (i < 0 || j < 0)
                    {
                        continue;
                    }

                    if (i >= img.Width || j >= img.Height)
                    {
                        continue;
                    }

                    img.SetPixel(i, j, color);
                }
            }
            return img;
        }
        virtual public bool IsPunch(object obj)
        {
            if (obj == null) return false;

            MyObject otherObj = (MyObject)obj;

            int halfSizeX = this.Size.X / 2;
            int halfSizeY = this.Size.Y / 2;

            int X = Math.Abs(this.Coordinates.X + this.Size.X / 2);
            int Y = Math.Abs(this.Coordinates.Y + this.Size.Y / 2);

            int halfOtherObjSizeX = otherObj.Size.X / 2;
            int halfOtherObjSizeY = otherObj.Size.Y / 2;

            int otherObjX = Math.Abs(otherObj.Coordinates.X + otherObj.Size.X / 2);
            int otherObjY = Math.Abs(otherObj.Coordinates.Y + otherObj.Size.Y / 2);

            double R = Math.Sqrt(halfSizeX * halfSizeX + halfSizeY * halfSizeY);
            double otherR = Math.Sqrt(halfOtherObjSizeX * halfOtherObjSizeX + halfOtherObjSizeY * halfOtherObjSizeY);

            int deltaX = X - otherObjX;
            int deltaY = Y - otherObjY;

            double D = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            if (R + otherR > D)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void HitLives(int damage)
        {
            // factory
            Lives -= damage;

            if(Lives < 1)
            {
                // factory
            }
            else
            {
                return;
            }
        }
        public int GetLives()
        {
            return this.Lives;
        }
    }
}
