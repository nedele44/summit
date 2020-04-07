using NUnit.Framework;
using Entity;

namespace EntityTest
{
    public class TokenManager_Test
    {

        TokenManager Admin;
        [SetUp]
        public void Setup()
        {
            Admin = new TokenManager(Token.Admin);
        }

        [Test]
        public void Setup_Test()
        {
            //���ɵĶ���tokentest����������Ȩ��
            Assert.AreNotEqual(Token.SuperAdmin, Admin._tokens);
            Assert.AreNotEqual(Token.Blogger, Admin._tokens);
            Assert.AreNotEqual(Token.NewBie, Admin._tokens);
            Assert.AreNotEqual(Token.Registered, Admin._tokens);
            //���ɵĶ���tokentest����Admin
            Assert.AreEqual(Token.Admin, Admin._tokens);
        }

        [Test]
        public void Add_Test()
        {

            //tokentest���һ��Ȩ�޺��Ƿ���Ч
            Assert.AreEqual(Token.Admin | Token.SuperAdmin, Admin.Add(Token.SuperAdmin));

            Assert.AreEqual(Token.Admin | Token.SuperAdmin | Token.Blogger, Admin.Add(Token.Blogger));

            Assert.AreEqual(Token.Admin | Token.SuperAdmin | Token.Blogger | Token.NewBie, Admin.Add(Token.NewBie));

            Assert.AreEqual(Token.Admin | Token.SuperAdmin | Token.Blogger | Token.NewBie | Token.Registered, Admin.Add(Token.Registered));
        }

        [Test]
        public void Ishas_Test()
        {
            //�ж�tokentest�Ƿ��������Ȩ��
            Assert.IsFalse(Admin.Has(Token.SuperAdmin));
            Assert.IsFalse(Admin.Has(Token.Blogger));
            Assert.IsFalse(Admin.Has(Token.NewBie));
            Assert.IsFalse(Admin.Has(Token.Registered));

            //�ж�tokentest����SuperAdminȨ��
            Assert.IsTrue(Admin.Has(Token.Admin));
        }

        [Test]
        public void Remove_Test()
        {
           
            //�Ƴ��Լ������е�Ȩ�ޣ�����ԭ��
            Assert.AreEqual(Token.Admin, Admin.Remove(Token.SuperAdmin));

            Assert.AreEqual(Token.Admin, Admin.Remove(Token.Blogger));

            Assert.AreEqual(Token.Admin, Admin.Remove(Token.NewBie));

            Assert.AreEqual(Token.Admin , Admin.Remove(Token.Registered));

            //�Ƴ��Լ������е�Ȩ�ޣ���ȥ���Ƴ�����
            Assert.AreEqual((Token)0,Admin.Remove(Token.Admin));
        }
    }
}