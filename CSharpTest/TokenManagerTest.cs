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
            User pzq = new User();
            pzq._tokens = new TokenManager();
            pzq._tokens.Add(Token.Admin);
            Assert.AreEqual((int)pzq._tokens._tokens, 2);
            pzq._tokens.Add(Token.Blogger);
            Assert.AreEqual((int)pzq._tokens._tokens, 6);
          
        }




    }
}