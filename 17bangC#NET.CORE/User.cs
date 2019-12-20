using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public sealed class User : Entity, IChat, ISendMessage
    {
        public User(string name, string pasword)
        {
            SetName(name);
            Password = pasword;
        }

        internal TokenManager _tokens;


        //public string Name { get; set; }
        string _Name;
        public void SetName(string name)
        {
            if (name == "admin")
            {
                _Name = "系统管理员";
            }
            else
            {
                _Name = name;
            }
        }
        public string GetName()
        {
            return _Name;
        }
        public string Password { private get; set; }
        public User InvitedBy { get; set; }
        public int HelpMoney { set; get; }
        public int HelpCradit { get; set; }

        public void Register()
        {

        }
        public void Login() { }
        private void _changePasword() { }

        void IChat.Send()
        {
            Console.WriteLine("Chat");
        }

        void ISendMessage.Send()
        {
            Console.WriteLine("Message");
        }
    }
}
