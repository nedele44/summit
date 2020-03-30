using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Suggest : Content
    {
        public Suggest() : base("suggest")
        {

        }
        //基类有Id属性，子类也可以有Id属性
        private string Id { get; }

        //如果发布Suggest，不需要消耗帮帮币
        public override void Publish()
        {
            Console.WriteLine("这是一个意见建议");
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
