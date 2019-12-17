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
    internal abstract class Content
    {

        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
        public DateTime PublishDateTime { get; set; }
        public void Publish()
        {
        }
        public Content(kind inputkind)
        {
            kind = inputkind;
        }
        protected kind kind;
        private DateTime _createTime;
        //private DateTime _PublishTime;
        public DateTime PublishTime
        {
            get { return _createTime; }
        }

    }
}
