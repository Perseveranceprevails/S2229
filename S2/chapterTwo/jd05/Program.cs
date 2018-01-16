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
            int[] sroces = {70,85,95,55,45 };
            Console.Write("原分数：");
            for (int a = 0; a < sroces.Length;a++ )
            {
                Console.Write("{0}\t",sroces[a]);
            }
            Console.WriteLine();
            Console.Write("提分后：");
            show( sroces);
            for (int b = 0; b < sroces.Length; b++)
            {
                Console.Write("{0}\t", sroces[b]);
            }
            Console.ReadLine();
        }
        static void show( int[] a) 
        {
            for (int i = 0; i < a.Length;i++ )
            {
                a[i] += 5;
            }
        }
    }
}
