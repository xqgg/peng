using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class CheckUserName
    {
        public string[] BlackList = { "admin", "17bang", "管理员" };
        public bool Check(string name)
        {
            Boolean result = true;
            for (int i = 0; i < BlackList.Length; i++)
            {
                if (name.Contains(BlackList[i]))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
