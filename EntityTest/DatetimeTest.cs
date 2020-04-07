using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace EntityTest
{
    public class DateTimeTest
    {               
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void GetDayTest()
        {
            Mytime test = new Mytime();
            //几天后 ，
            Assert.AreEqual(new DateTime(2020, 4, 6),test.GetDate(new DateTime(2020,4,1),5,Mytime.unit.day));
            //几十天后，跨月
            Assert.AreEqual(new DateTime(2020, 5, 1),test.GetDate(new DateTime(2020,4,1),30,Mytime.unit.day));
            //几百天后，跨年
            Assert.AreEqual(new DateTime(2021, 4, 1), test.GetDate(new DateTime(2020, 4, 1), 365, Mytime.unit.day));
            //1个星期后
            Assert.AreEqual(new DateTime(2020, 4, 8), test.GetDate(new DateTime(2020, 4, 1), 1, Mytime.unit.week));
            //几个星期后
            Assert.AreEqual(new DateTime(2020, 4, 22), test.GetDate(new DateTime(2020, 4, 1), 3, Mytime.unit.week));
            //几个月后
            Assert.AreEqual(new DateTime(2020,7, 1), test.GetDate(new DateTime(2020, 4, 1), 3, Mytime.unit.month));
            //十几个月后，跨年
            Assert.AreEqual(new DateTime(2021,3, 1), test.GetDate(new DateTime(2020, 4, 1), 11, Mytime.unit.month));

        }

        [Test]
        public void EveryWeekTest()
        {
            Mytime test = new Mytime();
            //找到每一年头一个星期一的日期数
            //2019年
            Assert.AreEqual(new DateTime(2019, 1, 7), new DateTime(2019, 1, test.FristMonday(2019)));
            Assert.AreEqual( 7, test.FristMonday(2019));
            
            //2020年
            Assert.AreEqual(new DateTime(2020, 1, 6), new DateTime(2020, 1, test.FristMonday(2020)));
        }
    }
}

    