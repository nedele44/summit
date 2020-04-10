using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
   public class Keyword
    {
        //一个关键字可以对应多篇文章
        public List<Article> articles { get; set; }
    }
}
