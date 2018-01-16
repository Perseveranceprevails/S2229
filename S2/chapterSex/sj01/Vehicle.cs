using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj01
{
    class Vehicle
    {
        public string  Type { get; set; }
        public string Site { get; set; }

        public void VehicleRun() 
        {
            Console.WriteLine("汽车在行驶！");
        }
        public Vehicle(string type,string site) 
        {
            this.Type = type;
            this.Site = site;
        }
    }
}
