using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharp
{
    public class CheckNameOrPassword
    {
        static private string WhiteListOfLetter = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
        static private string WhiteListOfNumber = "0123456789";
        static private string WhiteListOfSymbol = "~!@#$%^&*()_+";
        private string[] BlackList = { "admin", "17bang", "管理员" };

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
        /// <summary>
        /// 检查密码长度,密码长度不少于6位不超过25位。
        /// </summary>
        /// <returns></returns>
        private bool CheckPLength()
        {
            return _password.Length >= 6 && _password.Length <= 25;
        }

        /// <summary>
        /// 检查用户名是否合法
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static public bool CheckName(string name)
        {
            if (!(name.Length >= 4 && name.Length <= 20))
            {
                return false;
            }
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

        /// <summary>
        /// 检查用户名、密码
        /// 用户名不得包含（"admin", "17bang", "管理员"）
        /// 密码必须包含英文字母/数字/特殊符号。
        /// </summary>
        /// <returns></returns>
        static public bool CheckPassword(string password)
        {

            _password = password;
            return
            CheckPLength() &&
            CheckWhiteList(WhiteListOfLetter) &&
            CheckWhiteList(WhiteListOfNumber) &&
            CheckWhiteList(WhiteListOfSymbol);
        }




    }
}
