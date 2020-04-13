using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    public class Randomstr
    {
        //初步观察一起帮验证码，字符串由大写字母和数字组成，有4个字符
        //也就是说每一个字符可以为数字，也可以为大写字母
        private char code;
        private string checkcoke = String.Empty;
        private int number;
        public string Generate()
        {

            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                //首先生成随机的数字，妙妙妙
                number = random.Next();
                //然后用于if/else将随机数转化为字符
                //如果整除2，数字和字母的几率各占一半
                //但是估摸验证码字母的生成概率高于数字，所以整除3-5合适
                if (number % 3 == 0)
                {
                    //这里确保得到0到9的字符
                    code = (char)('0' + (char)(number % 10));
                }
                else
                {
                    //这里确保得到A到Z的字符
                    code = (char)('A' + (char)(number % 26));
                }
                checkcoke += code;
            }
            return checkcoke;
        }
    }
}
