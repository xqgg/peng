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
    }
}