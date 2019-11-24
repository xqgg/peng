using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Article : ContentService
    {
        internal override void Publish(User promulgator, int bangMoney, int Reward)
        {
            Console.WriteLine($"成功发布Article，{promulgator.getName()}消耗棒棒币1个。");
        }
    }
}
