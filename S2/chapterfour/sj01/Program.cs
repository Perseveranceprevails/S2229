using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd01
{
    class Program
    {
        static void Main(string[] args)
        {
            SE se = new SE();
            se.Show("101","赵昌平",18,"男");
            PM pm = new PM();
            pm.Show("102", "吴梦洁", 18, "女");
            Console.ReadLine();
        }
    }
}
