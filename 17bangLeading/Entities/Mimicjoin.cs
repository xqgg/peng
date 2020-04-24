using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPage.Entities
{
    public class MimicJoin
    {
        //不使用string自带的Join()方法，定义一个mimicJoin()方法，能将若干字符串用指定的分隔符连接起来，
        //比如：mimicJoin("-","a","b","c","d")，其运行结果为：a-b-c-d
        public string mimicJoin(string separator, params string[] str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                result.Append(str[i]);
                if (i == str.Length - 1)
                {
                    break;
                }
                result.Append(separator);
            }
            return result.ToString();
        }
    }
}
