using System;
using System.Collections.Generic;
using System.Linq;
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
            User pzq = new User("彭志强", "555s@5") { HelpMoney = 100, HelpCradit = 100 };
            User xlt = new User("幸龙泰", "sdoj&8") { HelpMoney = 100, HelpCradit = 100 };
            User cy = new User("陈元", "8855*h") { HelpMoney = 100, HelpCradit = 100 };
            User fg = new User("飞哥", "123ab!") { HelpMoney = 100, HelpCradit = 100 };
            User xy = new User("小余", "123kk*") { HelpMoney = 100, HelpCradit = 100 };
            Keyword sql = new Keyword("SQL");
            Keyword js = new Keyword("JS");
            Keyword html = new Keyword("html");
            Keyword css = new Keyword("css");
            Keyword csharp = new Keyword("C#");
            Keyword dotnet = new Keyword(".NET");
            Article LeadingEnd = new Article(fg, "前端", html, js);
            Article DataBase = new Article(fg, "数据库", sql);
            Article AfterEnd = new Article(fg, "后端", csharp, dotnet);
            Article UI = new Article(xy, "UI", css);
            LeadingEnd.Publish();
            //Wait();
            DataBase.Publish();
            //Wait();
            AfterEnd.Publish();
            //Wait();
            UI.Publish();
            Comment comment1 = new Comment(pzq, "飞哥真帅", LeadingEnd);
            Comment comment2 = new Comment(cy, "讲得好", AfterEnd);
            Comment comment3 = new Comment(xlt, "沙区扛把子觉得你可以", DataBase);
            Comment comment4 = new Comment(xlt, "这个好！这个好！", UI);
            comment1.Publish();
            comment2.Publish();
            comment3.Publish();
            comment4.Publish();

            IEnumerable<Article> articles = new List<Article> { LeadingEnd, DataBase, AfterEnd, UI };


            //找出“飞哥”发布的文章
            var articleOfFg = from a in articles
                              where a.Author.GetName() == "飞哥"
                              select a;
            var articleOfFgLam = articles.Where(a => a.Author.GetName() == "飞哥");
            Console.WriteLine("飞哥发布的文章有如下：");
            foreach (var item in articleOfFg)
            {
                Console.WriteLine(item.Title);
            }
            Console.WriteLine();


            //找出2019年1月1日以后“小鱼”发布的文章
            var articleTo190101OfXy = from a in articles
                                      where a.PublishTime > new DateTime(2019 - 1 - 1) && a.Author.GetName() == "小余"
                                      select a;
            var articleTo190101OfXyLam = articles.Where(a => a.PublishTime > new DateTime(2019 - 1 - 1) && a.Author.GetName() == "小余");


            Console.WriteLine("小余于2019-01-01之后发布的文章有如下：");
            foreach (var item in articleTo190101OfXy)
            {
                Console.WriteLine(item.Title);
            }
            Console.WriteLine();
            //foreach (var item in articleTo190101OfXyLam)
            //{
            //    Console.WriteLine(item.Title);
            //}


            //按发布时间升序 / 降序排列显示文章
            var articleOrderByTimeAsce = from a in articles
                                         orderby a.PublishTime ascending
                                         select a;

            var articleOrderByTimeDesc = from a in articles
                                         orderby a.PublishTime descending
                                         select a;

            var articleOrderByTimeAsceLam = articles.OrderBy(a => a.PublishTime);
            var articleOrderByTimeDescLam = articles.OrderByDescending(a => a.PublishTime);
            Console.WriteLine("按发布时间升序排列：");
            foreach (var item in articleOrderByTimeAsce)
            {
                Console.WriteLine(item.Title);
                Console.WriteLine(item.PublishTime);
            }
            Console.WriteLine();


            //统计每个用户各发布了多少篇文章
            var articleCount = from a in articles
                               group a by a.Author into ac
                               select new
                               {
                                   name = ac.Key.GetName(),
                                   count = ac.Count()
                               };
            var articleCountLam = articles.GroupBy(a => a.Author)
                                          .Select(ac => new
                                          {
                                              name = ac.Key.GetName(),
                                              count = ac.Count()
                                          });
            Console.WriteLine("统计用户发布的文章：");
            foreach (var item in articleCount)
            {
                Console.WriteLine(item.name + item.count);
            }
            Console.WriteLine();


            //找出包含关键字“C#”或“.NET”的文章
            var articleContainToCsharpOrDotnet = from a in articles
                                                 where a.Keywords.IndexOf(csharp) >= 0 || a.Keywords.IndexOf(dotnet) >= 0
                                                 select a;
            var articleContainToCsharpOrDotnetLam = articles.Where(
                                            a =>
                                            a.Keywords.Contains(csharp) ||
                                            a.Keywords.Contains(dotnet));
            foreach (var item in articleContainToCsharpOrDotnet)
            {
                Console.WriteLine("包含关键字“C#”或“.NET”的文章：");
                Console.WriteLine(item.Title);
            }
            Console.WriteLine();

            //找出评论数量最多的文章，相同就取第一个
            var articleOfCommentMost = from a in articles
                                       orderby a.Comments.Count() ascending
                                       select a;
            Console.WriteLine("找出评论数量最多的文章：");
            Console.WriteLine(articleOfCommentMost.First().Title);
            Console.WriteLine();

            //找出每个作者评论数最多的文章
            var CommentMostOfAuthor = from a in articles
                                      group a by a.Author into cm
                                      select new
                                      {
                                          name = cm.Key.GetName(),
                                          title = cm.OrderBy(c => c.Comments.Count()).First().Title
                                      };
            Console.WriteLine("找出每个作者评论数最多的文章：");
            foreach (var item in CommentMostOfAuthor)
            {
                Console.WriteLine(item.name + item.title);
            }
            Console.WriteLine();


            //找出每个作者最近发布的一篇文章
            var FinallyArticle = from a in articles
                                 group a by a.Author into ga
                                 select new
                                 {
                                     author = ga.Key.GetName(),
                                     title = ga.OrderByDescending(a => a.PublishTime).First().Title
                                 };
            Console.WriteLine("找出每个作者最近发布的一篇文章：");
            foreach (var item in FinallyArticle)
            {
                Console.WriteLine(item.author + item.title);
            }


            Problem problem1 = new Problem("标题1", fg, 19);
            Problem problem2 = new Problem("标题2", fg);
            Problem problem3 = new Problem("标题2", xlt, 20);
            ContentService.Publish(problem1);
            ContentService.Publish(problem2);
            ContentService.Publish(problem3);





        }
    }
}
