using System;
using CSharp;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IChat user = new User("", "");
            user.Send();

            ISendMessage message = new User("", "");
            message.Send();
        }

    }
}