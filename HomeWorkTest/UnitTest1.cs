using NUnit.Framework;


namespace HomeWorkTest
{
    public class MimicStackObject
    {
        //暂时先弄双向链表
        [SetUp]
        public void Setup()
        {
            object[] container = new object[5];
        }

        [Test]
        public void Pushtest()
        {
            //一个都没有压入时，container为空
     
           
            Assert.Pass();
        }

        [Test]
        public void Poptest()
        { 
        }
    }
}