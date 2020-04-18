using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
   public class Keyword
    {
        //关键字必须带有其关键字字符串
        public Keyword()
        {
           
        }
        //关键字的名字
        public  string Name { get; set; }
        //一个关键字可以对应多篇文章
        public List<Article> Articles { get; set; }
    }
}
