using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd05
{
   public class Breeder
    {
       public void Eat(Animal a)
       {
           Console.Write("饲养员喂");
           a.Eat();
       }
    }
}
