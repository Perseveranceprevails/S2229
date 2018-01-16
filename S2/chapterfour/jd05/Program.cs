using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd3
{
    class Program
    {
        static void Main(string[] args)
        {
            sorcerer u = new sorcerer("魔法师",10000);
            u.show();
            sorcerer u1 = new sorcerer("阿修罗",10000,70,200000);
            u1.show1();
            Console.ReadLine();
        }
    }
}
