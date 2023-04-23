using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace StarWarsForPoor.Objects.Parts
{
    [XmlInclude(typeof(Hull)), XmlInclude(typeof(Weapon))]
    [Serializable]
    public abstract class Part
    {
        public int Cost;
        public Bitmap Appearance;
        public Part(int cost = 0, Bitmap appearence = null)
        {
            this.Cost = cost;
            this.Appearance = appearence;
        }
        public Part()
        {
            this.Cost = 0;
            this.Appearance = default;
        }
    }
}
