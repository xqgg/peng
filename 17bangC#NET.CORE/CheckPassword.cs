using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharp
{
    class CheckPassword
    {
        static public string WhiteListOfLetter = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
        static public string WhiteListOfNumber = "0123456789";
        static public string WhiteListOfSymbol = "~!@#$%^&*()_+";
        static public string[] Variety = { WhiteListOfLetter, WhiteListOfNumber, WhiteListOfSymbol };


        public bool Check(string password)
        {
            if (password.Length < 6)
            {
                throw new Exception("密码不能小于6个字符");
            }
            int result = 0;
            for (int i = 0; i < Variety.Length; i++)
            {
                for (int j = 0; j < password.Length; j++)
                {
                    if (Variety[i].Contains(password[j]))
                    {
                        result += 1;
                        break;
                    }
                }
            }
            //result=Variety.Length的时候表示所有类型的检测都通过了。
            return result == Variety.Length;
        }
    }
}
