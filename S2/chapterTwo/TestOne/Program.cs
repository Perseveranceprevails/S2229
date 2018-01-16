using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Old=new int[5];
            int[] New = new int[5];
            Console.WriteLine("请输入5位会员的积分");
            for (int a = 0; a < Old.Length;a++ )
            {
                Console.Write("第"+(a+1)+"位会员积分:");
                Old[a] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Old.Length;i++ )
            {
                //New[i] = Old[i];
                New[i] = Old[i] + 500;
            }
            Console.WriteLine("序号 历史积分 新年积分");
            for (int b = 1; b < Old.Length;b++ )
            {
                Console.WriteLine("{0}      {1}      {2}",b,Old[b],New[b]);
            }
            Console.ReadLine();
        }
    }
}
