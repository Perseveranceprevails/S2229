using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Call c = new Call();
            Sugar s = new Sugar();
            Ant ant = new Ant();
            ant.GetAnt();
            s.show(ant);
           
            c.ss(s);
            ant.show();
            Console.ReadLine();
        }
    }
}
