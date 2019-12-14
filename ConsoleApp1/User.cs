using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal sealed class User
    {
        internal TokenManager _tokens;
        //internal string Name { get; set; }
        string _name;
        internal void setName(string name)
        {
            if (name == "admin")
            {
                _name = "系统管理员";
            }
            else
            {
                _name = name;
            }
        }
        internal string getName()
        {
            return _name;
        }
        internal string password { private get; set; }
        internal User invitedBy { get; set; }
        internal int bangMoney { set; get; }

        internal void register()
        {

        }
        internal void login() { }
        private void _changePasword() { }
    }
}
