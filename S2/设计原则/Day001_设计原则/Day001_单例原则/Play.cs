using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day001_单例原则
{
    class Play
    {
        private Play() { }
        public static Play a;
        public static Play IsOnlyPlay() 
        {
            if(a==null)
            {
                a = new Play();
            }
            return a;
        }
    }
}
