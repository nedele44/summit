using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业
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
            {
                //int a, b;
                //a = 10;
                //b = 20;
                //Console.WriteLine(a + b);
                //Console.WriteLine(a - b);
                //Console.WriteLine(a * b);
                //Console.WriteLine(a / b);
            }


            //电脑计算输出，精确到小数点后2位
            {
                //    int S = ((23 + 7) * 12 - 8) * 1000 / 6;
                //    Console.WriteLine(S);
                //    int s1 = S / 10;//取整
                //    int s2 = S % 10;//取余
                //                    //四舍五入
                //    if (s2 >= 5)
                //    {
                //        float h = s1 + 1;
                //        float r;
                //        r = h / 100;
                //        Console.WriteLine(r);
                //    }
                //    else
                //    {
                //        float h = s1;
                //        float r;
                //        r = h / 100;
                //        Console.WriteLine(r);
                //    }
            }


            //想想一下语句的输出结果
            {
                //    int i = 15;
                //    Console.WriteLine(i++);
                //    //这里居然是输出15，但是下一行输出5，说明++符号在Console之后，这个要注意
                //    Console.WriteLine(3 + 2);
                //    //虽然输出为15到时i的值已经是16
                //    i -= 5;
                //    Console.WriteLine(i);
                //    //这里输出11
                //    Console.WriteLine(i >= 10);
                //    //这里输出True

                //    Console.WriteLine("i值的最终结果为：" + i);
                //    //这里输出 i的值得最终结果为：11

                //    int j = 20;
                //    Console.WriteLine($"{i}+{j}={i + j}");
                //    //这里输出 {11}+{20}={31} 错了
                //    //输出是 10+20=30 为啥大括号为消失

                //    Console.WriteLine($"（i）+（j）=（i + j）");
                //    //这个输出小括号居然还保有
                //
            }


            ////想一想如下代码的结果是什么，并说明原因：
            {
                //    int a = 10;
                //    Console.WriteLine(a > 9 && (!(a < 11) || a > 10));
            }
            ////1&&(!(1)||(0))=0 输出应该是False


            ////当a为何值时，结果为true？ 
            {
                //    int a = 12;
                //    bool result = (a + 3 > 12) && a < 3.14 * 4 && a != 11;
                //    Console.WriteLine(result);

                //    //这个要三个项都是真才行，a大于9，a小于12.56 a还不能等于11
                //    //如果a为整数，那他只能是10和12
            }


            ////分支相关作业
            // 观察一起帮登录页面，用if...else...完成以下功能。
            //试验了一下，功能基本完成
            {

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
            }



            ////一下是关于数组和数据结构相关的作业
            {
                //    string[] students;
                //    students = new string[] { "李腾", "小黄", "王名智", "阿泰", "刘江平" };
                //    int[,] students2 = { { 2, 3 }, { 1, 2 } };
                //    Console.WriteLine(students.Length);
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
                //    //}
                //}
                //{
                //    string[,] stuNikname = { { "赵淼", "王名智", "小黄", "阿泰", "刘江平" }, { "推理之子", "王月胖子", "bilibili", "源栈-泰", "陌城以北" } };

                //    for (int i = 0; i < 5; i++)
                //    {
                //        Console.WriteLine(stuNikname[0, i] + ":" + stuNikname[1, i]);
                //    }
            }

            //让电脑计算并输出：99+97+95+93+...+1的值
            {
                //    int sumInt;
                //    sumInt = 1;
                //    for (int i = 1; i < 100; i += 2)
                //    {
                //        sumInt += i;
                //    }
                //    Console.WriteLine(sumInt);
            }

            //将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            {
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
            }

            {
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
            }



            //上面的作业，飞哥可以不用细看了














            //找到1000以内的所有质数
            {
                //    int Max = 1000;
                //    //指数肯定是大于2的奇数
                //    //假设i=29  2 
                //    Console.WriteLine(2);
                //    for (int i = 3; i < Max+1; i+=2)
                //    {
                //        bool prime = false;
                //        for (int j = 2; j*j< i; j++)
                //        {
                //            if (i%j==0)
                //            {
                //                flag=true;
                //            }
                //        }
                //        if (!prime)
                //        {
                //            Console.WriteLine(i);
                //        }
                //    }

            }


            //生成一个元素（值随机）从小到大排列的数组
            {
                //Random ran = new Random();

                //int[] array = new int[10];//给个默认的10项数组
                //array[0] = ran.Next(100);//把第一项先随机出来
                //Console.Write(array[0] + "\t");
                //for (int i = 1; i < 10; i++)
                //{
                //    array[i] = array[i - 1] + ran.Next(100);//990+i用来避免后面出现重复
                //    Console.Write(array[i] + "\t");
                //}
                //Console.Write("\n");
            }

            //猜数字，限制次数10，输入一个不超过1000的自然数
            {
                //Console.WriteLine("Hello World");
                //Console.WriteLine("请输入一个不超过1000的自然数");
                //int Mystery = new Random().Next(1000);
                //Console.WriteLine(Mystery);
                //bool pass = false;
                //for (int i = 1; i < 10; i++)
                //{
                //    int answer = int.Parse(Console.ReadLine());
                //    if (answer==Mystery)
                //    {
                //        Console.WriteLine("恭喜你，答对了！只用了" + i+ "次呢，棒棒哒！");
                //        pass = true;//当十次没有猜对时准备
                //        break;
                //    }
                //    else if (answer > Mystery)
                //    {
                //        Console.WriteLine("太大了哟" + "(还剩" + (10 - i) + "次）");

                //    }
                //    else
                //    {
                //        Console.WriteLine("太小了哟" + "(还剩" + (10- i) + "次）");
                //    }
                //}
                //if (!pass)
                //{
                //    Console.WriteLine("很遗憾，游戏结束。");
                //}
            }

            {
                //int[,] array = new int[3, 4];
                //for (int i = 0; i < 3; i++)
                //{
                //    for (int j = 0; j < 4; j++)
                //    {
                //        array[i, j] = i + j;
                //        Console.Write(array[i, j] + "\t");
                //    }
                //    Console.WriteLine("");
                //}
            }      //Console.Write(array);



            //调用我编写的多行多列数组
            //在函数中生成数组，下面是显示数组的方法
            {
                //int[,] result = specialMatrix(3, 4);
                //for (int i = 0; i < 3; i++)
                //{
                //    for (int j = 0; j < 4; j++)
                //    {
                //        Console.Write(result[i, j] + "\t");
                //    }
                //    Console.WriteLine("");
                //}
            }


            //调用我编写的任意项任意范围的生成随机升序的数列
            {
                //int[] result = IncreaseList(11, 2200);
                //for (int i = 0; i < 11; i++)
                //{
                //    Console.Write(result[i] + "\t");
                //}
            }



            //调用编写的取质数方法
            {
                //Prime(2000);
            }



            //先构建GetAverage函数，精确到两位小数
            {
                //double result = GetAverage(10);
                //Console.WriteLine(result);
            }




            //猜数字，方法名GuessMe，范围为1000，不能超过十次
            {
                //GuessMe(100, 9);

            }


            //利用ref调用Swap()方法交换两个同学的床位号
            {
                //string a = "01";
                //string b = "02";
                //Swap(ref a, ref b);
            }


            //生成数组，int[] GetArray(),从小到大
            //参数包含：最小值min,差值gap（默认为5）,元素个数length(默认为10个)
            {
                //int[] reslut = GetArray(10,15,20);
                //for (int i = 0; i < 20; i++)
                //{
                //    Console.Write(reslut[i]+ "\t");
                //}
            }
        }



        //下面是创建的函数



        //设立并显示一个多维数组的值，元素值等于下标之和。Console.Write()
        //生成一个多行多列的数组，各项的值等于下标之和
        /// <summary>
        /// 输入行数和列数，就能生成一个每项等于下标之和的特殊矩阵
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns>特殊矩阵</returns>
        static int[,] specialMatrix(int row, int col)
        {
            int[,] array = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array[i, j] = i + j;
                    //Console.Write(array[i, j] + "\t");
                }
                //Console.WriteLine("");
            }
            return array;
        }




        /// <summary>
        /// 生成任意长度任意范围的从小到大的随机数组
        /// </summary>
        /// <param name="length">数组的长度大于2</param>
        /// <param name="Max">范围，大于100</param>
        /// <returns></returns>
        static int[] IncreaseList(int length, int Max)
        {
            Random ran = new Random();
            int[] array = new int[length];//这么能制定参数的范围，还是要用if来限制，这个需要考虑
            array[0] = ran.Next(Max / length);//把第一项先随机出来
            //Console.Write(array[0] + "\t");
            for (int i = 1; i < length; i++)
            {
                array[i] = array[i - 1] + ran.Next(Max / length);//990+i用来避免后面出现重复
                //Console.Write(array[i] + "\t");
            }
            //Console.Write("\n");
            return array;
        }



        /// <summary>
        /// 输出任意大于2的数内的所有质数
        /// </summary>
        /// <param name="Max">范围</param>
        static void Prime(int Max)
        {
            Console.Write(2);
            for (int i = 3; i < Max; i += 2)
            {
                bool flag = false;
                for (int j = 2; j * j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    Console.Write(i + " ");
                }
            }

        }


        /// <summary>
        /// 计算所用学生的平均数
        /// </summary>
        /// <param name="Length">学生的的数量</param>
        /// <returns>学生的平均成绩，并精确到小数点后两位</returns>
        static double GetAverage(int Length)
        {

            double[] array = new double[Length];//申明一个小数数组来装学生成绩
            double sum = 0;//初始化总成绩
            double average;
            for (int i = 0; i < Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < Length; i++)
            {
                sum = sum + array[i];
            }

            average = Math.Round(sum / Length, 2);

            return average;
        }


        /// <summary>
        /// 猜数字游戏
        /// </summary>
        /// <param name="max">可猜测范围</param>
        /// <param name="times">可猜测数字,建议大于8</param>
        static void GuessMe(int max, int times)
        {
            Console.WriteLine("请输入一个不超过" + max + "的自然数");
            int Mystery = new Random().Next(max);
            Console.WriteLine(Mystery);
            bool pass = false;
            for (int i = 0; i < times; i++)
            {
                int answer = int.Parse(Console.ReadLine());
                if (answer > Mystery)
                {
                    Console.WriteLine("大了");
                }
                else if (answer < Mystery)
                {
                    Console.WriteLine("小了");

                }
                else
                {
                    if (i < 5)
                    {
                        Console.WriteLine("你真牛B");
                    }
                    else if (i < 8)
                    {
                        Console.WriteLine("不错嘛");
                    }
                    pass = true;//当十次没有猜对时准备
                    break;
                }
            }
            if (!pass)
            {
                Console.WriteLine("(～￣(OO)￣)ブ");
            }
        }


        /// <summary>
        /// 对换两个同学的座位号
        /// </summary>
        /// <param name="stu1">第一个学生座位号</param>
        /// <param name="stu2">第二个学生座位号</param>
        /// <returns>两个座位号对调</returns>
        static void Swap(ref string stu1, ref string stu2)
        {
            string mid;
            mid = stu1;
            stu1 = stu2;
            stu2 = mid;
            Console.WriteLine(stu1 + "," + stu2);
        }

        /// <summary>
        /// 制定任意项的等差数列
        /// </summary>
        /// <param name="min">首项</param>
        /// <param name="gap">差距</param>
        /// <param name="length">项数</param>
        /// <returns>一维等差数组</returns>
        static int[] GetArray(int min=1,int gap=5,int length=10)
        {
           
            int[] array = new int[length];
            array[0] = min;//第一项
            //Console.Write(array[0] + "\t");
            for (int i = 1; i < length; i++)
            {
                array[i] = array[i - 1] + gap;
                //Console.Write(array[i] + "\t");
            }
            //Console.Write("\n");
            return array;
        }
    }
}
