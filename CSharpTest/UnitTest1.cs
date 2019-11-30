using NUnit.Framework;
using CSharp;
namespace CSharpTest
{
    public class DoubleLinkedTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InsertAfter()
        {
            DoubleLinked old = new DoubleLinked();
            DoubleLinked current_1 = new DoubleLinked();
            current_1.InsertAfter(old);
            Assert.AreEqual(current_1.Previous, old);
            Assert.AreEqual(old.Next, current_1);
            DoubleLinked current_2 = new DoubleLinked();
            current_2.InsertAfter(old);

            Assert.AreEqual(old.Next, current_2);
            Assert.AreEqual(current_2.Next, current_1);

            Assert.AreEqual(current_2.Previous, old);
            Assert.AreEqual(current_1.Previous, current_2);
        }

        [Test]
        public void InsertBefor()
        {
            DoubleLinked old = new DoubleLinked();
            DoubleLinked current_1 = new DoubleLinked();
            current_1.InsertBefor(old);
            Assert.AreEqual(old.Previous, current_1);
            Assert.AreEqual(current_1.Next, old);
            DoubleLinked current_2 = new DoubleLinked();
            current_2.InsertBefor(old);
            Assert.AreEqual(old.Previous, current_2);
            Assert.AreEqual(current_2.Previous, current_1);
            Assert.AreEqual(current_1.Next, current_2);
            Assert.AreEqual(current_2.Next, old);
        }
        //static DoubleLinked Creat(DoubleLinked attrLink_1, DoubleLinked attrLink_2)
        //{
        //    DoubleLinked target = new DoubleLinked();
        //    target.InsertAfter(attrLink_1);
        //    attrLink_1.InsertAfter(attrLink_2);
        //    return target;
        //}
        [Test]
        public void Delet()
        {
            DoubleLinked link_1 = new DoubleLinked();
            DoubleLinked link_2 = new DoubleLinked();
            DoubleLinked target = new DoubleLinked();
            //target在中间
            target.InsertAfter(link_1);
            link_1.InsertAfter(link_2);
            target.Delet();
            Assert.AreEqual(link_2.Next, link_1);
            Assert.AreEqual(link_1.Previous, link_2);
            //target在末尾
            target.InsertAfter(link_1);
            target.Delet();
            Assert.AreEqual(target.Previous, null);
            Assert.AreEqual(link_1.Next, null);
            //target在表头
            target.InsertBefor(link_2);
            target.Delet();
            Assert.AreEqual(link_2.Previous, null);
            Assert.AreEqual(target.Next, null);
        }
        [Test]
        public void Swap()
        {
            //链表中只有两个节点并且分别为头/尾
            DoubleLinked link_1 = new DoubleLinked();
            DoubleLinked link_2 = new DoubleLinked();
            link_1.InsertAfter(link_2);
            //21排列

            link_1.Swap(link_2);
            //12排列

            Assert.AreEqual(link_1.Next, link_2);
            Assert.AreEqual(link_2.Previous, link_1);
            Assert.AreEqual(link_1.Previous, null);
            Assert.AreEqual(link_2.Next, null);




            //链表中有两个以上的节点，交换的节点分别为头 / 尾
            DoubleLinked link_3 = new DoubleLinked();
            link_3.InsertBefor(link_2);
            //132排列

            link_1.Swap(link_2);
            //231排列

            Assert.AreEqual(link_2.Next, link_3);
            Assert.AreEqual(link_3.Next, link_1);
            Assert.AreEqual(link_1.Next, null);
            Assert.AreEqual(link_1.Previous, link_3);
            Assert.AreEqual(link_3.Previous, link_2);
            Assert.AreEqual(link_2.Previous, null);

            link_1.Swap(link_2);
            //132排列
            Assert.AreEqual(link_1.Next, link_3);
            Assert.AreEqual(link_3.Next, link_2);
            Assert.AreEqual(link_2.Next, null);
            Assert.AreEqual(link_2.Previous, link_3);
            Assert.AreEqual(link_3.Previous, link_1);
            Assert.AreEqual(link_1.Previous, null);

            DoubleLinked link_4 = new DoubleLinked();
            link_4.InsertAfter(link_2);
            //1324排列

            link_1.Swap(link_2);
            //2314排列
            Assert.AreEqual(link_1.Next, link_4);
            Assert.AreEqual(link_4.Previous, link_1);

            Assert.AreEqual(link_1.Previous, link_3);
            Assert.AreEqual(link_3.Next, link_1);

            Assert.AreEqual(link_2.Previous, null);

            Assert.AreEqual(link_2.Next, link_3);
            Assert.AreEqual(link_3.Previous, link_2);


            link_3.Swap(link_1);
            //2134排列


            Assert.AreEqual(link_3.Next, link_4);
            Assert.AreEqual(link_4.Previous, link_3);

            Assert.AreEqual(link_3.Previous, link_1);
            Assert.AreEqual(link_1.Next, link_3);

            Assert.AreEqual(link_1.Previous, link_2);
            Assert.AreEqual(link_2.Next, link_1);








        }
    }
}