using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using StarWarsForPoor.Factories;
using StarWarsForPoor.Helpers;

namespace StarWarsForPoor.Objects.InSpace.Asteroids
{
    public class SmallAsteroid : Asteroid, IShipMod
    {
        public SmallAsteroid() : base(new Bitmap(@"img\Asteroid1.png"),
                          new Point(RngProvider.Random.Next(0, Space.SpaceField.Width), -(new Bitmap(@"img\Asteroid1.png").Height)),
                          new Point(RngProvider.Random.Next(-Factory.MaxSpeedX, Factory.MaxSpeedX), RngProvider.Random.Next(Factory.MinSpeedY, Factory.MaxSpeedY)),
                          1)
        {
            this.Damage = 5;
        }
    }
}
