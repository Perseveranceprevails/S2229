using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd04
{
    //银行卡父类
    class BankCard
    {
        //卡号
        public int Number { get; set; }
        //密码
        public int Password { get; set; }
        //用户名
        public string Name { get; set; }
        //余额
        public int Banlance { get; set; }
        //取款 虚方法
        public virtual int GetMoney(int Money) 
        {

            return this.Banlance;
        }

    }
}
