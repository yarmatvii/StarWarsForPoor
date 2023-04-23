using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsForPoor
{

    interface IFactory
    {
        IShipMod Create();
       // void Delete(IShipMod item);
    }
    
}
