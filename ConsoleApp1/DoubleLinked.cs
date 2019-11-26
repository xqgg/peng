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
        /// <summary>
        /// 在node之后插入当前节点
        /// </summary>
        /// <param name="node"></param>
        public void InsertAfter(DoubleLinked node)
        {

        }
        /// <summary>
        /// 在node之前插入当前节点
        /// </summary>
        /// <param name="node"></param>
        public void InsertBfor(DoubleLinked node)
        {
        }
        /// <summary>
        /// 删除当前节点
        /// </summary>
        /// <param name="node"></param>
        public void Delet(DoubleLinked node)
        {
        }
    }
}
