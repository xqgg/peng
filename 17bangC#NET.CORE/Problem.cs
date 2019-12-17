using System;
using System.Collections.Generic;
using System.Text;
using CSharp;

namespace CSharp
{
    internal class Problem : Content
    {
        public Problem(string body)
        {
            Body = body;
            kind = kind.Problem;
        }
        private int _reward;
        public KeyWord[] KeyWords = new KeyWord[10];
        public KeyWord this[int i]
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

        static public Problem Load(int Id)
        {
            return new Problem("hh");;
        }
        static public void Delete(int Id)
        {
            //根据ID删除指定的Problem
        }
        void Repository() { }
    }
}
