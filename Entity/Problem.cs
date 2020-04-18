using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 求助板块
    /// </summary>
    public class Problem:Content
    {
        
        //每一个Problem对象一定有Body赋值
        //每实例化一个对象是，都会执行构造函数
        //只要Body赋值行为在构造函数里，就可以实现无论是哪个实例或者说实例名，都有这一种行为
        //一句话总结是 把实例化写在构造函数里
        //public Problem(string body):base("Problem")
        //{
        //    this.Body = body;
        //}

        
        private int _reward;
        //problem.Reward不能为负数
        public int Reward
        {
            get { return _reward; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Reward不能为负数");
                    return;
                }
                _reward = value;
            }

        }

        public string Title { get; set; }

        //一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
        //设置一个字段来保存数据
        //private string[] _keyword = { "刀", "剑", "弓", "枪", "炮", "拳", "标" };
        //public string this[int index]
        ////这里是this关键字和[]运算符，跟数组有点像
        //{
        //    get { return _keyword[index]; }
        //    set { _keyword[index] = value; }
        //}
        //这里跟字段的设置与输出一样
        //public Problem(int consume)
        //{
        //    this.Consume = consume;
        //}


        //private int Consume;

        //如果发布Problem，需要消耗其设置悬赏数量的帮帮币
        //也就是说在发布一个求助时，先设置消耗的金币，那这个需要引入一个参数，Consume 消耗、消费
        public override void Publish()
        {
            Author.HelpCreit = Author.HelpCreit - Reward;
            Console.WriteLine("这是一个求助");
        }
      
        /// <summary>
        /// Load 我觉得也要用static，这只是针对大集合的取值
        /// 在数据库中已经抽象成了ID，就不需要用实例了吧，
        /// </summary>
        /// <param name="Id">某篇求助的地址</param>
        /// <returns>一条求助</returns>
        public static string[] Load(int Id)
        {
            string[] all = { "title", "keyword", "body" };
            return all;
        }
        /// <summary>
        /// Delete 根据Id删除某个求助
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static string[] Delete(int Id)
        {
            string[] all = { "title", "keyword", "body" };
            return all;
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
