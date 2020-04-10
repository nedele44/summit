using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Comment
    {
        //一个评论必须有一个它所评论的文章 
        private Article article;

        public Comment(Article article)
        {
            this.article = article;
        }
        //每个文章和评论都有一个评价 
        public Appraise appraise { get; set; }
    }
}
