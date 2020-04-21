using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;

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
            if (new CheckNameOrPassword().Checked(name, password))
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
        /// <summary>
        /// 将用户数据保存到数据库（注册）
        /// </summary>
        public bool Save(SqlConnection connection)
        {
            //_dBHelper.ExecuteNonQuery(
            //    $"INSERT [User]([UserName],[Password],[InvitationCode]) VALUES({Name},{Password},{InvitationCode})",
            //    connection);
            return true;
        }

        public static void SaveSome(params User[] users)
        {


            DBHelper dBHelper = new DBHelper();
            using (dBHelper.SqlConnection)
            {
                dBHelper.SqlConnection.Open();
                for (int i = 0; i < users.Length; i++)
                {
                    dBHelper.ExecuteNonQuery($"INSERT [User]([UserName],[Password],[InvitationCode]) VALUES('{users[i].Name}','{users[i].Password}','{users[i].InvitationCode}')",
                                             dBHelper.SqlConnection);
                }
            }
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
            User user = new User("ssssss", "ss&&85");
            User user1 = new User("adohs", "ss&&85");
            User user2 = new User("ssas1afa23ssss", "ss&&85");


            User.SaveSome(user1, user2);

        }


    }
}
