using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using StarWarsForPoor.Objects.Parts;
using StarWarsForPoor.Objects.InSpace;

namespace StarWarsForPoor
{
    [Serializable]
    public class Armoury
    {
        Bitmap ShipField;
        public  Bitmap HullImg = new Bitmap(@"img\Hull.png");
        public  Bitmap WeaponImg = new Bitmap(@"img\Weapon.png");
        public  Bitmap BulletImg = new Bitmap(@"img\Bullet1.png");
        public  Hull ChosenHull = new Hull(1, new Bitmap(@"img\Hull.png"), 1, 10);
        public  Weapon ChosenWeapon = new Weapon(1, new Bitmap(@"img\Weapon.png"), 1, new Bitmap(@"img\Bullet1.png"));
        public  Ship ChoosenShip = new Ship(
          new Hull(1, new Bitmap(@"img\Hull.png"), 1, 10)
        , new Weapon(1, new Bitmap(@"img\Weapon.png"), 1, new Bitmap(@"img\Bullet1.png")));

        public Armoury()
        {
            
            this.ShipField = new Bitmap(@"img\Space.jpg");
        }

        public Bitmap Draw()
        {
            Ship ShipPreview = new Ship(new Hull(1, HullImg, 1, 10), new Weapon(1, WeaponImg, 1, BulletImg));
            ShipPreview.MoveShip(new Point(90, 40));
            this.ShipField = new Bitmap(@"img\Space.jpg");
            this.ShipField = ShipPreview.Draw(this.ShipField);
            return this.ShipField;
        }

        public void Save(string part = @"dat\")
        {
            XmlSerializer FormatterHull = new XmlSerializer(typeof(Hull));
            XmlSerializer FormatterWeapon = new XmlSerializer(typeof(Weapon));
            using (FileStream fs = new FileStream($@"dat\hull3.xml", FileMode.OpenOrCreate))
            {
                
            }
        }

        public void GetList(string part = @"dat\")
        {
            XmlSerializer FormatterHull = new XmlSerializer(typeof(Hull));
            return;
        }
    }
}
