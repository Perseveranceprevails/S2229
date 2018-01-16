using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd05
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Breeder b=new Breeder();
            b.Eat(new Lion());
            b.Eat(new Monkey());
            b.Eat(new Pigeon());
            Console.ReadLine();

        }
    }
}
