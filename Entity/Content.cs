using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    //Content 应该选择为抽象类，而不是接口，在我创建的类里，除了有抽象方法，还有其他的实现
    public abstract class Content : ContentService
    {
        /// <summary>
        /// 无参构造函数，生成目前的时间
        /// </summary>
        public Content()
        {
            CreatTime = DateTime.Now;
        }

        public string kind;
        //Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
        //确保每个Content对象都有kind的非空值,也就是说参数kind有个默认值
        public Content(string kind = "content") : this()
        {
            this.kind = kind;
        }
        //Content中的createTime，不能被子类使用,就是使用private
        //这里输出的应该是datatime类型，赋值过程在构造函数中进行
        private DateTime CreatTime;


        //只读属性PublishTime使用它为外部提供内容的发布时间
        private DateTime PublishTime { get { return CreatTime; } }




        //内容的子类有求助，文章和意见建议，据我观察，其共同点很多，比如
        //都含有标题，主题内容，和作者
        //都有显示点踩，点赞的数量，和评论框以及评论数的显示
        private string title { get; set; }
        public string body { get; set; }
        /// <summary>
        /// 这里属性的定义为User，也是自己自定义的一个类
        /// </summary>
        public User author { get; set; }
        //这里要用public 在多处需要用到

            //在Content类中声明一个Publish的方法，供Article,Problem,和Suggest继承
        public virtual void Publish()
        {
        }




        /// <summary>
        /// 显示点赞的个数，每点一次赞，作者获得一个帮帮币，点赞的人少一个帮帮币
        /// </summary>
        /// <param name="voter">代表点赞人的参数</param>
        /// <returns>作者的帮帮币</returns>
        //public int Praise(User voter)
        //{
        //    //初始点赞应该是0，每点一个加1，那么有多少帮帮币，说明点了多少赞
        //    Author.HelpCreit++;
        //    voter.HelpCreit--;
        //    return Author.HelpCreit;
        //}

        //点赞和点踩的抽象
        public abstract int Praise(User voter);
        public abstract int Tread(User voter);



        //public static int tread = 0;
        /// <summary>
        /// 显示点踩得个数，获得一个踩，作者的棒棒币和点踩的人少一个棒棒币
        /// </summary>
        /// <param name="voter">点踩得人</param>
        /// <returns></returns>
        //public int Tread(User voter)
        //{
        //    Author.HelpCreit--;
        //    voter.HelpCreit--;
        //    return Author.HelpCreit;
        //}


    }
}
