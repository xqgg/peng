﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class EmailMessage : ISendMessage
    {
        public void Send()
        {
            Console.WriteLine("邮件发送成功！");
        }
    }
}
