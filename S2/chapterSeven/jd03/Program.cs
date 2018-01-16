using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd03
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Circle();
            s.Draw();
            Shape s2 = new Rect();
            s2.Draw();
            Console.ReadLine();
        }
    }
}
