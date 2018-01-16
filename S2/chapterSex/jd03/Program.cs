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
            List<Animal> list = new List<Animal>();
            
            Dog d = new Dog("哈士奇");

            Cat c = new Cat("加菲");
            list.Add(d);
            list.Add(c);
            foreach(Animal item  in list)
            {
                Console.WriteLine(item.GetSayHi());
            }
            Console.ReadLine();
        }
    }
}
