using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal abstract class Content
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
        public DateTime PublishDateTime { get; set; }
        public void Publish()
        { 
        }
        public Content(string kind)
        {
            if (kind == string.Empty)
            {
                Console.WriteLine("内容的种类不能为空，请重试");
                return;
            }
            else
            {
                this.kind = kind;
            }
        }
        protected string kind;
        private DateTime _createTime;
        //private DateTime _PublishTime;
        public DateTime PublishTime
        {
            get { return _createTime; }
        }
    }
}
