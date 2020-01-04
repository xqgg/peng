using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSharp.TestGo
{
    class ProblemTestDo
    {
        public static void Do()
        {
            User user = new User("哈喽", "123as@");
            //Problem problem = new Problem("内容", user, -1);
            Problem problem = new Problem("内容", user, 1);
            problem.Reward = -1;
            //反射修改私有成员，未实现
            //var type = problem.GetType();
            //FieldInfo reward = type.GetField("_reward", BindingFlags.NonPublic | BindingFlags.Instance);
            //Console.WriteLine(reward.GetValue(problem));
            //reward.GetValue(problem);






        }

    }
}
