using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp
{
    public sealed class User : Entity, IChat, ISendMessage
    {
        private string[] _blacklist = { "admin", "17bang", "管理员" };

        public User(string name, string pasword)
        {

            for (int i = 0; i < _blacklist.Length; i++)
            {
                if (name.Contains(_blacklist[i]))
                {
                    throw new ArgumentOutOfRangeException("用户名不能为（admin, 17bang, 管理员）等违禁词");
                }
            }
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


        public static void UserDo()
        {
            User user = new User("sss管理员sss", "");

        }
    }
}
