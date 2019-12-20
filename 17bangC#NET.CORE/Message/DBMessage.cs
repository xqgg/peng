using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class DBMessage : ISendMessage
    {
        public void Send()
        {
            Console.WriteLine("已将消息存入数据库");
        }
    }
}
