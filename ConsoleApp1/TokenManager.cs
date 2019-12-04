using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal class TokenManager
    {
        private Token _tokens;


        internal void Add(Token newToken)
        {
            this._tokens = this._tokens | newToken;
        }

        internal void Remove(Token delet)
        {
            this._tokens = this._tokens & ~delet;
        }

        internal bool Has(Token target)
        {
            if ((this._tokens & target) == target)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }



    internal enum Token
    {
        SuperAdmin = 1 << 0,
        Admin = 1 << 1,
        Blogger = 1 << 2,
        Newbie = 1 << 3,
        Registered = 1 << 4
    }

}
