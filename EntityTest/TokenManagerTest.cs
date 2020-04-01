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

            //���ɵĶ���tokentest����������Ȩ��
            Assert.AreNotEqual(Token.SuperAdmin, tokentest._tokens);
            Assert.AreNotEqual(Token.Blogger, tokentest._tokens);
            Assert.AreNotEqual(Token.NewBie, tokentest._tokens);
            Assert.AreNotEqual(Token.Registered, tokentest._tokens);

            //���ɵĶ���tokentest����Admin
            Assert.AreEqual(Token.Admin, tokentest._tokens);

            //tokentest���һ��Ȩ�޺��Ƿ���Ч
            Assert.AreEqual(Token.Admin | Token.SuperAdmin, tokentest.Add(Token.SuperAdmin));

            Assert.AreEqual(Token.Admin | Token.SuperAdmin | Token.Blogger, tokentest.Add(Token.Blogger));

            Assert.AreEqual(Token.Admin | Token.SuperAdmin | Token.Blogger | Token.NewBie, tokentest.Add(Token.NewBie));

            Assert.AreEqual(Token.Admin | Token.SuperAdmin | Token.Blogger | Token.NewBie | Token.Registered, tokentest.Add(Token.Registered));

            //tokentest�Ƴ�һ��Ȩ�޺��Ƿ���Ч
            Assert.AreEqual(Token.Admin | Token.SuperAdmin | Token.Blogger | Token.NewBie, tokentest.Remove(Token.Registered));

            Assert.AreEqual(Token.Admin | Token.SuperAdmin | Token.Blogger, tokentest.Remove(Token.NewBie));

            Assert.AreEqual(Token.Admin | Token.SuperAdmin, tokentest.Remove(Token.Blogger));

            Assert.AreEqual(Token.SuperAdmin, tokentest.Remove(Token.Admin));

            //�ж�tokentest�Ƿ��������Ȩ��
            Assert.IsFalse(tokentest.Has(Token.Admin));
            Assert.IsFalse(tokentest.Has(Token.Blogger));
            Assert.IsFalse(tokentest.Has(Token.NewBie));
            Assert.IsFalse(tokentest.Has(Token.Registered));

            //�ж�tokentest����SuperAdminȨ��
            Assert.IsTrue(tokentest.Has(Token.SuperAdmin));

          
        }
    }
}