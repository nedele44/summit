using System;
using System.Collections.Generic;
using System.Text;

namespace yiqibang
{
    /// <summary>
    /// 求助板块
    /// </summary>
    class Problem
    {
        private string Title;
        private string Body;
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

        private string PublishDateTime;
        //时间用啥访问修饰符，我觉得用private，可以多处使用名称，不显示重复
        private string Author;
        public void Publish()
        {
        }
    }
}
