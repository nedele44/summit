using System;
using System.Collections.Generic;
using System.Text;

namespace yiqibang
{
    public class HelpMoney
    {
        private string Username;
        //用户名
        //private string Datatime;
        //时间
        public int Available { get; set; }
        //可用帮帮币
        public int Frozen { get; set; }
        //冻结
        public string Commond { get; set; }
        //备注


        public void Gain(int amount) 
        {

        }
    }
}
