using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace CSharp
{
    static class LinqQuery
    {
        public static void Wait()
        {
            Random wait = new Random();
            Thread.Sleep(wait.Next(100, 3000));
        }
        public static void LinqDo()
        {
            User pzq = new User("彭志强", "555s@5");
            User xlt = new User("幸龙泰", "sdoj&8");
            User cy = new User("陈元", "8855*h");
            User fg = new User("飞哥", "123ab!");
            User xy = new User("小余", "123kk*");
            Keyword sql = new Keyword("SQL");
            Keyword js = new Keyword("JS");
            Keyword html = new Keyword("html");
            Keyword css = new Keyword("css");
            Keyword csharp = new Keyword("C#");
            Keyword net = new Keyword(".NET");
            Article LeadingEnd = new Article(fg, "前端", html, js);
            Article DataBase = new Article(fg, "数据库", sql);
            Article AfterEnd = new Article(fg, "后端", csharp, net);
            Article UI = new Article(xy, "UI", css);
            LeadingEnd.Publish();
            Wait();
            DataBase.Publish();
            Wait();
            AfterEnd.Publish();
            Wait();
            UI.Publish();
            Comment comment1 = new Comment(pzq, "飞哥真帅", LeadingEnd);
            Comment comment2 = new Comment(cy, "讲得好", AfterEnd);
            Comment comment3 = new Comment(xlt, "沙区扛把子觉得你可以", DataBase);
            Comment comment4 = new Comment(xlt, "这个好！这个好！", UI);
            comment1.Publish();
            comment2.Publish();
            comment3.Publish();
            comment4.Publish();





        }
    }
}
