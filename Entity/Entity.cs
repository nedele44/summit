using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Entity<T>
    {
        //改造Entity类，让其Id可以为任意类型
        private T Id { get; }
    }
}
