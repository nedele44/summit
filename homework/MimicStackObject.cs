using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    public class MimicStackObject
    {
        private int top;
        
        private object[] container;
        public MimicStackObject(int length)
        {
            
            container = new object[length];
            
        }
        public bool Push(object value)
        {
            if (top >= container.Length)
            {
                Console.WriteLine("栈以满");
                return true;
            }
            container[top] = value;
            top++;
            return false;
        }
        public object Pop(out bool empty)
        {
            empty = 0 == top;
            if (empty)
            {
                Console.WriteLine("栈以空");
                return  null;
            }
            else
            {
                top--;
                return container[top];
            }
        }
    }
}
