using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Comment
    {
        //一个评论必须有一个它所评论的文章 和 评论语 以及用户
        public Article Article { get; set; }

       
        //假定评论一旦生成,内容和作者是不能改的
        public string Content { get; set; }
        public User CommentBy { get; set; }
        //每个文章和评论都有一个评价 
        public Appraise appraise { get; set; }
    }
}
