using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    static class Repository
    {
        public const int version = 1;
        internal static readonly string connection;



    }

    public class ProblemRepository
    {
        public IList<Problem> Get()
        {
            User yh1 = new User("用户1", "mima1!"),
                 yh2 = new User("用户2", "mima2!");
            Keyword CSharp = new Keyword("C#"),
                    JAVA = new Keyword("JAVA"),
                    CPlusPlus = new Keyword("C++");
            List<Problem> problems = new List<Problem>
            {

                new Problem("内容1",yh1)
                {
                    Title = "标题1",
                    KeyWords = new List<Keyword>
                    {
                        CSharp,
                        CPlusPlus,
                        JAVA
                    }
                 },
                new Problem("内容2", yh1)
                {
                    Title ="标题2",
                    KeyWords=new List<Keyword>
                    {
                        CSharp
                    }
                },

                 new Problem("内容3", yh2)
                {
                    Title ="标题3",
                    KeyWords=new List<Keyword>
                    {
                        CSharp,
                        CPlusPlus

                    }
                }

            };

            foreach (var item in problems)
            {
                ContentService.Publish(item);
            }

            return problems;
        }
    }
}
