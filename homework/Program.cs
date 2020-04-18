using System;
using System.Collections.Generic;
using System.Linq;
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
            Article CSharp, summit, HTML, UI, CAD;
            User dfg, xy, zm;
            Keyword csharp, html, ui, dashen, net, cad;

            dfg = new User("叶飞", "000000");
            xy = new User("小余", "111111");
            zm = new User("赵淼", "123456");


            CSharp = new Article() { Author = dfg, Title = "CSharp_Introduction", PublishTime = new DateTime(2019, 1, 1) };
            summit = new Article() { Author = dfg, Title = "summit_Introduction", PublishTime = new DateTime(2020, 1, 1) };
            HTML = new Article() { Author = dfg, Title = "HTML_Introduction", PublishTime = new DateTime(2019, 3, 1) };
            UI = new Article() { Author = xy, Title = "UI_Introduction", PublishTime = new DateTime(2018, 1, 1) };
            CAD = new Article() { Author = xy, Title = "CAD_Introduction", PublishTime = new DateTime(2020, 2, 1) };


            csharp = new Keyword
            {
                Name = "C#",
                Articles = new List<Article> { summit, CSharp }
            };

            html = new Keyword()
            {
                Name = "HTML",
                Articles = new List<Article> { summit, HTML }
            };
            ui = new Keyword()
            {
                Name = "UI",
                Articles = new List<Article> { UI }
            };
            dashen = new Keyword()
            {
                Name = "大飞哥",
                Articles = new List<Article> { summit, CSharp, HTML }
            };
            net = new Keyword()
            {
                Name = ".NET",
                Articles = new List<Article> { summit }
            };
            cad = new Keyword()
            {
                Name = "CAD",
                Articles = new List<Article> { summit }
            };

            CSharp.Keywords = new List<Keyword> { csharp, dashen };
            summit.Keywords = new List<Keyword> { csharp, dashen, html, net };
            HTML.Keywords = new List<Keyword> { dashen, html };
            UI.Keywords = new List<Keyword> { ui };
            CAD.Keywords = new List<Keyword> { cad };

            Comment zmhua = new Comment()
            {
                Article = summit,
                Content = "花花花",
                CommentBy = zm,
            };
            Comment zmgua = new Comment()
            {
                Article = CSharp,
                Content = "呱呱呱",
                CommentBy = zm,
            };
            Comment zmha = new Comment()
            {
                Article = UI,
                Content = "哈哈哈",
                CommentBy = zm,
            };
            Comment zmla = new Comment()
            {
                Article = summit,
                Content = "啦啦啦",
                CommentBy = zm,
            };
            Comment zmga = new Comment()
            {
                Article = summit,
                Content = "嘎嘎嘎",
                CommentBy = zm,
            };

            CSharp.Comments = new List<Comment> { zmgua };
            summit.Comments = new List<Comment> { zmga, zmla, zmhua };
            HTML.Comments = new List<Comment> { zmga, zmla };
            UI.Comments = new List<Comment> { zmga, zmla };
            CAD.Comments = new List<Comment> { zmha };



            //1.找出“飞哥”发布的文章 
            List<Article> articles = new List<Article> { summit, CSharp, HTML, UI, CAD };
            var dfgArticle = from s in articles
                             where s.Author == dfg
                             select s;
            Console.WriteLine("大飞哥发布的文章：");
            foreach (var item in dfgArticle)
            {
                Console.WriteLine(item.Title);
            }

            //2.找出2019年1月1日以后“小鱼”发布的文章 
            var xyArticle = from s in articles
                            where s.PublishTime > new DateTime(2019, 1, 1)
                            where s.Author == xy
                            select s;
            Console.WriteLine("小余19年后发布的文章：");
            foreach (var item in xyArticle)
            {
                Console.WriteLine(item.Title);
            }

            //3.按发布时间升序 / 降序排列显示文章
            var ascendingArticle = from s in articles
                                   orderby s.PublishTime
                                   select s;
            Console.WriteLine("按升序排列发布的文章：");
            foreach (var item in ascendingArticle)
            {
                Console.WriteLine(item.Title + ":" + item.PublishTime.Date);
            }


            var descendingArticle = from s in articles
                                    orderby s.PublishTime descending
                                    select s;
            Console.WriteLine("按降序排列发布的文章：");
            foreach (var item in descendingArticle)
            {
                Console.WriteLine(item.Title + ":" + item.PublishTime.Date);
            }

            //4.统计每个用户各发布了多少篇文章 
            var userArticle = from s in articles
                              group s by s.Author;
            Console.WriteLine("各个用户发表的文章数");
            foreach (var item in userArticle)
            {
                Console.WriteLine(item.Key.Name + ":" + item.Count());
            }


            //5.找出包含关键字“C#”或“.NET”的文章
            var keywordArticle = from s in articles
                                 where s.Keywords.Contains(csharp) || s.Keywords.Contains(net)
                                 select s;
            Console.WriteLine("关键字包含C#或.NET的文章：");
            foreach (var item in keywordArticle)
            {
                Console.WriteLine(item.Title);
            }

            //6.找出评论数量最多的文章 
            var maxCommentarticle = from s in articles
                                    orderby s.Comments.Count() descending
                                    select s;

            Console.WriteLine("评论数量最多的文章:");
            Console.WriteLine(maxCommentarticle.First().Title);


            //7.找出每个作者评论数最多的文章
            var authorArticle = from s in articles
                                group s by s.Author;
            foreach (var item in authorArticle)
            {
                Console.WriteLine(item.Key.Name+ "评论最多的文章：" );
                var maxComment=from s in item   
                               orderby s.Comments.Count() descending
                               select s;
                Console.WriteLine(maxComment.First().Title);
            }



                         

            







            //var maxCommentarticle = from s in articles
            //                        group s by s.Author into gm
            //                        select new Result
            //                        {
            //                            article = gm.Key.Name, 
            //                            count = gm.Count()   
            //                        };













            //end这个bool字段，是不能少
            //DLinkedNode node1 = new DLinkedNode { Value = 1 };
            //DLinkedNode node2 = new DLinkedNode { Value = 2 };
            //DLinkedNode node3 = new DLinkedNode { Value = 3 };
            //DLinkedNode node4 = new DLinkedNode { Value = 4 };
            //DLinkedNode node5 = new DLinkedNode { Value = 5 };

            //node2.InsertAfter(node1);
            //node3.InsertAfter(node2);
            //node4.InsertAfter(node3);
            //node5.InsertAfter(node4);

            //foreach (var item in node1)
            //{
            //    Console.WriteLine(((DLinkedNode)item).Value);
            //}

            //node1.Max();











            //使用自定义的Iout接口，来尝试协变
            //当把out去掉时，out1就会报错
            //Iout<Content> out1 = new Out<Article>();

            //Iout<Content> out2 = new Out<Content>();

            ////使用自定义的Iin接口，来尝试逆变
            ////当把in去掉是，in1就会报错
            //Iin<Article> in1 = new In<Content>();
            //Iin<Article> in2 = new In<Article>();







            //反射获取Publish()上的特性实例，输出其中包含的信息

            //            Attribute attribute = HelpMoneyChange.GetCustomAttribute(typeof(Article),typeof(HelpMoneyChange)      
            //);

            //            Console.WriteLine(((HelpMoneyChange)attribute).Message);
            //            Console.WriteLine(((HelpMoneyChange)attribute).Amount);



            //创建一个content对象，然后输出CreatTime和PublishTime的值
            //Content mary = new Article();
            //Console.WriteLine(mary.CreatTime);
            //Console.WriteLine(mary.PublishTime);





            //User s = new User();
            //s.Name = "woshiadmin";
            //Console.WriteLine(s.Name);



            //Article aaa = new Article();
            ////aaa.Title = " 4544 ";
            ////Console.WriteLine(aaa.Title);
            //aaa.Title = "4654454 45545";
            //Console.WriteLine(aaa.Title);
            //aaa.Title = null;
            //Console.WriteLine(aaa.Title);

            // aaa.womeng = 120;

            //int a1 = aaa.womeng;



            //Console.WriteLine(new MimicStack(65));//输出的是命名空间和类名

            //VarArray a = new VarArray();
            ////for (int i = 0; i < a.setarray.Length; i++)
            ////{
            ////    Console.WriteLine(a.setarray[i]);
            ////}
            //a.Get(5);//所有的元素都可以输入，回车键为基准






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
            //Mytime weektest = new Mytime();
            //weektest.EveryWeek(2020);
            //weektest.EveryWeek(1991);




            //枚举中令牌管理类的相关方法测试

            //TokenManager tokentest = new TokenManager(Token.Admin);
            ////先判断是否含有某个权限
            //Console.WriteLine( tokentest.Has(Token.Admin));
            //Console.WriteLine( tokentest.Has(Token.SuperAdmin));

            //Token resultAdd=tokentest.Add(Token.SuperAdmin);
            //Console.WriteLine(resultAdd);
            //Token resultRemove = tokentest.Remove(Token.Admin);
            //Console.WriteLine(resultRemove);









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
