using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.TestGo
{
    class ContentTestDo
    {
        public static void Do()
        {
            //内容（Content）发布（Publish）的时候检查其作者（Author）是否为空，如果为空抛出“参数为空”异常
            User user = new User("哈哈", "asd*6j");
            Content content = new Suggest(user);
            content.Author = null;
            ContentService.Publish(content);
        }
    }
}
