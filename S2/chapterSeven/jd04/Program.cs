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
            Wages w, w2;
            w = new PM();
            int sum = w.PrintSalary();     
            Console.WriteLine("项目经理的工资："+sum);
            w2 = new SE();
            int sum2=w2.PrintSalary();
            Console.WriteLine("工程师的工资："+sum2);
            Console.ReadLine();
        }
    }
}
