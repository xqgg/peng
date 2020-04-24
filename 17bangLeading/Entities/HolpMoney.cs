using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPage.Entities
{
    public class HolpMoney : Entity
    {
        public User User { get; set; }
        public int Balance { get; set; }
        public int Income { get; set; }//正数为收入，负数为消费
        public DateTime BainTime { get; set; }
        public string Cause { get; set; }
        public string Remarks { get; set; }
        public void MoneyGain(User user, int balance, int income, DateTime gainTime, string cause, string remarks)
        {

        }
        public void MoneyExpense(User user, int balance, int income, DateTime gainTime, string cause, string remarks)
        {

        }


    }
}
