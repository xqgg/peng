using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal class HolpMoney
    {
        internal User User;
        internal int balance;
        internal int income;//正数为收入，负数为消费
        internal DateTime gainTime;
        internal string cause;
        internal string remarks;
        internal void MoneyGain(User user, int balance, int income, DateTime gainTime, string cause, string remarks)
        {

        }
        internal void MoneyExpense(User user, int balance, int income, DateTime gainTime, string cause, string remarks)
        {

        }


    }
}
