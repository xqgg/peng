using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    enum kind
    {
        Problem = 1,
        Article = 2,
        Suggest = 3
    }
    internal abstract class Content : Entity
    {
        public kind GetKind()
        {
            return kind;
        }
        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
        public virtual void Publish()
        {
            PublishTime = SystemTime.Now();
        }
        private DateTime _createTime;

        public Content()
        {
            _createTime = SystemTime.Now();
        }
        protected kind kind;

        public DateTime PublishTime { get; private set; }
        public DateTime CreatTime
        {
            get
            {
                return _createTime;
            }
        }

        static public void ContentDo()
        {
            User user = new User("", "");
            user.HelpMoney = 10;
            Article article = new Article(user);
            Console.WriteLine("创建时间：" + article.CreatTime);
            System.Threading.Thread.Sleep(3000);
            article.Publish();
            Console.WriteLine("发布时间：" + article.PublishTime);
            
            Problem problem = new Problem("", 1, user);
            Console.WriteLine(problem.CreatTime);
            System.Threading.Thread.Sleep(2000);
            
            Console.WriteLine(problem._createTime);
            problem.Publish();
            Console.WriteLine(problem.PublishTime);
        }

    }
}
