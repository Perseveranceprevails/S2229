using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd02
{
   public class Program
    {
        static void Main(string[] args)
        {
            SE se = new SE();
            se.Name = "张三";
            se.BasicMoney = 30000;
            se.CheckMoney=5000;
            SayHi s = new SayHi();
            s.show(se);
            PM pm = new PM();
            pm.Name = "李四";
            pm.BasicMoney = 80000;
            pm.ItemsMoney=8000;
            pm.Dividend = 2000;
            s.show(pm);
            Console.ReadLine();
        }
    }
}
