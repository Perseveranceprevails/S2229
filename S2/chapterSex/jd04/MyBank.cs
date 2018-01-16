using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd04
{
    //本行卡
    class MyBank:BankCard
    {
        public MyBank(int ID, int Pwd, string Name, int Banlance) 
        {
            base.Number = ID;
            base.Password = Pwd;
            base.Name = Name;
            base.Banlance = Banlance;
        }
        public override int GetMoney(int Money)
        {
            base.Banlance -= Money;
            return base.Banlance;
        }
        
    }
}
