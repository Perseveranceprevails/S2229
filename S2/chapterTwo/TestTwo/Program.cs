
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer[]  cp= new Computer[3];
            Computer c = new Computer();
            c.Type = "zcp-2017-01";
            c.Time = "2017-12-30";
            //cp[0] = new Computer();u
            cp[0] = c;
            Computer o = new Computer();
            o.Type = "zcp-2017-02";
            o.Time = "2017-12-30";
            //cp[1] = new Computer();
            cp[1] = o;
            Computer m = new Computer();
            m.Type = "zcp-2017-03";
            m.Time = "2017-12-30";
            //cp[2] = new Computer();
            cp[2] = m;
            Console.WriteLine("*********设置计算机ID前********");
            Console.WriteLine("计算机型号\t计算机ID\t购买时间");
            for (int a = 0; a < cp.Length;a++ )
            {
                Console.Write(cp[a].Type+"\t  ");
                Console.Write(cp[a].ID+"\t\t");
                Console.WriteLine(cp[a].Time);
            }
            Console.WriteLine("*********设置计算机ID后********");
            Voter v = new Voter();
            v.voter(cp);
            Console.WriteLine("计算机型号\t计算机ID\t购买时间");
            for (int a = 0; a < cp.Length; a++)
            {
                Console.Write(cp[a].Type + "\t");
                Console.Write(cp[a].ID + "\t");
                Console.WriteLine(cp[a].Time);
            }
            Console.ReadLine();
        }
    }
}
