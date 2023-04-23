using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StarWarsForPoor.Objects.Parts
{
    [Serializable]
    public class Hull : Part
    {
        public int Health;
        public int Ammo;
        public int ammoMax;
        public Hull(int cost = 0, Bitmap appearence = null, int health = 0, int ammo = 0) : base(cost, appearence)
        {
            this.Health = health;
            this.Ammo = ammo;
            this.ammoMax = ammo;
        }
        public Hull() : base()
        {
            this.Health = 0;
            this.Ammo = 0;
        }
    }
}
