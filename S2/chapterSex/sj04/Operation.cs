using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj04
{
    class Operation
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        
        public virtual double GetResult() 
        {
            double Result = 0;
            return Result;
        }
    }
}
