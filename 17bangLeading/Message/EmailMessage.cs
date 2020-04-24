using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPage.Entities
{
    class EmailMessage : ISendMessage
    {
        public void Send()
        {
            Console.WriteLine("邮件发送成功！");
        }
    }
}
