using Entity;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityTest
{
    class MailmessagesTest
    {
        Mailname mails = new Mailname(@"F:\summit\homework\Emails.txt");
        string emailsString, email1, email2, email3, email4, email5, email6, email7;
        [SetUp]
        public void Setup()
        {
            emailsString = mails.GetMessages();
            email1 = "ASP@163.com";
            email2 = "asp@163.com";
            email3 = "A S P @ 163.com";
            email4 = "a@986.com";
            email5 = "b@986.com";
            email6 = "c@986.com";
            email7 = "d@986.com";
        }

        [Test]
        public void Setuptest()
        {
            Assert.IsNotNull(emailsString);
            Assert.AreEqual(emailsString, email1 + ";" + email2 + ";" + email3 + ";" + email4
                + ";" + email5 + ";" + email6 + ";" + email7);
        }

        //目前发现了三个需求模糊
        //大小不同，字母相同，算不算相同，这里姑且认定为相同
        //email的名称内容相同，但是有的有空格，算不算相同，这里姑且认定为相同
        //分离出来的字符串即单个email，要不要带上分号“；”，这里姑且认定为不带
        [Test]
        public void SplitMessagesTest()
        {
            string[] splitString = mails.SplitMessages();
            Assert.AreEqual(7, splitString.Length);
            Assert.AreEqual(email1.ToLower(), splitString[0]);
            Assert.AreEqual(email2.ToLower(), splitString[1]);

            Assert.AreNotEqual(email3.ToLower(), splitString[2]);
            Assert.AreNotEqual(email3.ToLower().Length, splitString[2].Length);

            Assert.AreEqual(11, splitString[2].Length);

            Assert.AreEqual(email4.ToLower(), splitString[3]);
            Assert.AreEqual(email5.ToLower(), splitString[4]);
            Assert.AreEqual(email6.ToLower(), splitString[5]);
            Assert.AreEqual(email7.ToLower(), splitString[6]);
        }

        [Test]
        public void DedupleMessagesTest()
        {
            string[] DedupleString = mails.DedupleMessages();
            Assert.AreEqual(5, DedupleString.Length);
            Assert.AreEqual(email1.ToLower(), DedupleString[0]);
            Assert.AreEqual(email4.ToLower(), DedupleString[1]);
            Assert.AreEqual(email5.ToLower(), DedupleString[2]);
            Assert.AreEqual(email6.ToLower(), DedupleString[3]);
            Assert.AreEqual(email7.ToLower(), DedupleString[4]);
        }

        [Test]
        public void RebulidMessagesTest1()
        {
            mails.LineNumber = 1;
            string rebulidString = mails.RebulidMessages();
            List<Char> rebulidChar = new List<char>(rebulidString);
            int lineNumber = rebulidChar.Where(s => s == '\n').Count();
            Assert.AreEqual(5, lineNumber);
        }

        [Test]
        public void RebulidMessagesTest2()
        {
            mails.LineNumber = 2;
            string rebulidString = mails.RebulidMessages();
            List<Char> rebulidChar = new List<char>(rebulidString);
            int lineNumber = rebulidChar.Where(s => s == '\n').Count();
            Assert.AreEqual(2, lineNumber);
        }

        [Test]
        public void RebulidMessagesTest3()
        {
            mails.LineNumber = 3;
            string rebulidString = mails.RebulidMessages();
            List<Char> rebulidChar = new List<char>(rebulidString);
            int lineNumber = rebulidChar.Where(s => s == '\n').Count();
            Assert.AreEqual(1, lineNumber);
        }
    }
}
