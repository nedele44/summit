using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Mytime
    {
        public enum unit
        {
            day = 1,
            week = 2,
            month = 3,
        }

        //函数GetDate()，能计算一个日期若干（日/周/月）后的日期
        //那他应该含至少有两个参数，指定一个日期，指定间隔时间
        public DateTime GetDate(DateTime date, int span, unit unit)
        {
            switch (unit)
            {
                case unit.day:
                    return date.AddDays(span);
                case unit.week:
                    return date.AddDays(7 * span);
                default:
                    return date.AddMonths(span);
            }
        }

        //给定任意一个年份，就能按周排列显示每周的起始日期

        //这个用来记录一年第一天是星期几
 
        //创建一个方法得到当年的第一个星期一的日子
        public int FristMonday(int year)
        {
            DayOfWeek dt =new DateTime(year,1,1).DayOfWeek;
            if (dt == DayOfWeek.Monday)
            {
                return 1;
            }
            else if (dt == DayOfWeek.Sunday)
            {
                return 2;
            }
            else
            {
                return 9 - (int)dt;
            }
        }

        public void EveryWeek(int year)
        {
            DateTime fristofYear = new DateTime(year, 1, 1);

            int monday = FristMonday(year);

            DateTime firstMondayDay = new DateTime(year, 1, monday);//生成某年星期一的日期
            DateTime firstSundayDay = firstMondayDay.AddDays(6);
            int i = 0;
            while (firstMondayDay.Year == year && firstSundayDay.Year == year)
            {
                i++;
                Console.WriteLine("第" + i + "周：" + firstMondayDay.ToString("yyyy年MM月dd日") + "-" + firstSundayDay.ToString("yyyy年MM月dd日") + "\n");
                firstMondayDay = firstMondayDay.AddDays(7);
                firstSundayDay = firstSundayDay.AddDays(7);
            }



        }
    }



}




