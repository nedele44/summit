using NUnit.Framework;


namespace HomeWorkTest
{
    public class MimicStackObject
    {
        //��ʱ��Ū˫������
        [SetUp]
        public void Setup()
        {
            object[] container = new object[5];
        }

        [Test]
        public void Pushtest()
        {
            //һ����û��ѹ��ʱ��containerΪ��
     
           
            Assert.Pass();
        }

        [Test]
        public void Poptest()
        { 
        }
    }
}