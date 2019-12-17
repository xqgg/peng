﻿using System;
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
        public kind GetKind()
        {
            return kind;
        }
        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
        public DateTime PublishDateTime { get; set; }
        public void Publish()
        {
            _createTime = DateTime.Now;
        }
        private  DateTime _createTime;

        public Content()
        {

        }
        protected kind kind;

        public DateTime PublishTime
        {
            get { return _createTime; }
        }


    }
}
