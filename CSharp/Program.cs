using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //图像的数据类型比较复杂，以后再说
            {
                ////性别的数据类型应该字符
                //char male = '男';
                //char female = '女';
                ////年月日应该是用整数
                //int Year = 2020;
                //int Month = 3;
                ////关键字应该是用字符串
                //string[] keyWord = { "编程开发语言", "工具软件", "顾问咨询", "操作系统" };
                ////自我介绍也是字符;
            }



            //输出两个整数的和差积商
            //int a, b;
            //a = 10;
            //b = 20;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);





            //电脑计算输出，精确到小数点后2位
            {
                int S = ((23 + 7) * 12 - 8) * 1000 / 6;
                Console.WriteLine(S);
                int s1 = S / 10;//取整
                int s2 = S % 10;//取余
                                //四舍五入
                if (s2 >= 5)
                {
                    float h = s1 + 1;
                    float r;
                    r = h / 100;
                    Console.WriteLine(r);
                }
                else
                {
                    float h = s1;
                    float r;
                    r = h / 100;
                    Console.WriteLine(r);
                }
            }




            //想想一下语句的输出结果
            {
                int i = 15;
                Console.WriteLine(i++);
                //这里居然是输出15，但是下一行输出5，说明++符号在Console之后，这个要注意
                Console.WriteLine(3 + 2);
                //虽然输出为15到时i的值已经是16
                i -= 5;
                Console.WriteLine(i);
                //这里输出11
                Console.WriteLine(i >= 10);
                //这里输出True

                Console.WriteLine("i值的最终结果为：" + i);
                //这里输出 i的值得最终结果为：11

                int j = 20;
                Console.WriteLine($"{i}+{j}={i + j}");
                //这里输出 {11}+{20}={31} 错了
                //输出是 10+20=30 为啥大括号为消失

                Console.WriteLine($"（i）+（j）=（i + j）");
                //这个输出小括号居然还保有
            }




            //想一想如下代码的结果是什么，并说明原因：
            {
                int a = 10;
                Console.WriteLine(a > 9 && (!(a < 11) || a > 10));
            }
            //1&&(!(1)||(0))=0 输出应该是False



            //当a为何值时，结果为true？ 
            {
                int a = 12;
                bool result = (a + 3 > 12) && a < 3.14 * 4 && a != 11;
                Console.WriteLine(result);

                //这个要三个项都是真才行，a大于9，a小于12.56 a还不能等于11
                //如果a为整数，那他只能是10和12
            }


            ////分支相关作业
            // 观察一起帮登录页面，用if...else...完成以下功能。
            //试验了一下，功能基本完成
            //{

            //    string usernameD = "赵淼";
            //    string passwordD = "17bang";
            //    string securityCode = "5060";
            //    Console.WriteLine("请输入验证码：5060");
            //    string securityCodeR = Console.ReadLine();

            //    if (securityCodeR != securityCode)
            //    {
            //        Console.WriteLine("验证码错误");
            //    }
            //    else
            //    {
            //        Console.WriteLine("请输入用户名:");
            //        string userNameR = Console.ReadLine();

            //        if (userNameR != "username_d")
            //        {
            //            Console.WriteLine("用户名不存在");
            //        }
            //        else
            //        {
            //            Console.WriteLine("请输入密码:");
            //            string possword1 = Console.ReadLine();
            //            if (possword1 != password_d)
            //            {
            //                Console.WriteLine("用户名或密码错误");
            //            }
            //            else
            //            {
            //                Console.WriteLine("恭喜！登录成功");
            //            }
            //        }
            //    }
            //}



            //一下是关于数组和数据结构相关的作业
            {
                string[] students;
                students = new string[] { "李腾", "小黄", "王名智", "阿泰", "刘江平" };
                int[,] students2 = { { 2, 3 }, { 1, 2 } };
                Console.WriteLine(students.Length);
            }








            //关于循环的作业
            //分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9
            {
                //for (int i = 1; i < 6; i++)
                //{
                //    Console.WriteLine(i);
                //}

                //int i = 0;
                //while (i<5)
                //{
                //    i++;
                //    Console.WriteLine(i);
                //}

                //for (int i = 1; i < 11; i+=2)
                //{
                //    Console.WriteLine(i);
                //}

                //int i = 1;
                //while (i<11)
                //{
                //    Console.WriteLine(i);
                //    i += 2;
                //}
            }


            //用for循环输出存储在一维/二维数组里的源栈所有同学姓名/昵称
            {
                //string[] stuName = { "赵淼", "王名智", "小黄", "阿泰", "刘江平" };
                //string[] nikName = { "推理之子", "王月胖子", "bilibili", "源栈-泰", "陌城以北" };
                //for (int i = 0; i < 5; i++)
                //{
                //    Console.WriteLine(stuName[i]+":"+nikName[i]);
                //}
            }
            {
                string[,] stuNikname = { { "赵淼", "王名智", "小黄", "阿泰", "刘江平" }, { "推理之子", "王月胖子", "bilibili", "源栈-泰", "陌城以北" } };

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(stuNikname[0, i] + ":" + stuNikname[1, i]);
                }
            }

            //让电脑计算并输出：99+97+95+93+...+1的值
            //{
            //    int sumInt;
            //    sumInt = 1;
            //    for (int i = 1; i < 100; i += 2)
            //    {
            //        sumInt += i;
            //    }
            //    Console.WriteLine(sumInt);
            //}

            //将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分


            //{
            //    double[] Score = { 88.88, 99.99, 77.77, 55.55, 66.66 };
            //    double scoreMax, scoreMin;
            //    scoreMax = Score[0];
            //    scoreMin = Score[0];

            //    for (int i = 1; i < 5; i++)
            //    {
            //        if (Score[i] > scoreMax)
            //        {
            //            scoreMax = Score[i];
            //        }//else nothing change
            //    }
            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (Score[i] < scoreMin)
            //        {
            //            scoreMin = Score[i];
            //        }//else nothing change
            //    }
            //    Console.WriteLine(scoreMax);
            //    Console.WriteLine(scoreMin);
            //}

            //{
            //    double[] Score = { 88.88, 99.99, 77.77, 55.55, 66.66 };
            //    double scoreMax, scoreMin;
            //    scoreMax = Score[0];
            //    scoreMin = Score[0];

            //    for (int i = 1; i < 5; i++)
            //    {
            //        if (Score[i] > scoreMax)
            //        {
            //            scoreMax = Score[i];
            //        }//else nothing change

            //        if (Score[i] < scoreMin)
            //        {
            //            scoreMin = Score[i];
            //        }//else nothing change
            //    }
            //    Console.WriteLine(scoreMax);
            //    Console.WriteLine(scoreMin);
            //}


            //找到1000以内的所有质数
            //{
            //    int Max = 1000;
            //    //指数肯定是大于2的奇数
            //    //假设i=29  2 
            //    Console.WriteLine(2);
            //    for (int i = 3; i < Max+1; i+=2)
            //    {
            //        bool flag = false;
            //        for (int j = 2; j*j< i; j++)
            //        {
            //            if (i%j==0)
            //            {
            //                flag=true;
            //            }
            //        }
            //        if (!flag)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }

            //}


            //生成一个元素（值随机）从小到大排列的数组
            {
                Random ran = new Random();

                int[] nList = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };//给个默认的10项数组
                nList[0] = ran.Next(1000);//把第一项先随机出来
                Console.WriteLine(nList[0]);
                for (int i = 1; i < 10; i++)
                {
                    nList[i] = ran.Next(nList[i - 1], 990+i);//990+i用来避免后面出现重复
                    Console.Write(nList[i]+",");
                }
                

            }






        }
    }
}
