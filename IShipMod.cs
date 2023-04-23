using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWarsForPoor.Objects.InSpace;

namespace StarWarsForPoor
{
    public interface IShipMod
    {
        void Modificate(Ship ship);
    }
}
