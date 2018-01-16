using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj01
{
    class Truck:Vehicle
    {
        public Truck(string type,string site):base(type,site)
        {

        }
        public void TruckRun()
        {
            Console.WriteLine("型号为：{0}、产地为：{1}的卡车在行驶",this.Type,this.Site);
        }
    }
}
