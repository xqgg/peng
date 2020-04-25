using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using RazorPage.Helper;

namespace RazorPage.Entities
{
    public sealed class User : Entity, IChat, ISendMessage
    {
        internal TokenManager _tokens;
        public string Name { get; private set; }
        public string Password { get; set; }
        public User InvitedBy { get; set; }
        public int HelpMoney { set; get; }
        public int HelpCradit { get; set; }
        public string InvitationCode { get; private set; }
        private string _truePassword;

        public User(string name, string password)
        {
            CheckNameOrPassword checker = new CheckNameOrPassword();
            if (!(checker.CheckPassword(name) && checker.CheckName(name)))
            {
                SetName(name);
                Password = password;
            }
            else
            {
                throw new ArgumentOutOfRangeException("用户名或密码不规范");
            }
        }

        public User()
        {

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
            GenerateInvitationCode();
            Password = StringExtension.GetMd5Hash(Password);
            using (dBHelper.HelperConnection)
            {
                _truePassword = Password;
                Password = StringExtension.GetMd5Hash(Password);
                SqlParameter pName = new SqlParameter("@Name", Name);
                SqlParameter pPassword = new SqlParameter("@Password", Password);
                SqlParameter pTruePassword = new SqlParameter("@TruePassword", _truePassword);
                SqlParameter pInvitationCode = new SqlParameter("@InvitationCode", InvitationCode);
                dBHelper.OpenConnection();
                return dBHelper.ExecuteNonQuery("INSERT [User]([Name],[Password],[InvitationCode],[TruePassword]) VALUES(@Name,@Password,@InvitationCode,@TruePassword)", pName, pPassword, pInvitationCode, pTruePassword);
            }
        }
        /// <summary>
        /// 用于连续数据库操作，其内部不操作数据库连接,DBHelper用于提供一个外部的长连接
        /// </summary>
        /// <param name="dBHelper"></param>
        public void Save(DBHelper dBHelper)
        {
            GenerateInvitationCode();
            _truePassword = Password;
            Password = StringExtension.GetMd5Hash(Password);
            SqlParameter pName = new SqlParameter("@Name", Name);
            SqlParameter pPassword = new SqlParameter("@Password", Password);
            SqlParameter pTruePassword = new SqlParameter("@TruePassword", _truePassword);
            SqlParameter pInvitationCode = new SqlParameter("@InvitationCode", InvitationCode);
            dBHelper.ExecuteNonQuery("INSERT [User]([Name],[Password],[InvitationCode],[TruePassword]) VALUES(@Name,@Password,@InvitationCode,@TruePassword)", pName, pPassword, pInvitationCode, pTruePassword);
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
                dBHelper.HelperConnection.Open();
                for (int i = 0; i < users.Length; i++)
                {
                    //users[i].GenerateInvitationCode();因为使用Save方法中会调用一次所以这里不需要了。
                    users[i].Save(dBHelper);
                    rowNumberAffected++;
                }
            }
            return rowNumberAffected;
        }

        ///// <summary>
        ///// 根据用户名查找用户，返回用户ID(适用于单次数据库操作)
        ///// </summary>
        ///// <param name="name">用户名</param>
        ///// <returns></returns>
        //static public int SeekUser(string name)
        //{
        //    DBHelper dBHelper = new DBHelper();
        //    object result;
        //    using (dBHelper.HelperConnection)
        //    {
        //        dBHelper.HelperConnection.Open();
        //        result = dBHelper.ExecuteScalar($"SELECT [UserId] FROM [User] WHERE [UserName]='{name}'");
        //    }
        //    if (result == null)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        return (int)result;
        //    }
        //}

        /// <summary>
        /// 根据用户名查找用户，返回用户ID,DBHelper的数据库连接需要在外界打开和关闭。（适用于连续数据库操作）
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="dBHelper">需要使用外界的DBHelper对象的数据库连接</param>
        /// <returns></returns>
        //static public int SeekUser(string name, DBHelper dBHelper)
        //{
        //    object result;
        //    result = dBHelper.ExecuteScalar($"SELECT [Id] FROM [User] WHERE [Name]=N'{name}'");
        //    if (result == null)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        return (int)result;
        //    }
        //}

        static public IList<User> GetUsers()
        {
            IList<User> users = new List<User>();
            DBHelper helper = new DBHelper();

            helper.HelperConnection.Open();
            SqlDataReader reader = helper.ExecuteReader("SELECT *FROM [User]");
            //bool hasAnotherRow = reader.Read();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    users.Add(User.map(reader));
                }
            }
            helper.HelperConnection.Close();
            return users;
        }

        /// <summary>
        /// 单次查询，由内部提供数据库连接对象
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static public User GetUserByName(string name)
        {
            DBHelper helper = new DBHelper();
            SqlParameter pName = new SqlParameter("@Name", name);
            helper.HelperConnection.Open();
            SqlDataReader reader = helper.ExecuteReader(@"SELECT * FROM [User] WHERE [Name]=@Name", pName);
            if (reader.HasRows)
            {
                reader.Read();
            }
            else
            {
                // return new User() { Id = -1 };//ID=-1表示没有该用户
                return null;
            }
            User result = User.map(reader);
            helper.HelperConnection.Close();
            return result;
        }

        /// <summary>
        /// 需要从外部关闭数据库连接（适用于多次连续数据库操作）
        /// </summary>
        /// <param name="name"></param>
        /// <param name="helper">外部传入的DBHelper用以提供长数据库连接</param>
        /// <returns></returns>
        static public User GetUserByName(string name, DBHelper helper)
        {

            SqlParameter pName = new SqlParameter("@Name", name);
            using (SqlDataReader reader = helper.ExecuteReader(@"SELECT * FROM [User] WHERE [Name]=@Name", pName))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                }
                else
                {
                    return null;
                    //return new User() { Id = -1 };//ID=-1表示没有该用户
                }
                User result = User.map(reader);
                return result;
            }
            //SqlDataReader reader = helper.ExecuteReader(@"SELECT * FROM [User] WHERE [Name]=@Name", pName);

        }

        /// <summary>
        /// 单次查询，由内部提供数据库连接对象
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        static public User GetUserById(int Id)
        {
            DBHelper helper = new DBHelper();
            SqlParameter pId = new SqlParameter("@pId", Id);
            helper.HelperConnection.Open();
            SqlDataReader reader = helper.ExecuteReader(@"SELECT * FROM [User] WHERE [Id]=@pId", pId);
            if (reader.HasRows)
            {
                reader.Read();
            }
            else
            {
                // return new User() { Id = -1 };//ID=-1表示没有该用户
                return null;
            }
            User result = User.map(reader);
            helper.HelperConnection.Close();
            return result;
        }

        static private User map(SqlDataReader reader)
        {
            return new User()
            {
                Id = (int)reader[StringConst.ID],
                Name = (string)reader[StringConst.NAME],
                Password = (string)reader[StringConst.PASSWORD],
                InvitationCode = (string)reader[StringConst.USER_INVITATIONCODE]
            };
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
        /// 生成0到9999之间的邀请码。
        /// </summary>
        public void GenerateInvitationCode()
        {
            Random random = new Random();
            InvitationCode = random.Next(0, 10000).ToString().PadLeft(4, '0');
        }

        public static void UserDo()
        {
            //IList<User> users = User.GetUsers();


            //foreach (var item in users)
            //{
            //    Console.WriteLine(item.Id);
            //}
            //User user = new User("sdfah", "asdfa@222");
            //Console.WriteLine(user.InvitationCode);
            //User user = new User();
            //user = User.GetUserByName("8");
            //Console.WriteLine(user.Id);
            //User user = new User("赵日天123", "123a#%");
            //user.Save();
            //User.GetUserByName("赵日天嘻嘻嘻");
            Console.WriteLine(GetUserById(15).Name);

        }


    }
}
