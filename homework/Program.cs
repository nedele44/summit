using System;
using Entity;
using homeWork;
//需要点击homework中Dependencies来与Entity进行引用连接
//同一个项目下，不同名称空间类的引用

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {



            ////设置索引器并调用，这里输出的是字符串的第二个，剑
            //Problem wuqi = new Problem("相濡以沫，不如相忘于江湖");
            //Console.WriteLine(wuqi[1]);

            ////每一个Problem对象一定有Body赋值
            ////这里也就是说不用执行wuqi.body= 这样的语句
            //Console.WriteLine(wuqi.Body);

            ////如果为空字符串呢
            ////并没有报错，运行结果啥都没有
            ////如果把构造函数去掉呢，立马报错
            //Problem meinv = new Problem("");
            //Console.WriteLine(meinv.Body);

            ////每一个User对象一定有Name和Password赋值
            //User zhima = new User("zhima", "545646748");
            //Console.WriteLine(zhima.Name);
            //Console.WriteLine(zhima.Password);


            ////单例模式
            ////构造函数private后，new一个对象都没法实现
            ////FactoryContext test = new FactoryContext();
            ////下面语句应该会输出构造函数的内容
            //FactoryContext.getInstance();
            ////也就说没法new一个对象，或只有一个对象Instance，或者说要实例化需在自己类里来



            ////出栈入栈检查检查
            //bool full;
            //bool empty;
            //MimicStack a = new MimicStack(3);
            //a.Push(1, out full);
            //a.Push(2, out full);
            //a.Push(2, out full);
            //Console.WriteLine(a.Pop(out empty) == 2);
            //Console.WriteLine(a.Pop(out empty) == 2);
            //Console.WriteLine(a.Pop(out empty) == 1);
            ////下面这个既输出了false，也输出了“栈以空”，是因为返回了一个-1的值
            //Console.WriteLine(a.Pop(out empty) == 1);

            //Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
            //Content test = new Article();
            //Console.WriteLine(test.kind);
            ////输出的值为为article
            //Content good = new Content();
            //Console.WriteLine(good.kind);
            //这里输出的值为content

            ////调用构造函数
            //User zhaomiao = new User("hahaha");

            ////实例化文章,调用继承自父类的属性和方法，以及自己的使用方法
            ////我在父类中设计了一个输出点踩和点赞的方法，这里先尝试继承父类点赞的操作
            //User zhao = new User("zhao");
            //User zhang = new User("zhang");
            //Article a1 = new Article() { Author = zhaomiao };
            //Console.WriteLine(a1.Praise(zhao));
            //Console.WriteLine(a1.Praise(zhang));
            ////输出的结果为1,2，也就是说在生成的对象中，有几个点赞，就帮帮币就会加几个

            ////再去尝试点踩得操作
            //Console.WriteLine(a1.Tread(zhao));
            //Console.WriteLine(a1.Tread(zhao));
            //Console.WriteLine(a1.Tread(zhao));
            ////同一个对象，进行三次操作，果然输出的结果为1,2,3


            ////尝试调用Article中自己的属性，并显示
            ////我在
            //bool full;
            //Article a2 = new Article();
            ////当我把Article类，改成Content时，下面就不能调用了
            //a2.Push("刀剑神域",out full);
            //a2.Push("刀剑神域",out full);
            //a2.Push("刀剑神域",out full);
            //a2.Push("刀剑神域",out full);
            //a2.Push("刀剑神域",out full);

            //for (int i = 0; i <5; i++)
            //{
            //    Console.WriteLine(a2.Keyword[i]);
            //}

            //调用article类的publish方法
            //Author是一个User类型，就一定要事先创建一个User类对象，才能进行赋值
            //User zhaomiao = new User("赵淼");
            //Content a = new Article() { Author=zhaomiao};
            ////发表第一篇文章，
            //a.Publish();
            ////发表第二篇文章
            //a.Publish();


            ////调用problem类的publish方法

            //Content b = new Problem(40) { Author = zhaomiao };
           
            //b.Publish();


            ////调用suggest类的Publish方法
            //Content c = new Suggest() { Author = zhaomiao };
            //c.Publish();

            //Content类的实例化，可以是Article 也可以是Problem，同时也可以是Suggest，不同的对象，同样的方法，得到的结果不同







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
