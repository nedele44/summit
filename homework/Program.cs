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

            //bool empty;
            //MimicStack stacktest = new MimicStack(3);
            //stacktest.Pop(out empty);
            //Console.WriteLine(empty);//看新创建的栈是不是空的


            //stacktest.Push(1);
            //Console.WriteLine(stacktest.Pop(out empty) == 1);
            //Console.WriteLine(empty);//判断压入一个元素是不是空栈
            //stacktest.Push(2);
            //stacktest.Push(3);
            //Console.WriteLine(stacktest.Pop(out empty) == 3);//判断弹出来的是否为刚刚压入的
            //Console.WriteLine(stacktest.Pop(out empty) == 2);

            //stacktest.Pop(out empty);//判断全部元素弹出来后，是否为空
            //Console.WriteLine(empty);




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
            // User zhaomiao = new User("赵淼");
            //Article myarticle=new Article() { author=zhaomiao};
            // //发表第一篇文章，
            // myarticle.Publish(myarticle);



            // //调用problem类的publish方法

            // Problem problem = new Problem(40) { author = zhaomiao };

            // problem.Publish(problem);


            // //调用suggest类的Publish方法
            // Content suggest= new Suggest() { author = zhaomiao };
            // suggest.Publish(suggest);

            //Content类的实例化，可以是Article 也可以是Problem，同时也可以是Suggest，不同的对象，同样的方法，得到的结果不同




            ////证明struct定义的类型为值类型
            //static void add(isValueType valuetype)
            //{
            //    valuetype.a1++;
            //}
            ////先定义一个struct类型valuetype
            //isValueType valuetype = new isValueType();
            //valuetype.a1 = 10;
            //add(valuetype);
            //Console.WriteLine(valuetype.a1);
            ////如果输出的值为10，说明为值类型

            ////在来验证class定义的类型为引用类型
            //static void add1(isRefType reftype)
            //{
            //    reftype.a2++;
            //}
            ////在定义一个class类型reftype
            //isRefType reftype = new isRefType();
            //reftype.a2 = 10;
            //add1(reftype);
            //Console.WriteLine(reftype.a2);
            ////如果输出为11说明为引用类型





            //函数GetDate()，能计算一个日期若干（日/周/月）后的日期
            //Mytime weektest= new Mytime();
            //DateTime date = new DateTime(2020, 3, 28);
            //Console.WriteLine(a.GetDate(date,5,"day")==new DateTime(2020,4,2)); 
            //Console.WriteLine(a.GetDate(date,5,"day")==new DateTime(2020,4,3));
            //Console.WriteLine(a.GetDate(date, 5, "week") == new DateTime(2020, 4, 2));
            //Console.WriteLine(a.GetDate(date, 5, "week").ToString("yyyy年MM月dd日"));
            //Console.WriteLine(a.GetDate(date, 5, "month").ToString("yyyy年MM月dd日"));
            //Console.WriteLine(a.GetDate(date, 45, "month").ToString("yyyy年MM月dd日"));
            //Console.WriteLine(a.GetDate(date, 365*3, "day").ToString("yyyy年MM月dd日"));
            //Console.WriteLine(a.GetDate(date, -1, "day").ToString("yyyy年MM月dd日"));
            //Console.WriteLine(a.GetDate(date, 5, "gui").ToString("yyyy年MM月dd日"));

            //a.EveryWeek(2020);
            //weektest.EveryWeek(1991);




            //枚举中令牌管理类的相关方法测试

            TokenManager tokentest = new TokenManager(Token.Admin);
            //先判断是否含有某个权限
            Console.WriteLine( tokentest.Has(Token.Admin));
            Console.WriteLine( tokentest.Has(Token.SuperAdmin));

            Token resultAdd=tokentest.Add(Token.SuperAdmin);
            Console.WriteLine(resultAdd);
            Token resultRemove = tokentest.Remove(Token.Admin);
            Console.WriteLine(resultRemove);
         
           







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
            ///



            

        }






    }


}
