using NUnit.Framework;
using Entity;

namespace EntityTest
{
    public class Tests
    {

        TokenManager Admin, Admin_Superadmin;
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

            Assert.AreEqual(Token.Admin | Token.Blogger, Admin.Add(Token.Blogger));

            Assert.AreEqual(Token.Admin | Token.NewBie, Admin.Add(Token.NewBie));

            Assert.AreEqual(Token.Admin | Token.Registered, Admin.Add(Token.Registered));
        }
        public void Remove_Test()
        {
         

            //�ж�tokentest�Ƿ��������Ȩ��
            Assert.IsFalse(Admin.Has(Token.Admin));
            Assert.IsFalse(Admin.Has(Token.Blogger));
            Assert.IsFalse(Admin.Has(Token.NewBie));
            Assert.IsFalse(Admin.Has(Token.Registered));

            //�ж�tokentest����SuperAdminȨ��
            Assert.IsTrue(Admin.Has(Token.SuperAdmin));

          
        }
    }
}