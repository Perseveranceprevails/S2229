using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("ICBC");//插入元素
            list.Add(5.0); //装箱操作，类型为objec
            list.Add(1); //可添加任何类型的元素
            list.Remove("ICBC");//根据对象名删除数据
            list.RemoveAt(1);//根据下标删除数据
            list.Clear();//清空所有数据
            //Hashtable table = new Hashtable();
            //table.Add("ICBC","工商银行");
            //table.Add("ABC","农业银行");
            //table.Add("CBC","建设银行");
            //Console.WriteLine("个数是："+table.Count);
            //foreach(object obj in table.Keys)
            //{
            //    Console.WriteLine(obj);
            //}
            ////利用foreach循环遍历
            //foreach(object obj in table.Values)
            //{
            //    Console.WriteLine(obj);
            //}

            Console.ReadLine();
        }
    }
}
