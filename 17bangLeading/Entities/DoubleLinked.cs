using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPage.Entities
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
            else if (this.IsTail)
            {
                this.Previous.Next = null;
                this.Previous = null;
            }
            else
            {
                this.Next.Previous = null;
                this.Next = null;
            }



        }
        /// <summary>
        /// 将当前节点和swapped节点交换
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Swap(DoubleLinked swapped)
        {
            if (this == swapped)
            {
                throw new Exception("无法用节点自己与自己调换");
            }

            if (this.IsHead && this.Next == swapped)
            {
                this.Previous = swapped;
                this.Next = null;
                swapped.Next = this;
                swapped.Previous = null;
                return;
            }

            if (this.IsTail && this.Previous == swapped)
            {
                this.Next = swapped;
                this.Previous = null;
                swapped.Previous = this;
                swapped.Next = null;
                return;
            }

            DoubleLinked thisP = this.Previous;
            DoubleLinked thisN = this.Next;
            DoubleLinked swappedP = swapped.Previous;
            DoubleLinked swappedN = swapped.Next;

            this.Delet();
            this.InsertAfter(swapped);
            swapped.Delet();

            if (thisP == null)
            {
                swapped.InsertBefor(thisN);
            }
            else if (this.Next == swapped)
            {
                swapped.InsertBefor(this);
            }
            else
            {
                swapped.InsertAfter(thisP);
            }




















         

            //if (this.IsHead && swapped.IsTail)
            //{
            //    DoubleLinked thisN = this.Next;
            //    DoubleLinked swappedP = swapped.Previous;
            //    this.Previous = swappedP;
            //    swappedP.Next = this;
            //    this.Next = null;

            //    swapped.Next = thisN;
            //    thisN.Previous = swapped;
            //    swapped.Previous = null;
            //    return;
            //}


            //if (this.IsTail && swapped.IsHead)
            //{
            //    DoubleLinked thisNP = this.Previous;
            //    DoubleLinked swappedN = swapped.Next;
            //    this.Next = swappedN;
            //    swappedN.Previous = this;
            //    this.Previous = null;

            //    swapped.Previous = thisNP;
            //    thisNP.Next = swapped;
            //    swapped.Next = null;
            //    return;
            //}

            //if (!this.IsHead && !this.IsTail && !swapped.IsTail && !swapped.IsHead)
            //{
            //    DoubleLinked thisP = this.Previous;
            //    DoubleLinked thisN = this.Next;
            //    DoubleLinked swappedP = swapped.Previous;
            //    DoubleLinked swappedN = swapped.Next;

            //    this.Next = swappedN;
            //    this.Previous = swappedP;
            //    swappedN.Previous = this;
            //    swappedP.Next = this;

            //    swapped.Next = thisN;
            //    swapped.Previous = thisP;
            //    thisN.Previous = swapped;
            //    thisP.Next = swapped;
            //}






        }
    }
}
