﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj04
{
    class GetAdd:Operation
    {
        //加
        public override double GetResult()
        {
            double Result = num1 + num2;
            return Result;
        }
    }
}
