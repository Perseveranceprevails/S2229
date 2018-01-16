using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTwo
{
    class Computer
    {
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
     
        private string _id;
        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        private string _time;
        public string Time
        {
            get
            {
                return _time;
            }
            set
            {
                _time=value;
            }
        }
    }
}
