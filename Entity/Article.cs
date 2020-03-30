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

        //如果发布Article，需要消耗一个帮帮币
        public override void Publish()
        {
            //HelpCreit在User类中，只能是User类型加字段，来表示具有意义
            author.HelpCreit--;
            Console.WriteLine("这是篇文章");
        }
        public override int Praise(User voter)
        {
            author.HelpCreit++;
            voter.HelpCreit--;
            return author.HelpCreit;
        }
        public override int Tread(User voter)
        {
            author.HelpCreit--;
            voter.HelpCreit--;
            return author.HelpCreit;
        }
    }
}