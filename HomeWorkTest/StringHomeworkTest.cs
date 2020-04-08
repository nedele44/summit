using homework;
using NUnit.Framework;

namespace HomeWorkTest
{
    public class StringTest
    //给Stringhomework的两个方法做单元测试
    {
        //两个都不难，也没啥关系，貌似不用设置setup，直接Test
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
            Assert.AreEqual("我-是-小-菜",test.MimicJoin("-","我","是","小","菜"));
        }




    }
}