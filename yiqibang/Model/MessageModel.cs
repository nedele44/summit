using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yiqibang.Entity;

namespace yiqibang.Model
{
    public class MessageModel
    {
        
        public int Id { get; set; }
        //消息的生成时间
        public DateTime BulidTime { get; set; }
        //订阅种类
        public KindOfBook Kind { get; set; }
        //消息内容
        public string Content { get; set; }

        public bool IsRead { get; set; }

        public bool Selected { get; set; }
    }
}
