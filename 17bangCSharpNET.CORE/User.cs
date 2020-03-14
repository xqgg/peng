using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp
{
    public sealed class User : Entity, IChat, ISendMessage
    {
        internal TokenManager _tokens;
        public string Name { get; private set; }
        public string Password { private get; set; }
        public User InvitedBy { get; set; }
        public int HelpMoney { set; get; }
        public int HelpCradit { get; set; }
        public string InvitationCode { get; private set; }

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
            GenerateInvitationCode();
        }
        public void SetName(string name)
        {
            if (name == "admin")
            {
                Name = "系统管理员";
            }
            else
            {
                Name = name;
            }
        }
        //public string GetName()
        //{
        //    return _Name;
        //}

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
        /// <summary>
        /// 生成0到9999之间的邀请码，查重功能暂未完成。
        /// </summary>
        public void GenerateInvitationCode()
        {
            Random random = new Random();
            InvitationCode = random.Next(0, 10000).ToString().PadLeft(4, '0');
        }

        public static void UserDo()
        {
            User user = new User("ssssss", "ss&&8");

        }
    }
}
