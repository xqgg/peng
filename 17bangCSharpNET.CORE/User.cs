using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp
{
    public sealed class User : Entity, IChat, ISendMessage
    {
        internal TokenManager _tokens;
        string _Name;
        public string Password { private get; set; }
        public User InvitedBy { get; set; }
        public int HelpMoney { set; get; }
        public int HelpCradit { get; set; }


        public User(string name, string password)
        {
            if (new CheckPassword().Checked(password) &&
                new CheckUserName().Check(name))
            {
                SetName(name);
                Password = password;
            }
            else
            {
                throw new ArgumentOutOfRangeException("用户名或密码不规范");
            }
        }
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
            User user = new User("ssssss", "ss&&8");

        }
    }
}
