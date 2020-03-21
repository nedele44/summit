using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class FactoryContext
    {
        //单列函数的具体实现
        //将构造方法私有化，使其不能在类的外部通过new关键字实例化该类对象
        //在该类内部产生一个唯一的实例化对象，并且将其封装为private static类型
        //定义一个静态方法返回这个唯一对象

        /// <summary>
        /// 构造函数私有化，外面不能调用,也就是外面还可以new，但是不能走构造函数
        /// </summary>
        private FactoryContext() 
        {
            Console.WriteLine("单例模式");
        }
        /// <summary>
        /// new 一个对象，会走一次构造函数，这个没意义
        /// 这个也是私有化，创建一个FactoryContext类型的实例instance，还是静态的，说明会有一个内存
        /// </summary>
        private static FactoryContext instance = new FactoryContext();
        /// <summary>
        /// 静态方法返回，就是类似get的方法
        /// </summary>
        /// <returns></returns>
        public static FactoryContext getInstance()
        {
            return instance;
        }
    }
}
