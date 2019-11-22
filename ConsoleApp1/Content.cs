using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal abstract class Content
    {
        protected string kind;
        public Content(string kind)
        {
            if (kind == "")
            {
                Console.WriteLine("内容的种类不能为空，请重试");
                return;
            }
            else
            {
                this.kind = kind;
            }
        }
    }
}
