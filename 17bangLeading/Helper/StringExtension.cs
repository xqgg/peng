using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RazorPage.Helper
{
    public static class StringExtension
    {
        public static string GetMd5Hash(this string input)
        {
            using (MD5 mD5Hash = MD5.Create())
            {
                input = input + "17bang-peng";
                byte[] sourceData = mD5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                byte[] secondaryInfilling = mD5Hash.ComputeHash(sourceData);
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < secondaryInfilling.Length; i++)
                {
                    stringBuilder.Append(secondaryInfilling[i].ToString("x2"));
                }
                return stringBuilder.ToString();
            }

        }
    }
}
