using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    public class StringHomework
    {
        //实现GetCount(string container, string target)方法，可以统计出container中有多少个target
        public int GetCount(string container, string target)
        {
      bool Ishas = container.Contains(target);
            if (!Ishas)
            {
                return 0;
            }
            else
            {
                string recontainer=container.Replace(target, string.Empty);
                return (container.Length - recontainer.Length) / target.Length;//想到了用replace和empty，但没有想到用length
            }
               
        }
    }
}
