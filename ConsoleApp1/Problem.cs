using System;
using System.Collections.Generic;
using System.Text;
using CSharp;

namespace CSharp
{
    internal class Problem :/* Content*/ContentService
    {

        internal override void Publish(User promulgator, int Reward)
        {
            Console.WriteLine($"求助发布成功,用户{promulgator.GetName()}消耗帮帮币{Reward}");
        }

        //public Problem(string kind) : base(kind)
        //{
        //}


        public string Title { get; set; }
        public string Body { get; set; }
        private int _reward;

        public KeyWord[] KeyWords = new KeyWord[10];

        // Define the indexer to allow client code to use [] notation.
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
        public DateTime PublishDateTime { get; set; }
        public User Author { get; set; }
        public void Publish(string Title, string Body, int Rewward, DateTime PublishDateTime, User Author)
        {

        }
        //public Problem Load(int Id)
        //{
        //    return this /*Problem*/;
        //}
        internal void Delete(int Id)
        {

        }
        void repoistory() { }
    }
}
