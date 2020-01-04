using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.TestGo
{
    class ServiceTestDo
    {
        public static void Do()
        {
            User user = new User("sd", "sf@@%4");
            Article article = new Article(user, "sdsd");

            //在Main()函数调用ContentService时，捕获一切异常，并记录（）异常的消息和堆栈信息
            try
            {
                ContentService.Publish(article);
            }
            catch (Exception)
            {
                Console.WriteLine("记录异常的消息和堆栈信息");
                //throw;
            }
        }
    }
}
