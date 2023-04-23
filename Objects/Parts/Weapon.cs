using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StarWarsForPoor.Objects.Parts
{
    [Serializable]
    public class Weapon : Part
    {
        public int Damage;
        public Bitmap BulletImg;
        public Weapon(int cost = 0, Bitmap appearence = null, int damage = 0, Bitmap bullet = null) : base(cost, appearence)
        {
            this.Damage = damage;
            this.BulletImg = bullet;
        }
        public Weapon() : base()
        {
            this.Damage = 0;
            this.BulletImg = default;
        }
    }
}
