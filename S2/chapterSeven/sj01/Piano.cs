using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj01
{
    //钢琴类
   public class Piano:Instrument
    {
       public override string Play()
       {
           string str = string.Format("钢琴正在演奏");
           return str;
       }
    }
}
