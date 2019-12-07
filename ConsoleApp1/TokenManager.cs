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
            if (this.Has(newToken))
            {
                throw new ArgumentException("不能重复添加相同的令牌");
            }
            else
            {
                this._tokens = this._tokens | newToken;

            }
        }

        internal void Remove(Token delet)
        {
            if (this.Has(delet))
            {
                this._tokens = this._tokens & ~delet;

            }
            else
            {
                throw new ArgumentException("无法删除一个不存在的令牌")
            }
        }

        internal bool Has(Token target)
        {
            return (this._tokens & target) == target;

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
