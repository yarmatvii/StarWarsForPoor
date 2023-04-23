using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using StarWarsForPoor.Objects.Parts;
using StarWarsForPoor.Objects.InSpace;


namespace StarWarsForPoor.Objects.InSpace
{
    public class Ship : MyObject
    {
        public Weapon Pushka;
        public Hull Vedro;
        public Ship(Hull hull,
        Weapon weapon) : base(new Bitmap(@"img\Ship.png"), default, default, 1)
        {
            Color colour;
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 35; j++)
                {
                    colour = hull.Appearance.GetPixel(i, j);
                    if (colour.Name != "ffffff")
                    {
                        this.Appearance.SetPixel(i, j, colour);
                    }

                    colour = weapon.Appearance.GetPixel(i, j);
                    if (colour.Name != "ffffff")
                    {
                        this.Appearance.SetPixel(i, j, colour);
                    }
                }
            }
            this.Pushka = weapon;
            this.Vedro = hull;
            this.Vector = default;
            this.Coordinates = new Point(100, 100);
            hull.Ammo = hull.ammoMax;
            this.Lives = hull.Health;
        }
        public void MoveShip(Point destination)
        {
            this.Coordinates = destination;
        }
        public void Change(object obj)
        {

        }
        public void CheckCoordinates(Bitmap field)
        {
            if (this.Coordinates.X + this.Size.X >= field.Width)
            {
                this.Coordinates.X = field.Width - this.Size.X;
            }
            if (this.Coordinates.X < 0)
            {
                this.Coordinates.X = 0;
            }
            if (this.Coordinates.Y + this.Size.Y >= field.Height)
            {
                this.Coordinates.Y = field.Height - this.Size.Y;
            }
            if (this.Coordinates.Y < 0)
            {
                this.Coordinates.Y = 0;
            }
        }
        public Bullet Fire()
        {
            if (this.Vedro.Ammo <= 0)
            {
                return null;
            }
            else
            {
                this.Vedro.Ammo--;
                return new Bullet(this.Pushka.BulletImg,
                       new Point(this.Size.X / 2 + this.Coordinates.X, this.Coordinates.Y),
                       new Point(0, -5), this.Pushka.Damage);

            }
        }
        public Status GetStatus()
        {
            Status thisShip;
            thisShip.Ammo = this.Vedro.Ammo;
            thisShip.Health = this.Lives;
            return thisShip;
        }
        public struct Status
        {
            
            public int Ammo;
            public int Health;
        }
    }
}
