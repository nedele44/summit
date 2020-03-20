using System;
using yiqibang;
//同一个项目下，不同名称空间类的引用

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            User User = new User();
            User zhaomiao = new User("hahaha");




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
