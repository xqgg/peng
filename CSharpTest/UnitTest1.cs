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
    }
}