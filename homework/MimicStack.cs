using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork
{
    /// <summary>
    /// 出栈和入栈
    /// </summary>
    public class MimicStack
    {
        //申明一个static Length来设置栈的深度
        private static int Length;
        //实例每push一个top就跟着加1，每pop一个top减1，初始值为0,
        private static int top;
        // 申明一个数组来表示栈,此时的数组为空null
        private static int[] container;
        /// <summary>
        /// 构造函数，在new一个对象时就设置栈的深度
        /// </summary>
        /// <param name="length">栈的深度</param>
        public MimicStack(int length)
        {
            Length = length;
            top = 0;
            container = new int[Length];
        }
        /// <summary>
        /// 往数组里面加入数据
        /// </summary>
        /// <param name="value"></param>
        /// <param name="full">out 就不需要再外面额外赋值</param>
        public void Push(int value, out bool full)
        {

            //当full=true时，表示栈以满
            //当出现栈以满的时候，top已经和length相等了
            full = top >= Length;
            if (full)
            {
                Console.WriteLine("栈以满");
            }
            //top+1表示下一个赋值往后排一位，先赋值在，在加1
            else
            {
                container[top] = value;
                top++;
            }
        }
        public int Pop(out bool empty)
        {
            //如果一个值没有赋，那直接就是top等于0
            empty = 0 >= top;
            if (empty)
            {
                Console.WriteLine("栈以空");
                return -1;
            }
            else
            //top-1和上面的加1一样
            {
                top = top - 1;
                return container[top];
            }
        }



    }
}
