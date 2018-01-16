using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("医生看病");
            Doctor d = new Doctor();
            d.ToHospiltal(new Dog());
            d.ToHospiltal(new Bird());
            d.ToHospiltal(new Pig());
            Console.ReadLine();
        }
    }
}
