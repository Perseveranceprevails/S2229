using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd03
{
    class Cat:Animal
    {
        public Cat(string CatName):base()
        {
            base.AnimalName = CatName;
        }
        public override string GetSayHi()
        {
            string massage = string.Format("我是{0},喵喵", base.AnimalName);
            //Console.WriteLine();
            return massage;
        }
    }
}
