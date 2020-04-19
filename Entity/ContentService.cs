using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Entity
{
    public class ContentService
    {
        //添加一个新类ContentService，其中有一个发布（Publish()）方法
        public void Publish(Content content)
        {
            try
            {
                content.Publish();
            }
            catch (InnerException)
            {
                //1.如果是“参数为空”异常，Console.WriteLine()输出：
                //内容的作者不能为空，将当前异常封装进新异常的InnerException，再将新异常抛出 
                Console.WriteLine("内容的作者不能为空");

            }
            //2.如果是“”参数越界”异常，Console.WriteLine()输出：求助的Reward为负数（-XX），不再抛出异常 
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("求助的Reward为负数（-XX）");
            }
            //ContentService中无论是否捕获异常，均要Console.WriteLine()输出：
            //XXXX年XX月XX日 XX点XX分XX秒（当前时间），请求发布内容（Id=XXX） 
            finally
            {
                Console.WriteLine(content.PublishTime+":"+content.Id);
            }
            Console.WriteLine("把"+"content"+"的内容存到数据库");


        }
      
    }

    [Serializable]
    internal class InnerException : Exception
    {
        public InnerException()
        {
        }

        public InnerException(string message) : base(message)
        {
        }

        public InnerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InnerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
