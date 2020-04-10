using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork
{
    //用泛型改造堆栈，除了用T代替int以外，注意返回值为default(T)
    /// <summary>
    /// 出栈和入栈
    /// </summary>
    public class MimicStack<T>
    {
        // Length来设置栈的深度
        private int length;
        //实例每push一个top就跟着加1，每pop一个top减1，初始值为0,
        private int top;
        // 申明一个数组来表示栈,此时的数组为空null
        private T[] container;
        /// <summary>
        /// 构造函数，在new一个对象时就设置栈的深度
        /// </summary>
        /// <param name="length">栈的深度</param>
        public MimicStack(int length)
        {
            this.length = length;
            top = 0;
            container = new T[this.length];
        }
        public bool Push(T value)
        {

            //当full=true时，表示栈以满
            //当出现栈以满的时候，top已经和length相等了
          
            if (top >= length)
            {
                Console.WriteLine("栈以满");
                return true;
            }
            //top+1表示下一个赋值往后排一位，先赋值在，在加1
            container[top] = value;
            top++;
            return false;
        }
        public T Pop(out bool empty)
        {
            //如果一个值没有赋，那直接就是top等于0
            empty = 0 >= top;
            if (empty)
            {
                Console.WriteLine("栈以空");
                return default(T);
            }
            else
            //top-1和上面的加1一样
            {
                top--;
                return container[top];
            }
        }



    }
}
