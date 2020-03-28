using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public struct Mytime
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




    }



}
