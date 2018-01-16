using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd04
{
    //非本行卡
    class OtherBank:BankCard
    {
        //构造
        public OtherBank(int ID, int Pwd, string Name, int Banlance) 
        {
            base.Number = ID;
            base.Password = Pwd;
            base.Name = Name;
            base.Banlance = Banlance;
        }
        //
        public override int GetMoney(int Money)
        {
            base.Banlance = base.Banlance-Money-2;
            return base.Banlance;
        }
    }
}
