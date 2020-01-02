using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace Training1
{
    class IO
    {
        public static void Do()
        {
            string path = @"D:\文档\email.txt";
            string content = File.ReadAllText(path);
            string[] emails = content.Split(';');
            for (int i = 0; i < emails.Length; i++)
            {
                emails[i] = emails[i].Trim();
            }
            List<string> distinct = (List<string>)emails.Distinct();
            StringBuilder joinEmail = new StringBuilder();
            for (int i = 0; i < distinct.Count; i++)
            {
                joinEmail.Append(distinct[i]);
                if (i % 30 == 0)
                {
                    joinEmail.Append(Environment.NewLine);
                }
            }
            File.WriteAllText(path, joinEmail.ToString());






        }

    }
}
