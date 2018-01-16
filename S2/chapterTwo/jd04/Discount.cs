using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd04
{
    class Discount
    {
        public void show( int[] a) 
        {
            for (int i = 0; i < a.Length;i++ )
            {
                if(a[i]>100)
                {
                    a[i] = a[i] - 50;
                    //Console.Write("{0}\t",a[i]);
                }
            }
        }
    }
}
