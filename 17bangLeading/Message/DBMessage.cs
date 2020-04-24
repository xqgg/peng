using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPage.Entities
{
    class DBMessage : ISendMessage
    {
        public void Send()
        {
            Console.WriteLine("已将消息存入数据库");
        }
    }
}
