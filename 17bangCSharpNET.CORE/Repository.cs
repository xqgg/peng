using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharp
{
    static class Repository
    {
        public const int version = 1;
        internal static readonly string connection;



    }

    public class ProblemRepository
    {
        static IList<Problem> problems;

        static ProblemRepository()
        {
            User yh1 = new User("28zhu", "mima1!"),
                 yh2 = new User("WhiteWater", "mima2!");
            Keyword CSharp = new Keyword("C#"),
                    JAVA = new Keyword("JAVA"),
                    Windows = new Keyword("Windows"),
                    Linux = new Keyword("Linux"),
                    CPlusPlus = new Keyword("C++");
            string title1 = "有一个自定义UI控件，此控件使用在不同的系统中会有不同的呈现，之前的做法是各种switch case，阅读代码时让人很难受，另外新创建一个用到此控件的系统，要修改代码的地方也多，只要有swich case 的地方都要再加一个case。请教一个好一些的方式来处理这个问题，目的是让代码更加清楚",
                   title2 = "手动导入jar包，运行报错的问题";
            string body1 = "RT，也不知道描述的清楚不清楚。求一个思路",
                   body2 = "运行就报这个错误，这个jar包我导入项目了的，不然编译都无法通过。";

            problems = new List<Problem>
            {
                new Problem(body1,yh1)
                {
                    Title=title1,
                    KeyWords = new List<Keyword>
                    {
                        CSharp,
                        CPlusPlus,
                        JAVA
                    }
                 },
                new Problem(body2, yh1)
                {
                    Title = title2,
                    KeyWords = new List<Keyword>
                    {
                        CSharp,
                        Linux
                    }
                },
                new Problem(body2, yh2)
                {
                    Title = title2,
                    KeyWords = new List<Keyword>
                    {
                        CSharp,
                        CPlusPlus,
                        Windows

                    }
                },
                new Problem(body1,yh1)
                {
                    Title=title1,
                    KeyWords = new List<Keyword>
                    {
                        CSharp,
                        CPlusPlus,
                        JAVA
                    }
                 },
                new Problem(body2, yh2)
                {
                    Title = title2,
                    KeyWords = new List<Keyword>
                    {
                        CSharp,
                        CPlusPlus,
                        Windows

                    }
                },
                new Problem(body2, yh2)
                {
                    Title = title2,
                    KeyWords = new List<Keyword>
                    {
                        CSharp,
                        CPlusPlus,
                        Windows

                    }
                },
                new Problem(body1,yh1)
                {
                    Title=title1,
                    KeyWords = new List<Keyword>
                    {
                        CSharp,
                        CPlusPlus,
                        JAVA
                    }
                 },
                new Problem(body2, yh2)
                {
                    Title = title2,
                    KeyWords = new List<Keyword>
                    {
                        CSharp,
                        CPlusPlus,
                        Windows

                    }
                },
                new Problem(body1,yh1)
                {
                    Title=title1,
                    KeyWords = new List<Keyword>
                    {
                        CSharp,
                        CPlusPlus,
                        JAVA
                    }
                 },
                new Problem(body1,yh1)
                {
                    Title=title1,
                    KeyWords = new List<Keyword>
                    {
                        CSharp,
                        CPlusPlus,
                        JAVA
                    }
                 },
                new Problem(body2, yh2)
                {
                    Title = title2,
                    KeyWords = new List<Keyword>
                    {
                        CSharp,
                        CPlusPlus,
                        Windows

                    }
                }
            };
            foreach (var item in problems)
            {
                ContentService.Publish(item);
            }

        }

        /// <summary>
        /// </summary>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">数据量</param>
        /// <returns></returns>
        public List<Problem> Get(int pageIndex, int pageSize)
        {
            return problems.OrderByDescending(p => p.PublishTime)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize).ToList();

        }
        public int CountOfProblem()
        {
            return problems.Count;
        }
    }
}
