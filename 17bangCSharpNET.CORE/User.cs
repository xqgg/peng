using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;

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
        /// <summary>
        /// 将用户数据保存到数据库（注册）
        /// </summary>
        public int Save()
        {
            DBHelper dBHelper = new DBHelper();
            using (dBHelper.HelperConnection)
            {
                if (dBHelper.HelperConnection.State == ConnectionState.Closed)
                {
                    dBHelper.HelperConnection.Open();
                }
                return dBHelper.ExecuteNonQuery($"INSERT [User]([UserName],[Password],[InvitationCode]) VALUES('{Name}','{Password}','{InvitationCode}')");
            }
        }
        public void Save(DBHelper dBHelper)
        {
            dBHelper.ExecuteNonQuery($"INSERT [User]([UserName],[Password],[InvitationCode]) VALUES('{Name}','{Password}','{InvitationCode}')");
        }

        /// <summary>
        /// 批量保存用户
        /// </summary>
        /// <param name="users">用户对象</param>
        /// <returns>成功保存的数量</returns>
        public static int SaveSome(params User[] users)
        {
            int rowNumberAffected = 0;
            DBHelper dBHelper = new DBHelper();
            using (dBHelper.HelperConnection)
            {
                //if (dBHelper.HelperConnection.State == ConnectionState.Closed)
                //{
                //    dBHelper.HelperConnection.Open();
                //}
                //for (int i = 0; i < users.Length; i++)
                //{
                //    dBHelper.ExecuteNonQuery($"INSERT [User]([UserName],[Password],[InvitationCode]) VALUES('{users[i].Name}','{users[i].Password}','{users[i].InvitationCode}')");
                //    rowNumberAffected++;
                //}
                dBHelper.HelperConnection.Open();
                for (int i = 0; i < users.Length; i++)
                {
                    users[i].Save(dBHelper);
                    rowNumberAffected++;
                }
            }
            return rowNumberAffected;
        }

        /// <summary>
        /// 根据用户名查找用户，返回用户ID(适用于单次数据库操作)
        /// </summary>
        /// <param name="name">用户名</param>
        /// <returns></returns>
        static public int SeekUser(string name)
        {
            DBHelper dBHelper = new DBHelper();
            object result;
            using (dBHelper.HelperConnection)
            {
                dBHelper.HelperConnection.Open();
                result = dBHelper.ExecuteScalar($"SELECT [UserId] FROM [User] WHERE [UserName]='{name}'");
            }
            if (result == null)
            {
                return -1;
            }
            else
            {
                return (int)result;
            }
        }

        /// <summary>
        /// 根据用户名查找用户，返回用户ID,DBHelper的数据库连接需要在外界打开和关闭。（适用于连续数据库操作）
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="dBHelper">需要使用外界的DBHelper对象的数据库连接</param>
        /// <returns></returns>
        static public int SeekUser(string name, DBHelper dBHelper)
        {
            object result;
            result = dBHelper.ExecuteScalar($"SELECT [UserId] FROM [User] WHERE [UserName]='{name}'");
            if (result == null)
            {
                return -1;
            }
            else
            {
                return (int)result;
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
            User user = new User("shaohb", "ss&^81235");
            User user1 = new User("sisisohs", "ss&&85");
            User user2 = new User("adhgaj", "ss&&85");


            User.SaveSome(user, user1, user2);
            //user.Save();


        }


    }
}
