using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Mytime
    {

        //函数GetDate()，能计算一个日期若干（日/周/月）后的日期
        //那他应该含至少有两个参数，指定一个日期，指定间隔时间
        public DateTime GetDate(DateTime date, int span, string unit)
        {

            DateTime newday;//计算所得日期
            if (span >= 0)
            {
                if (unit == "day") //若干天后
                {
                    newday = date.AddDays(span);
                    return newday;
                }
                else if (unit == "week")//若干星期后
                {

                    newday = date.AddDays(7 * span);
                    return newday;

                }
                else if (unit == "month")//若干月后
                {
                    newday = date.AddMonths(span);
                    return newday;
                    // int year = date.Year;
                    // int month = date.Month;
                    // int day = date.Day;
                    // month = month + span;
                    //int yearAdd = month / 12;
                    // month = month % 12;
                    // year = year + yearAdd;
                    // newday = DateTime.Parse("year-month-day");
                }
            }
            Console.WriteLine("请重新输入");
            DateTime badday = new DateTime(1, 1, 1);
            return badday;
        }


        //给定任意一个年份，就能按周排列显示每周的起始日期
        public  string dt;//这个用来记录一年第一天是星期几
        public int week;//这个可以不用设置，但是方便理解
        public  int firstMonday;//这个用来确定一年中第一个星期一是一月几号
        public void EveryWeek(int year)
        {
            DateTime fristofYear = new DateTime(year, 1, 1);
            string dt = fristofYear.DayOfWeek.ToString();

            switch (dt)
            {
                case "Monday":
                    week= 1;
                    firstMonday = 1;
                    break;
                case "Tuesday":
                    week = 2;
                    firstMonday = 7;
                    break;
                case "Wednesday":
                    week =3;
                    firstMonday = 6;
                    break;
                case "Thursday":
                    week =4;
                    firstMonday = 5;
                    break;
                case "Friday":
                    week = 5;
                    firstMonday = 4;
                    break;
                case "Saturday":
                    week = 6;
                    firstMonday =3;
                    break;
                case "Sunday":
                    week = 7;
                    firstMonday = 2;
                    break;
            }
            DateTime firstMondayDay = new DateTime(year, 1, firstMonday);//生成某年星期一的日期
           
            for (int i = 1; i < 365/7+1; i++)//i的范围可以稍微设置大一点
            {
                
               
                DateTime firstSundayDay = firstMondayDay.AddDays(6);//生产某年第一个星期天的日期
                if (firstMondayDay.Year == year + 1 || firstSundayDay.Year == year + 1) //当日期的年发生改变时跳出循环
                {
                    break;
                }
                Console.WriteLine("第"+i+"周：" + firstMondayDay.ToString("yyyy年MM月dd日")+ "-"+firstSundayDay.ToString("yyyy年MM月dd日")+ "\n");
                firstMondayDay = firstMondayDay.AddDays(7);//接下里每一个星期一的日期
            }
        }



    }



}
