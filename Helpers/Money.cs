using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StarWarsForPoor.Helpers
{
    [Serializable]
    public class Money
    {
        public int money { get; set; }
        public Money() { }
        public Money(int money) { this.money = money; }
        XmlSerializer formatter = new XmlSerializer(typeof(Money));
        public void WriteMoneyToXml(Money m)
        {
            using (FileStream fs = new FileStream("Money.xml", FileMode.Truncate))
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(String.Empty);
                formatter.Serialize(fs, m);
            }
        }
        public int GetMoneyFromXml()
        {
            using (FileStream fs = new FileStream("Money.xml", FileMode.OpenOrCreate))
            {
                Money m = (Money)formatter.Deserialize(fs);
                return m.money;
            }
        }
    }
}
