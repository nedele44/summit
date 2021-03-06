﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Article : Content
    {

        //每个文章和评论都有一个评价 
        public Appraise Appraise { get; set; }
        //一篇文章可以有多个评论 
        public List<Comment> Comments { get; set; }
        //一篇文章可以有多个关键字，一个关键字可以对应多篇文章
        public List<Keyword> Keywords { get; set; }

        public Article() : base("article")
        {
          
           
        }
        //Article相对于意见建议和求助，不同点在于，Article有关键字,最多只能有5个关键字
        //采用mimi栈的push的方法，将string关键字压入字符串中
        
//public User Author { get; }
   

 
        

        //确保文章（Article）的标题不能为null值，也不能为一个或多个空字符组成的字符串，而且如果标题前后有空格，也予以删除
        //这个要申明一个属性Title
        //在属性设置中set项要把这些限制条件写进去
        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("输入的是空字符串");
                    return;
                }
                else
                {
                    //判断字符串之间是否含有空字符
                    bool has = false;
                    string valueTrim = value.Trim();//先把头尾两边的空格去掉
                    for (int i = 0; i < valueTrim.Length; i++)
                    {
                        if (valueTrim[i] == ' ')  //空字符串的符号
                        {
                            has = true;
                        }
                    }
                    //如果为null或含有空字符串
                    if (has)
                    {
                        Console.WriteLine("输入的字符串含有空字符");

                    }
                    else
                    {
                        title = valueTrim;
                    }
                }
            }
        }

        //public void Push(string value, out bool full)
        //{

        //    full = top >= 5;
        //    if (full)
        //    {
        //        Console.WriteLine("关键字最多为5个");
        //    }
        //    else
        //    {
        //        Keyword[top] = value;
        //        top++;
        //    }

        //}

        //如果发布Article，需要消耗一个帮帮币
        [HelpMoneyChange(50,Message ="有人打赏的")]
        public override void Publish()
        {
            //HelpCreit在User类中，只能是User类型加字段，来表示具有意义
           Author.HelpCreit--;
            Console.WriteLine("这是篇文章");
        }
        public override int Praise(User voter)
        {
           Author.HelpCreit++;
            voter.HelpCreit--;
            return Author.HelpCreit;
        }
        public override int Tread(User voter)
        {
            Author.HelpCreit--;
            voter.HelpCreit--;
            return Author.HelpCreit;
        }
    }
}