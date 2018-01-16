using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj01
{
   public class Instrument
    {
       public virtual string Play()
       {
           string str = "演奏乐器";
           return str;
       }
    }
}
