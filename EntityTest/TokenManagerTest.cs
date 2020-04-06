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
            //生成的对象tokentest不包含其他权限
            Assert.AreNotEqual(Token.SuperAdmin, Admin._tokens);
            Assert.AreNotEqual(Token.Blogger, Admin._tokens);
            Assert.AreNotEqual(Token.NewBie, Admin._tokens);
            Assert.AreNotEqual(Token.Registered, Admin._tokens);
            //生成的对象tokentest包含Admin
            Assert.AreEqual(Token.Admin, Admin._tokens);
        }

        [Test]
        public void Add_Test()
        {

            //tokentest添加一个权限后，是否生效
            Assert.AreEqual(Token.Admin | Token.SuperAdmin, Admin.Add(Token.SuperAdmin));

            Assert.AreEqual(Token.Admin | Token.Blogger, Admin.Add(Token.Blogger));

            Assert.AreEqual(Token.Admin | Token.NewBie, Admin.Add(Token.NewBie));

            Assert.AreEqual(Token.Admin | Token.Registered, Admin.Add(Token.Registered));
        }
        public void Remove_Test()
        {
         

            //判断tokentest是否具有其他权限
            Assert.IsFalse(Admin.Has(Token.Admin));
            Assert.IsFalse(Admin.Has(Token.Blogger));
            Assert.IsFalse(Admin.Has(Token.NewBie));
            Assert.IsFalse(Admin.Has(Token.Registered));

            //判断tokentest含有SuperAdmin权限
            Assert.IsTrue(Admin.Has(Token.SuperAdmin));

          
        }
    }
}