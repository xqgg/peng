using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal class HolpMoney
    {
        internal User user { get; set; }
        internal int balance { get; set; }
        internal int income { get; set; }//正数为收入，负数为消费
        internal DateTime bainTime { get; set; }
        internal string cause { get; set; }
        internal string remarks { get; set; }
        internal void moneyGain(User user, int balance, int income, DateTime gainTime, string cause, string remarks)
        {

        }
        internal void moneyExpense(User user, int balance, int income, DateTime gainTime, string cause, string remarks)
        {

        }


    }
}
