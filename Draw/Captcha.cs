using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
   public class Captcha
    {
        public Captcha(string filename)
        {
            //一起帮注册页面拾取的验证码尺寸53x22
            Bitmap image = new Bitmap(53, 22);

            Graphics g = Graphics.FromImage(image);

            //底色为白色
            g.Clear(Color.White);

            //随机生成字符串    
            //需要额外创建一个实例类来生成随机的字符串，然后在new一下
            Randomstr str = new Randomstr();

            //字体和定位，先生成再调整
            g.DrawString(str.Generate(),       //绘制字符串
                   new Font("宋体", 14),                //指定字体
                   new SolidBrush(Color.DarkRed),      //绘制时使用的刷子
                   new PointF(5, 4)                    //左上角定位
               );

            //随机生成各色像素点,颜色
            //观察一起帮的像素点很多,就定为50个吧，位置随机（53x22）也随机
            for (int i = 0; i < 50; i++)
            {
                Color randomcolor = Color.FromArgb(new Random().Next(255), new Random().Next(255), new Random().Next(255));
                image.SetPixel(new Random().Next(53), new Random().Next(22), randomcolor);
            }

            //随机生成混淆用的直线和曲线
            //随机直线没有随机点多，但是也不少，就定位10个吧，位置随机，颜色也随机
            for (int i = 0; i < 10; i++)
            {
                Color randomcolor = Color.FromArgb(new Random().Next(255), new Random().Next(255), new Random().Next(255));
                Point pt1 = new Point(new Random().Next(53), new Random().Next(22));
                Point pt2 = new Point(new Random().Next(53), new Random().Next(22));
                g.DrawLine(new Pen(new SolidBrush(randomcolor)), pt1, pt2);
            }

            image.Save(filename, ImageFormat.Jpeg);
        }
    }
}
