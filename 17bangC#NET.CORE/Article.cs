using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal class Article : Content
    {

        public Article(User author)
        {
            kind = kind.Article;
            Author = author;
        }
        public override void Publish()
        {
            if (Author.HelpMoney < 1)
            {
                throw new Exception("帮帮币余额不足1，不能发布文章");
            }
            else
            {
                base.Publish();
                Author.HelpMoney -= 1;
            }
        }

        //internal override void Publish(User promulgator, int Reward)
        //{
        //    Console.WriteLine($"成功发布Article，{promulgator.GetName()}消耗棒棒币1个。");
        //}
    }
}
