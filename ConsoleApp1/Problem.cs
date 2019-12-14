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
            Console.WriteLine($"求助发布成功,用户{promulgator.getName()}消耗帮帮币{Reward}");
        }

        //public Problem(string kind) : base(kind)
        //{
        //}


        public string Title { get; set; }
        public string Body { get; set; }
        public int Reward { get; set; }
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
