using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yiqibang.Entity;
using yiqibang.Model;

namespace yiqibang.Repository
{
    public class MessageRepository
    {
        private static IList<MessageModel> _messages;
        static MessageRepository()
        {
            _messages = new List<MessageModel>
            {
                 new MessageModel
                 {
                     Id=1,
                     BulidTime=DateTime.Now,
                     Kind=KindOfBook.picked,
                     //消息的内容很特殊，自带a标签，那应该在前端实现
                     //能收入仓库吗，那怎么添加标签呢
                     Content="文章的评论灵魂程序员被标识为精选，" +
                     "获得帮帮点 奖励10点 "
                 },
                 new MessageModel
                 {
                     Id=2,
                     BulidTime=DateTime.Now,
                     Kind=KindOfBook.liked,
                     Content="文章的评论灵魂程序员被标识为精选，" +
                     "获得帮帮点 奖励10点 "
                 },
                 new MessageModel
                 {
                     Id=3,
                     BulidTime=DateTime.Now,
                     Kind=KindOfBook.invited,
                     Content="文章的评论灵魂程序员被标识为精选，" +
                     "获得帮帮点 奖励10点 "
                 },
            };
        }



        public MessageModel Get(int id)
        {
            return _messages.Where(m => m.Id == id).Single();
        }
        public MessageRepository Delete(int id)
        {
            var remain = from s in _messages
                         where s.Id != id
                         select s;
            
        }
    }
}
