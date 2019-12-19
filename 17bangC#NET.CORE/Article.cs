using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal class Article : Content,IAppraise
    {

        public int Agrees { get; set; }
        public int Disagrees { get; set; }
        public Article(User author)
        {
            kind = kind.Article;
            Author = author;
        }

        public void Agree(User voter)
        {
            if (voter.HelpCradit <= 0)
            {
                throw new NotImplementedException("帮帮点余额不足，赞/踩需要消耗帮帮点");
            }
            Author.HelpCradit += 1;
            voter.HelpCradit -= 1;
            Agrees += 1;
        }

        public void Disagree(User voter)
        {
            if (voter.HelpCradit < 1)
            {
                throw new NotImplementedException("帮帮点余额不足，赞/踩需要消耗帮帮点");
            }
            voter.HelpCradit -= 1;
            if (Author.HelpCradit > 0)
            {
                Author.HelpCradit -= 1;
            }
            else
            {
                //作者的棒棒点为0，无法扣除遂不作处理。
            }
            Disagrees += 1;
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
