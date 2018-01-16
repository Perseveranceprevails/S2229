using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class SE:Employee
    {
        private int _popularity;

        public int Popularity
        {
            get { return _popularity; }
            set { _popularity = value; }
        }

        public override string DoWork()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Name+"\n");
            for (int i = 0; i < this.WorkList.Count;i++ )
            {
                sb.Append((i+1)+"、"+WorkList[i].Name+":"+WorkList[i].Description+"\n");
            }
            return sb.ToString();

        }

        public SE(int age,Gender Gender,string ID,string Name,int Popularity,List<Job> list):
            base(age,Gender, ID, Name, list)
        {
            this.Popularity = Popularity;
        }
    }
}
