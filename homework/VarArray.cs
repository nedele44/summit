using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    public class VarArray
    {

        //这个数组包含，int，char，string，DateTime等等
        //{ 0, "1", "高手", new DateTime(1991, 1, 1) }

        //public static object[] getarray = new object[];
        public object[] Get(int length)
        {
            object[] getarray = new object[length];
            for (int i = 0; i < length; i++)
            {
                getarray[i] = Console.ReadLine();
            }
            return getarray;
        }
        
        public object[] setarray = { 0, "1", "高手", new DateTime(1991, 1, 1) ,(1,2,3,4,5,6),""};
       
    }
   
}

