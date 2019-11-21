using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal class HolpMoney
    {
        internal User User { get; set; }
        internal int Balance { get; set; }
        internal int Bncome { get; set; }//正数为收入，负数为消费
        internal DateTime BainTime { get; set; }
        internal string Cause { get; set; }
        internal string Remarks { get; set; }
        internal void MoneyGain(User user, int balance, int income, DateTime gainTime, string cause, string remarks)
        {

        }
        internal void MoneyExpense(User user, int balance, int income, DateTime gainTime, string cause, string remarks)
        {

        }


    }
}
