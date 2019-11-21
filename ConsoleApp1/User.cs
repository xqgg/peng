using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal class User
    {
        internal string Name { get; set; }
        internal string Password { private get; set; }
        internal User InvitedBy { get; set; }
        internal void Register()
        {

        }
        internal void Login() { }
        private void ChangePasword() { }
    }
}
