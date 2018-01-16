using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd03
{
    class Dog:Animal
    {
        public Dog(string DogName):base()
        {
            base.AnimalName = DogName;
        }
        public override string GetSayHi()
        {
            string massage = string.Format("我是{0}，汪汪汪", base.AnimalName);
            //Console.WriteLine();
            return massage;
        }
    }
}
