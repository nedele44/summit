using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class ContentService
    {
        //添加一个新类ContentService，其中有一个发布（Publish()）方法
        public virtual void Publish(Content content)
        {
            content.Publish();
            Console.WriteLine("把"+"content"+"的内容存到数据库");
        }
      
    }
}
