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
                //char Gender = '男';
                ////年月日应该是用整数
                //int Year = 2020;
                ////关键字应该是用字符串
                //string Language = "Csharp";
                ////自我介绍也是字符串
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
            {

                string username_d = "赵淼";
                string password_d = "17bang";
                string Security_Code = "5060";
                Console.WriteLine("请输入验证码：5060");
                string Security_Code1 = Console.ReadLine();

                if (Security_Code1 != Security_Code)
                {
                    Console.WriteLine("验证码错误");
                }
                else
                {
                    Console.WriteLine("请输入用户名:");
                    string username1 = Console.ReadLine();

                    if (username1 == "")
                    {
                        Console.WriteLine("用户名不存在");
                    }
                    else if (username1 != username_d)
                    {
                        Console.WriteLine("用户名或密码错误");
                    }
                    else
                    {
                        Console.WriteLine("请输入密码:");
                        string possword1 = Console.ReadLine();
                        if (possword1 != password_d)
                        {
                            Console.WriteLine("用户名或密码错误");
                        }
                        else
                        {
                            Console.WriteLine("恭喜！登录成功");
                        }
                    }
                }
            }



            //一下是关于数组和数据结构相关的作业
            {
                string[] students;
                students = new string[] { "李腾", "小黄", "王名智", "阿泰", "刘江平" };
                int[,] students2 = { { 2, 3 }, { 1, 2 } };
                Console.WriteLine(students.Length);
            }




            //关于循环的作业

        }

    }
}
