using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharp
{
    internal class CheckPassword
    {
        static public string WhiteListOfLetter = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
        static public string WhiteListOfNumber = "0123456789";
        static public string WhiteListOfSymbol = "~!@#$%^&*()_+";
        private string _password { set; get; }
        private bool CheckWhiteList(string whiteList)
        {
            for (int i = 0; i < _password.Length; i++)
            {
                if (whiteList.Contains(_password[i]))
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckLength()
        {
            return _password.Length >= 6;
        }
        /// <summary>
        /// 检查密码,密码必须包含英文字母/数字/特殊符号。
        /// </summary>
        /// <returns></returns>
        public bool Checked(string password)
        {
            _password = password;
            return
            CheckLength() &&
            CheckWhiteList(WhiteListOfLetter) &&
            CheckWhiteList(WhiteListOfNumber) &&
            CheckWhiteList(WhiteListOfSymbol);
        }
    }
}
