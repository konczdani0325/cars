using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoSale.Model
{
    public class Car
    {
        public int id;
        public string Brand;
        public string Type;
        public string Licence;
        public int year;
        public Car(string s)
        {
            string[]darab=s.Split(',');
            this.id = int.Parse(darab[0]);
            this.Brand = darab[1];
            this.Type = darab[2];
            this.Licence = darab[3];
            this.year = int.Parse(darab[4]);
        }
    }
}
