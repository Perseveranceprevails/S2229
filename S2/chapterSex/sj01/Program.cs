using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj01
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck t = new Truck("保时捷911GT3","德国");
            t.VehicleRun();
            t.TruckRun();
            Console.ReadLine();
        }
    }
}
