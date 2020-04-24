using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("CSharpTest")]
 namespace RazorPage.Entities
{
    internal class TokenManager
    {
        public Token _tokens;


        public void Add(Token newToken)
        {
            if (Has(newToken))
            {
                throw new ArgumentException("不能重复添加相同的令牌");
            }
            else
            {
                _tokens = _tokens | newToken;

            }
        }

        public void Remove(Token delete)
        {
            if (Has(delete))
            {
                _tokens = _tokens & ~delete;

            }
            else
            {
                throw new ArgumentException("无法删除一个不存在的令牌");
            }
        }

        public bool Has(Token target)
        {
            return (_tokens & target) == target;

        }
    }


    [Flags]
    internal enum Token
    {
        SuperAdmin = 1 << 0,
        Admin = 1 << 1,
        Blogger = 1 << 2,
        Newbie = 1 << 3,
        Registered = 1 << 4
    }

}
