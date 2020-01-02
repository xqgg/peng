using System;
using System.Collections.Generic;
using System.Text;
using CSharp;

namespace CSharp
{
    internal class Problem : Content
    {
        public Problem(string body, User author, int reward = 0) : base(kind.Problem)
        {
            Body = body;

            Reward = reward;
            Author = author;
        }
        private int _reward;
        public Keyword[] KeyWords = new Keyword[10];
        public Keyword this[int i]
        {
            get { return KeyWords[i]; }
            set { KeyWords[i] = value; }
        }

        public int Reward
        {
            get { return _reward; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("悬赏不能小于0");
                }
                _reward = value;
            }
        }

        public override void Publish()
        {
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
