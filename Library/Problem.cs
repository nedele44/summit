using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 求助板块
    /// </summary>
    public class Problem
    {
        //每一个Problem对象一定有Body赋值
        //每实例化一个对象是，都会执行构造函数
        //只要Body赋值行为在构造函数里，就可以实现无论是哪个实例或者说实例名，都有这一种行为
        //一句话总结是 把实例化写在构造函数里
        public Problem(string body)
        {
            this.Body = body;
        }

        private string Title { get; set; }
        public string Body;
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

        //一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
        //设置一个字段来保存数据
        private string[] _keyword = { "刀", "剑", "弓", "枪", "炮", "拳", "标" };
        public string this[int index]
        //这里是this关键字和[]运算符，跟数组有点像
        {
            get { return _keyword[index]; }
            set { _keyword[index] = value; }
        }
        //这里跟字段的设置与输出一样



        private string PublishDateTime;
        //时间用啥访问修饰符，我觉得用private，可以多处使用名称，不显示重复
        private string Author;
        /// <summary>
        /// Publish 我觉得可以是静态方法，每个求助类的实例都需要将其内容保存到数据库
        /// 这里是不是可以说，涉及到存储操作，也就是针对集合（数组，元组，堆栈）的增删改，尽量用静态方法
        /// 毕竟这是对所有已经实例化的大集合的操作，整体性的操作，不是单个实例的操作
        /// </summary>
        public static void Publish()
        {
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
        
        
        
    }
}
