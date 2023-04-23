using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using StarWarsForPoor.Factories;
using StarWarsForPoor.Helpers;

namespace StarWarsForPoor.Objects.InSpace.HealAndAmmo
{
    public class Ammo : Asteroid, IShipMod
    {
        public static int AmmoInSpace = 0;
        static int AmmoAmount = 20;
        public Ammo() : base(new Bitmap(@"img\Ammo.png"),
                      new Point(RngProvider.Random.Next(0, Space.SpaceField.Width), -(new Bitmap(@"img\Ammo.png").Height)),
                      new Point(RngProvider.Random.Next(-Factory.MaxSpeedX, Factory.MaxSpeedX), RngProvider.Random.Next(Factory.MinSpeedY, Factory.MaxSpeedY)),
                      1)
        {
            AmmoInSpace++;
        }
        override public void Modificate(Ship ship)
        {
              this.Lives = 0;
              ship.Vedro.Ammo += Ammo.AmmoAmount;
        }
        override public bool IsPunch(object obj)
        {
            return false;
        }
        ~Ammo()
        {
            AmmoInSpace--;
        }
    }
}
