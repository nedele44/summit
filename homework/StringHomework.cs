using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    public class StringHomework
    {
        //实现GetCount(string container, string target)方法，可以统计出container中有多少个target
        public int GetCount(string container, string target)
        {
      bool Ishas = container.Contains(target);
            if (!Ishas)
            {
                return 0;
            }
            else
            {
                string recontainer=container.Replace(target, string.Empty);
                return (container.Length - recontainer.Length) / target.Length;//想到了用replace和empty，但没有想到用length
            }
               
        }
        //不使用string自带的Join()方法，定义一个mimicJoin()方法，能将若干字符串用指定的分隔符连接起来，比如：mimicJoin("-","a","b","c","d")，其运行结果为：a-b-c-d

        public string UnitJoin(string Separate,string a,string b) 
        {
            return a+Separate + b;
            //return a + Separate + b + Separate + c + Separate + d;
            //如果给定的个数不确定呢
            //如果只有两个呢，或者三个呢
           
        }
        public string MimicJoin(string Separate, string a, string b,string c,string d)
        {
            string str1 = UnitJoin(Separate, a, b);
            string str2 = UnitJoin(Separate, str1, c);
            string str3 = UnitJoin(Separate, str2, d);
            return str3;
            //怎么用循环来解决，个数不定的问题

        }
    }
}
