using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Article : Content
    {

        public Article() : base("article")
        {
            top = 0;
        }
        //Article相对于意见建议和求助，不同点在于，Article有关键字,最多只能有5个关键字
        //采用mimi栈的push的方法，将string关键字压入字符串中
        private static int top;
        public string[] Keyword=new string[5];
        
        public void Push(string value, out bool full)
        {
            
            full = top >= 5;
            if (full)
            {
                Console.WriteLine("关键字最多为5个");
            }
            else
            {
                Keyword[top] = value;
                top++;
            }
              
        }


    }
}