using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj01
{
    //萨克斯类
    class Sachs:Instrument
    {
        public override string Play()
        {
            string str = string.Format("萨克斯在演奏");
            return str;
        }
    }
}
