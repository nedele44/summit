using NUnit.Framework;
using Entity;

namespace EntityTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAdd()
        {
            TokenManager tokentest = new TokenManager(Token.Admin);

            //生成的对象tokentest不包含其他权限
            Assert.AreNotEqual(Token.SuperAdmin, tokentest._tokens);
            Assert.AreNotEqual(Token.Blogger, tokentest._tokens);
            Assert.AreNotEqual(Token.NewBie, tokentest._tokens);
            Assert.AreNotEqual(Token.Registered, tokentest._tokens);

            //生成的对象tokentest包含Admin
            Assert.AreEqual(Token.Admin, tokentest._tokens);

            //tokentest添加一个权限后，是否生效
            Assert.AreEqual(Token.Admin | Token.SuperAdmin, tokentest.Add(Token.SuperAdmin));

            Assert.AreEqual(Token.Admin | Token.SuperAdmin | Token.Blogger, tokentest.Add(Token.Blogger));

            Assert.AreEqual(Token.Admin | Token.SuperAdmin | Token.Blogger | Token.NewBie, tokentest.Add(Token.NewBie));

            Assert.AreEqual(Token.Admin | Token.SuperAdmin | Token.Blogger | Token.NewBie | Token.Registered, tokentest.Add(Token.Registered));

            //tokentest移除一个权限后，是否生效
            Assert.AreEqual(Token.Admin | Token.SuperAdmin | Token.Blogger | Token.NewBie, tokentest.Remove(Token.Registered));

            Assert.AreEqual(Token.Admin | Token.SuperAdmin | Token.Blogger, tokentest.Remove(Token.NewBie));

            Assert.AreEqual(Token.Admin | Token.SuperAdmin, tokentest.Remove(Token.Blogger));

            Assert.AreEqual(Token.SuperAdmin, tokentest.Remove(Token.Admin));

            //判断tokentest是否具有其他权限
            Assert.IsFalse(tokentest.Has(Token.Admin));
            Assert.IsFalse(tokentest.Has(Token.Blogger));
            Assert.IsFalse(tokentest.Has(Token.NewBie));
            Assert.IsFalse(tokentest.Has(Token.Registered));

            //判断tokentest含有SuperAdmin权限
            Assert.IsTrue(tokentest.Has(Token.SuperAdmin));

          
        }
    }
}