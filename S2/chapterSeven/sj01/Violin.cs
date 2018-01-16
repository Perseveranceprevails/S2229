using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj01
{
    //小提琴类
    class Violin:Instrument
    {
        public override string Play()
        {
            string str = "小提琴在演奏";
            return str;
        }
    }
}
