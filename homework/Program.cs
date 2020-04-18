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




            Person teenage = new Person() { age = 14 };

            ProvideWater water1 = show1;
            Console.WriteLine("这是方法委托" + ":" + water1(teenage));

            ProvideWater water2 = delegate (Person person)
              {
                  return person.age + 1;
              };
            Console.WriteLine("这是匿名委托" + ":" + water2(teenage));

            ProvideWater water3 = person => person.age + 2;
            Console.WriteLine("这是Lambda表达式" + ":" + water3(teenage));






            Article CSharp, summit, HTML, UI, CAD;
            User dfg, xy, zm, wmz, ljp, at;
            Keyword csharp, html, ui, dashen, net, cad;

            dfg = new User("叶飞", "000000");
            xy = new User("小余", "111111");
            zm = new User("赵淼", "123456");
            wmz = new User("王明智", "123456");
            ljp = new User("刘江平", "123456");
            at = new User("阿泰", "123456");


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
            List<Keyword> keywords = new List<Keyword> { csharp, html, ui, dashen, net, cad };
            //var dfgArticle = from s in articles
            //                 where s.Author == dfg
            //                 select s;
            var dfgArticle = articles.Where(s => s.Author == dfg);
            Console.WriteLine("大飞哥发布的文章：");
            foreach (var item in dfgArticle)
            {
                Console.WriteLine(item.Title);
            }





            //2.找出2019年1月1日以后“小鱼”发布的文章 
            //var xyArticle = from s in articles
            //                where s.PublishTime > new DateTime(2019, 1, 1)
            //                where s.Author == xy
            //                select s;
            var xyArticle = articles.Where(s => s.Author == xy && s.PublishTime > new DateTime(2019, 1, 1));
            Console.WriteLine("小余19年后发布的文章：");
            foreach (var item in xyArticle)
            {
                Console.WriteLine(item.Title);
            }

            //3.按发布时间升序 / 降序排列显示文章
            //var ascendingArticle = from s in articles
            //                       orderby s.PublishTime
            //                       select s;
            var ascendingArticle = articles.OrderBy(s => s.PublishTime);
            Console.WriteLine("按升序排列发布的文章：");
            foreach (var item in ascendingArticle)
            {
                Console.WriteLine(item.Title + ":" + item.PublishTime.Date);
            }


            //var descendingArticle = from s in articles
            //                        orderby s.PublishTime descending
            //                        select s;
            var descendingArticle = articles.OrderByDescending(s => s.PublishTime);
            Console.WriteLine("按降序排列发布的文章：");
            foreach (var item in descendingArticle)
            {
                Console.WriteLine(item.Title + ":" + item.PublishTime.Date);
            }

            //4.统计每个用户各发布了多少篇文章 
            //var userArticle = from s in articles
            //                  group s by s.Author;
            var userArticle = articles.GroupBy(s => s.Author);
            Console.WriteLine("各个用户发表的文章数");
            foreach (var item in userArticle)
            {
                Console.WriteLine(item.Key.Name + ":" + item.Count());
            }


            //5.找出包含关键字“C#”或“.NET”的文章
            var keywordArticle = from s in articles
                                 where s.Keywords.Any(k => k.Name == "C#" || k.Name == ".NET")
                                 select s;
            //var keywordArticle = articles.Where(a => a.Keywords.Any(k => k.Name == "C#"||k.Name==".NET"));

            Console.WriteLine("关键字包含C#或.NET的文章：");
            foreach (var item in keywordArticle)
            {
                Console.WriteLine(item.Title);
            }

            //6.找出评论数量最多的文章 
            //var maxCommentarticle = from s in articles
            //                        orderby s.Comments.Count() descending
            //                        select s;
            var maxCommentarticle = articles.OrderByDescending(a => a.Comments.Count());
            Console.WriteLine("评论数量最多的文章:");
            Console.WriteLine(maxCommentarticle.First().Title);


            //7.找出每个作者评论数最多的文章
            //var authorArticle = from s in articles
            //                    group s by s.Author;

            //foreach (var item in authorArticle)
            //{
            //    Console.WriteLine(item.Key.Name + "评论最多的文章：");
            //    var maxComment = from s in item
            //                     orderby s.Comments.Count() descending
            //                     select s;
            //    Console.WriteLine(maxComment.First().Title);
            //}
            var authorArticle = articles.GroupBy(a => a.Author);
            foreach (var item in authorArticle)
            {
                Console.WriteLine(item.Key.Name + "评论最多的文章：");
                var maxComment = item.OrderByDescending(a => a.Comments.Count());
                Console.WriteLine(maxComment.First().Title);
            }

            //找出每个作者最近发布的一篇文章 
            //var personArticle = articles.GroupBy(a => a.Author);
            foreach (var item in authorArticle)
            {
                Console.WriteLine(item.Key.Name + "最新发布的文章的文章：");
                var recentlyArticle = item.OrderByDescending(a => a.PublishTime);
                Console.WriteLine(recentlyArticle.First().Title);
            }

            //为求助（Problem）添加悬赏（Reward）属性，并找出每一篇求助的悬赏都大于5个帮帮币的求助作者


            Problem CSharpQuestion, HTMLQuestion, SQLQuestion, UIQuestion;
            CSharpQuestion = new Problem
            {
                Title = "C#question",
                Author = zm,
                Reward = 4,

            };
            HTMLQuestion = new Problem
            {
                Title = "HTMLquestion",
                Author = wmz,
                Reward = 5,

            };
            SQLQuestion = new Problem
            {
                Title = "SQLquestion",
                Author = ljp,
                Reward = 6,

            };
            UIQuestion = new Problem
            {
                Title = " UIquestion",
                Author = at,
                Reward = 7,

            };
            List<Problem> problems = new List<Problem> { CSharpQuestion, HTMLQuestion, SQLQuestion, UIQuestion };
            var rewardBeyongfive = from s in problems
                                   where s.Reward > 5
                                   select s;
            foreach (var item in rewardBeyongfive)
            {
                Console.WriteLine(item.Title + "的求助者为" + ":" + item.Author.Name+"---"+"求助金币为"+item.Reward);
            }


















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




        }
        //创建一个委托方法
        static int show1(Person person)
        {
            return person.age;
        }

        //声明一个方法GetWater()，该方法接受ProvideWater作为参数，并能将ProvideWater的返回值输出
        static int GetWater(ProvideWater provideWater)
        {
            Person person = new Person();
            return provideWater(person);
        }

    }

}



