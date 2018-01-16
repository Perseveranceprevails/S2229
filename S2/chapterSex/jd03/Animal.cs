using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd03
{
    class Animal
    {
        public string AnimalName { get; set; }
        public Animal()
        {
            this.AnimalName = "大家好";
        }

        public virtual string GetSayHi() 
        {
            this.AnimalName = "大家好";
            return AnimalName;
        }
    }
}
