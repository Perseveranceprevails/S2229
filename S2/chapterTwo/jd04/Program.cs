using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] money ={500,480,320,130,210};
            Console.WriteLine("**********打折促销**********");
            Console.WriteLine("购买商品的原价：");
            for (int a = 0; a < money.Length;a++ )
            {
                Console.Write("{0}\t",money[a]);
            }
            Console.WriteLine("");
            Discount d = new Discount();
            d.show(money);
            Console.WriteLine("打折后的应付价钱：");
            //Show( money);
            for (int b = 0; b < money.Length; b++)
            {
                Console.Write("{0}\t", money[b]);
            }
            Console.ReadLine();
        }
        //static void Show(int[] a)
        //{
        //    Console.WriteLine("打折后的应付价钱：");
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (a[i] > 100)
        //        {
        //            a[i] = a[i] - 50;
        //            Console.Write("{0}\t", a[i]);
        //        }
        //    }
        //}
    }
}
