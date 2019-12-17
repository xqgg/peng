using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public sealed class User : Entity
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
        public int BangMoney { set; get; }

        public void Register()
        {

        }
        public void Login() { }
        private void _changePasword() { }
    }
}
