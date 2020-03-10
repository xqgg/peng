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
                throw new Exception("", new Exception("", ae));
            }
            //如果是参数越界异常，Console.WriteLine()输出：求助的Reward为负数（-XX），不再抛出异常
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("求助的Reward为负数");
            }
            Console.WriteLine(SystemTime.Now().ToString("yyyy年MM月dd日 hh点mm分ss秒") + "请求发布内容（Id=XXX）");
            Console.WriteLine("将content存入数据库");
        }
    }



}
