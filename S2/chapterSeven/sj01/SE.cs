using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj01
{
    class SE
    {
        public SE(int Id,string Name,int Num) 
        {
            this.ID = Id;
            this.Name = Name;
            this.Num = Num;
        }

        public SE() { }

        public int ID { get; set; }
        public string Name { get; set; }
        public int Num { get; set; }
        public void Play(Instrument istt) 
        {
            istt.Play();
        }
    }
}
