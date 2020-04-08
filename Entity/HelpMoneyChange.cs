using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    //自定义一个特性HelpMoneyChanged（帮帮币变化）
    //特性只能用于方法
    [AttributeUsage(AttributeTargets.Method)]
    public class HelpMoneyChange:Attribute
    {
        //有一个构造函数，可以接受一个int类型的参数amount，表示帮帮币变化的数量
        public HelpMoneyChange(int amount)
        {
            Amount = amount;

        }
        public int Amount;
        //有一个string类型的Message属性，记录帮帮币变化的原因
        public string Message { get; set; }
    }
}
