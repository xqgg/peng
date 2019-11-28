﻿using System;
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
            this.Previous = node;
            if (node.Next != null)
            {
                this.Next = node.Next;
                this.Next.Previous = this;
            }
            else
            {
                //nothing
            }
            node.Next = this;

        }
        /// <summary>
        /// 在node之前插入当前节点
        /// </summary>
        /// <param name="node"></param>
        public void InsertBefor(DoubleLinked node)
        {
            this.Next = node;
            if (node.Previous != null)
            {
                this.Previous = node.Previous;
                this.Previous.Next = this;
            }
            node.Previous = this;
        }



        /// <summary>
        /// 删除当前节点//如果链表中只有一个节点就抛异常
        /// </summary>
        /// <param name="node"></param>
        public void Delet()
        {
            if (this.IsHead && this.IsTail)
            {
                throw new Exception();
            }
            if (!this.IsHead && !this.IsTail)
            {
                this.Next.Previous = this.Previous;
                this.Previous.Next = this.Next;
                this.Next = null;
                this.Previous = null;
            }

        }
        /// <summary>
        /// 交换a,b节点
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Swap(DoubleLinked a, DoubleLinked b)
        {

        }

    }
}
