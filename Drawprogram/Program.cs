using Draw;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Captcha a = new Captcha(@"F:\summit\a.jpg");
            Captcha b= new Captcha(@"F:\summit\b.jpg");
            Captcha c= new Captcha(@"F:\summit\c.jpg");
        }
    }
}
