using System;
using yiqibang;
//同一个项目下，不同名称空间类的引用

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //调用构造函数
            User zhaomiao = new User("hahaha");


            //设置索引器并调用，这里输出的是字符串的第二个，剑
            Problem wuqi = new Problem("相濡以沫，不如相忘于江湖");
            Console.WriteLine(wuqi[1]);

            //每一个Problem对象一定有Body赋值
            //这里也就是说不用执行wuqi.body= 这样的语句
            Console.WriteLine(wuqi.Body);

            //如果为空字符串呢
            //并没有报错，运行结果啥都没有
            //如果把构造函数去掉呢，立马报错
            Problem meinv = new Problem("");
            Console.WriteLine(meinv.Body);

            //每一个User对象一定有Name和Password赋值
            User zhima = new User("zhima","545646748");
            Console.WriteLine(zhima.Name);
            Console.WriteLine(zhima.Password);


            //下面是因为题意搞错瞎弄的
            //////我首先要做一个判断邀请和邀请码是否正确
            //////这里貌似不对，如果是这样输入那不是把参数弄死了
            //string person = Console.ReadLine();
            //string code = Console.ReadLine();


            ////先接收用户注册时输入的邀请人和邀请码
            //User.SetInviteby("赵淼");
            //User.SetInvitenum("6666");

            //bool pass = User.InviteSuccess(person, code);
            //if (pass)
            //{
            //    string name = Console.ReadLine();
            //    string password = Console.ReadLine();
            //    string repassword = Console.ReadLine();
            //    string verificationcode = Console.ReadLine();
            //    User.Register(name, password, repassword, verificationcode);
            //}
            //else
            //{
            //    //User.InviteSuccess(person, code);
            //}

            ////应该还是先接收name，password和verificationcode
            ////User.SetName("赵淼");
            ////User.SetPassword("99999999");
            ////User.LogOn("Name", "Password", "5656");
        }






    }


}
