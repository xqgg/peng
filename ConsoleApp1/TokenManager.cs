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

        internal void Remove(Token token)
        {
            _tokens = _tokens -= (int)token;
        }

    }



    internal enum Token
    {
        SuperAdmin = 0,
        Admin = 1 << 0,
        Blogger = 1 << 1,
        Newbie = 1 << 2,
        Registered = 1 << 3
    }

}
