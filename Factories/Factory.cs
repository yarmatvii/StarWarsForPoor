using StarWarsForPoor.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using StarWarsForPoor.Objects.InSpace;
using System.Drawing;
using StarWarsForPoor.Objects.InSpace.Asteroids;
using StarWarsForPoor.Objects.InSpace.HealAndAmmo;

namespace StarWarsForPoor.Factories
{
    class Factory : IFactory
    {
        static int maxAmmoAndHeal = 4;
        public static int MinSpeedY = 1;
        public static int MaxSpeedY = 6;
        public static int MaxSpeedX = 2;
        public static int SpawnRadius = 64;

        private readonly List<Type> _objInSpace = new List<Type>()
        {
            typeof(SmallAsteroid),
            typeof(MediumAsteroid),
            typeof(EnormousAsteroid),
            typeof(Heal),
            typeof(Ammo)

        };

        public IShipMod Create()
        {
            int typeIndex;
            if (Heal.HealInSpace + Ammo.AmmoInSpace >= maxAmmoAndHeal)
            {
                typeIndex = RngProvider.Random.Next(0, 3);
            }
            else
            {
                typeIndex = RngProvider.Random.Next(0, _objInSpace.Count);
            }
            
            var typeOfEnemy = _objInSpace[typeIndex];
            IShipMod newObj = Activator.CreateInstance(typeOfEnemy) as IShipMod;

            return newObj; 
        }
    }
}
