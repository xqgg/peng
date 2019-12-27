using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class KeyWord
    {
        //一个关键字可以对应多篇文章
        public List<Article> Articles { set; get; }
        public string Name { get; set; }
        public KeyWord(string name)
        {
            Name = name;
        }
    }
}
