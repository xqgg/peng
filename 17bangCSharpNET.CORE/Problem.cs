using System;
using System.Collections.Generic;
using System.Text;
using CSharp;

namespace CSharp
{
    public class Problem : Content
    {
        public Problem(string body, User author, int reward = 0) : base(kind.Problem)
        {
            try
            {
                rewardCheck(reward);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("求助的Reward为负数");
                throw;
            }
            //rewardCheck(reward);
            Body = body;
            Reward = reward;
            Author = author;
        }
        private int _reward;
        public IList<Keyword> KeyWords;
        //public Keyword this[int i]
        //{
        //    get { return KeyWords[i]; }
        //    set { KeyWords[i] = value; }
        //}

        public int Reward
        {
            get { return _reward; }
            set
            {
                try
                {
                    rewardCheck(value);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("求助的Reward为负数");
                    throw;
                }
                _reward = value;
            }
        }

        public override void Publish()
        {
            //Reward属性的Get中已有检查，所以无需在发布时显式运行rewardCheck()。
            if (Author.HelpMoney < Reward)
            {
                throw new Exception("帮帮币余额不足，请调整悬赏后重试");
            }
            else
            {
                base.Publish();
                Author.HelpMoney -= _reward;
            }
        }

        private void rewardCheck(int byReward)
        {
            //是否可使用 uint 来保证Reward不为负数？
            if (byReward < 0)
            {
                throw new ArgumentOutOfRangeException("悬赏不能小于0");
            }
        }
        //static public Problem Load(int Id)
        //{
        //    return new Problem("hh", 1, author);
        //}
        //暂无法实现
        static public void Delete(int Id)
        {
            //根据ID删除指定的Problem
        }
        void Repository() { }
    }
}
