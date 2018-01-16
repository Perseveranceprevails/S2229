using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTwo
{
    class Voter
    {
        public void voter(Computer[] cp) 
        {
            Random ran = new Random();
            cp[0].ID = cp[0].Type;
            cp[0].ID = cp[0].ID + ran.Next(1000,9999);
            cp[1].ID = cp[1].Type;
            cp[1].ID = cp[1].ID + ran.Next(1000, 9999);
            cp[2].ID = cp[2].Type;
            cp[2].ID = cp[2].ID + ran.Next(1000, 9999);
        }
    }
}
