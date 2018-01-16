using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day001_单例原则
{
    class Program
    {
        static void Main(string[] args)
        {
            Play a = Play.IsOnlyPlay();
            Play b = Play.IsOnlyPlay();
            //Play c = new Play();
            Console.WriteLine(a==b);
            //Console.WriteLine(b==c);
            Console.ReadLine();
        }
    }
}
