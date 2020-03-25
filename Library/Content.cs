using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Content
    {

        public string kind;
        //Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
        //确保每个Content对象都有kind的非空值,也就是说参数kind有个默认值
        public Content(string kind = "content")
        {
            this.kind = kind;
        }
        //Content中的createTime，不能被子类使用,就是使用private或internal
        //这里输出的应该是datatime类型，但是里面的输出体，不会写，暂时使用void
        private void CreatTime()
        {

        }
        //只读属性PublishTime使用它为外部提供内容的发布时间
        public DateTime PublishTime { get; }




        //内容的子类有求助，文章和意见建议，据我观察，起共同点很多，比如
        //都含有标题，主题内容，和作者
        //都有显示点踩，点赞的数量，和评论框以及评论数的显示
        public string Title { get; set; }
        public string Body { get; set; }
        /// <summary>
        /// 这里属性的定义为User，也是自己自定义的一个类
        /// </summary>
        public User Author { get; set; }


        /// <summary>
        /// 显示点赞的个数，每点一次赞，作者获得一个帮帮币，点赞的人少一个帮帮币
        /// </summary>
        /// <param name="voter">代表点赞人的参数</param>
        /// <returns>作者的棒棒都</returns>
        public int Praise(User voter)
        {
            //初始点赞应该是0，没点一个加1，多少帮帮币，说明点了多少赞
            Author.HelpCreit++;
            voter.HelpCreit--;
            return Author.HelpCreit;
        }


        //假设点踩与作者的棒棒币无关，则需要申明一个静态字段来存储点踩值
        public static int tread = 0;
        /// <summary>
        /// 显示点踩得个数，获得一个踩，作者的棒棒币没变化，但是点赞的人少一个棒棒币
        /// </summary>
        /// <param name="voter">点踩得人</param>
        /// <returns></returns>
        public int Tread(User voter)
        {
            tread++;
            voter.HelpCreit--;
            return tread;
        }


    }
}
