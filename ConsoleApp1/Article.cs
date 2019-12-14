using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal class Article : ContentService
    {
        internal override void Publish(User promulgator, int Reward)
        {
            Console.WriteLine($"成功发布Article，{promulgator.GetName()}消耗棒棒币1个。");
        }
    }
}
