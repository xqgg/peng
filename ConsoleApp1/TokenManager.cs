using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal class TokenManager
    {
        private int _tokens;


        internal void Add(Token token)
        {
            _tokens = _tokens += (int)token;
        }
    }



    internal enum Token
    {
        SuperAdmin = 1,
        Admin = 2,
        Blogger = 8,
        Newbie = 16,
        Registered = 32
    }

}
