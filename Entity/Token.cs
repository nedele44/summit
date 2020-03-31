using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
    
{
    //声明一个令牌枚举
    [Flags]
    public enum Token:short
    {
        SuperAdmin=1,
        Admin=2,
        Blogger=4,
        NewBie=8,
        Registered=16,

    }
}
