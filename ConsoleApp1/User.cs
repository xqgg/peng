using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal class User
    {
        //internal string Name { get; set; }
        string _Name;
        internal void setName(string name)
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
        internal string getName()
        {
            return _Name;
        }
        internal string Password { private get; set; }
        internal User InvitedBy { get; set; }
        internal void Register()
        {

        }
        internal void Login() { }
        private void ChangePasword() { }
    }
}
