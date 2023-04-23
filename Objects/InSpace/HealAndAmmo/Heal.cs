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

    public class Heal : Asteroid, IShipMod
    {
        public static int HealInSpace = 0;
        static int HealAmount = 5;
        public Heal() : base(new Bitmap(@"img\Heal.png"), 
                      new Point(RngProvider.Random.Next(0, Space.SpaceField.Width), -(new Bitmap(@"img\Heal.png").Height)),
                      new Point(RngProvider.Random.Next(-Factory.MaxSpeedX, Factory.MaxSpeedX), RngProvider.Random.Next(Factory.MinSpeedY, Factory.MaxSpeedY)), 
                      1)
        {
            HealInSpace++;
        }
        override public void Modificate(Ship ship)
        {
            
            this.Lives = 0;
            ship.Lives += Heal.HealAmount;
        }
        ~Heal()
        {
            HealInSpace--;
        }
    }
}

