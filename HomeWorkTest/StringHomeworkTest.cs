using homework;
using NUnit.Framework;

namespace HomeWorkTest
{
    public class StringTest
    //��Stringhomework��������������Ԫ����
    {
        //���������ѣ�Ҳûɶ��ϵ��ò�Ʋ�������setup��ֱ��Test
        [Test]
        public void GetCountTest()
        {
            StringHomework test = new StringHomework();

            Assert.AreEqual(1, test.GetCount("abc", "a"));
            Assert.AreEqual(2, test.GetCount("abcabc", "a"));
            Assert.AreEqual(3, test.GetCount("abcabcabc", "a"));
            Assert.AreEqual(3, test.GetCount("abcabcabc", "b"));
            Assert.AreEqual(3, test.GetCount("abcabcabc", "c"));
            Assert.AreEqual(0, test.GetCount("abcabcabc", "d"));
        }

        [Test]
        public void MimicJoinTest()
        {
            StringHomework test = new StringHomework();
            Assert.AreEqual("��-��-С-��",test.MimicJoin("-","��","��","С","��"));
        }




    }
}