using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal class Suggest : ContentService
    {
        //internal override void Publish(User promulgator, int bangMoney, int Reward)
        //{
        //    //父类
        //}
        internal override void Publish(User promulgator, int Reward = 0)
        {
            //base.Publish(promulgator, bangMoney, Reward);){ }
            Console.WriteLine($"{promulgator.GetName()}成功发布Suggest，无需消耗帮帮币。");
        }
    }
}
