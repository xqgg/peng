using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal static class ArticleTestDo
    {
        public static void Do()
        {
            User user = new User("sasdj", "asdfa22&");
            Article article = new Article(user, "   ss    ");
            Console.WriteLine(article.Title);
            Console.WriteLine(article.GetKind());
        }
    }
}
