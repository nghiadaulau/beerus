using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beerus
{
    public class Car
    {
        public int car_id { get; set; }
        public string name { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string car_type { get; set; }
        public double price { get; set; }

        public override string ToString()
        {
            return this.name;
        }
    }
}
