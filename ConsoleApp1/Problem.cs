using System;
using System.Collections.Generic;
using System.Text;
using CSharp;

namespace CSharp
{
    internal class Problem :/* Content*/ContentService
    {

        internal override void Publish(User promulgator, int bangMoney, int Reward)
        {
            Console.WriteLine($"求助发布成功,用户{promulgator.getName()}消耗帮帮币{Reward}");
        }
        private string v;

        //public Problem(string kind) : base(kind)
        //{
        //}


        internal string Title { get; set; }
        internal string Body { get; set; }
        internal int Reward { get; set; }
        internal DateTime PublishDateTime { get; set; }
        internal User Author { get; set; }
        internal void Publish(string Title, string Body, int Rewward, DateTime PublishDateTime, User Author)
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
