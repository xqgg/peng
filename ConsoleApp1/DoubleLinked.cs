using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class DoubleLinked
    {
        public DoubleLinked Previous { get; private set; }
        public DoubleLinked Next { get; private set; }
        public int Value { get; set; }
        public bool IsHead
        {
            get
            {
                return Previous == null;
            }
        }
        public bool IsTail
        {
            get
            {
                return Next == null;
            }
        }

        public DoubleLinked FindBy(int value)
        {
            //从任何一个节点向上向下分别查找一次
            //如果没找到:
            return null;
        }
    }
}
