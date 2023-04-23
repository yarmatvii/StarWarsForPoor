using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StarWarsForPoor.Objects.InSpace
{
    public class Bullet : MyObject, IPunch
    {
        public Bullet
          (
          Bitmap appearance,
          Point coordinates,
          Point vector,
          int lives
          ) : base(appearance, coordinates, vector, lives)
        {
        }
        public void Change(object obj)
        {
            this.Vector.Y--;
        }
        public void Punch(object obj)
        {
            Asteroid asteroid = (Asteroid)obj;
            asteroid.HitLives(this.Lives);
            this.HitLives(asteroid.Damage);
        }
        public void CheckCoordinates(Bitmap filed)
        {
            if (this.Coordinates.X < 0 || this.Coordinates.Y < 0)
            {
                this.Lives = 0;
            }
            if (this.Coordinates.X >= filed.Width || this.Coordinates.Y >= filed.Height)
            {
                this.Lives = 0;
            }
        }
    }
}
