﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    
   public class DBMessage:ISendMessage
    {
        //实现接口，隐式实现
        public void Send()
        {
            Console.WriteLine();
        }
    }
}
