using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal static class ContentService
    {
        internal static void Publish(Content content)
        {
            try
            {
                content.Publish();
            }
            //将当前异常封装进新异常的InnerException，再将新异常抛出
            catch (ArgumentNullException ae)
            {
                Console.WriteLine("内容的作者不能为空");
                throw new Exception("", new Exception("",ae));
            }
            Console.WriteLine("将content存入数据库");
        }
    }



}
