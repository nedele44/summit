using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Entity
{
    //是不是可以这样理解，只要输入一个Content的对象和指定了时间，那某输出的是指定时间
    public class CreatTimeChange
    {
        //封装一个方法来修改Content的CreateTime
        private DateTime Timechange { get; set; }
        public void ToChange(Content content,DateTime timechange)
        {
            //Content content = new Article();

            //获得这个变量的类型信息
            Type typeinfo = typeof(Content);
            //获得 CreatTime 属性的相关信息
            PropertyInfo Timeproperty= typeinfo.GetProperty("CreatTime", BindingFlags.Public | BindingFlags.Instance);
            //获取这个属性的值,应该在content的构造函数中应该设定好的，DateTime.Now
      
            
            

        }

    }
}
