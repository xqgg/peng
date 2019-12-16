using NUnit.Framework;
using CSharp;
namespace CSharpTest
{
    public class TokenManagerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add()
        {
            User pzq = new User("","");
            pzq._tokens = new TokenManager();
            pzq._tokens.Add(Token.Admin);
            Assert.AreEqual((int)pzq._tokens._tokens, 2);
            Assert.AreEqual("Admin", pzq._tokens._tokens.ToString());
            pzq._tokens.Add(Token.Blogger);
            Assert.AreEqual((int)pzq._tokens._tokens, 6);
            Assert.AreEqual("Admin, Blogger", pzq._tokens._tokens.ToString());
            //每级权限名中间用逗号“,（半角）”加一个空格隔开


        }

        [Test]
        public void Has()
        {

            User pzq = new User("","");
            pzq._tokens = new TokenManager();
            pzq._tokens.Add(Token.Admin);
            Assert.IsTrue(pzq._tokens.Has(Token.Admin));
            pzq._tokens.Add(Token.Blogger);
            Assert.IsTrue(pzq._tokens.Has(Token.Blogger));
            
        }

        [Test]
        public void Remove()
        {
            User pzq = new User("","");
            pzq._tokens = new TokenManager();
            pzq._tokens.Add(Token.Admin);
            Assert.IsTrue(pzq._tokens.Has(Token.Admin));
            pzq._tokens.Remove(Token.Admin);
            Assert.IsFalse(pzq._tokens.Has(Token.Admin));
        }

        //关于异常相关的测试暂缓

    }
}