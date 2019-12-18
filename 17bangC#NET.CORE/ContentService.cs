using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal static class ContentService
    {
        internal static void Publish( Content content)
        {
            content.Publish();
            Console.WriteLine("将content存入数据库");
        }
    }



}
