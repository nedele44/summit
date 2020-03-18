using System;

namespace Entity
{
    public class Class1
    {
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
            int[] array = new int[length];//这么能制定参数的范围，
            array[0] = ran.Next(Max / length);//把第一项先随机出来
            //Console.Write(array[0] + "\t");
            for (int i = 1; i < length; i++)
            {
                array[i] = array[i - 1] + ran.Next(Max / length);//
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
                bool isprime = false;
                for (int j = 2; j * j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isprime = true;
                    }
                }
                if (!isprime)
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
        }

        /// <summary>
        /// 制定任意项的等差数列
        /// </summary>
        /// <param name="min">首项</param>
        /// <param name="gap">差距</param>
        /// <param name="length">项数</param>
        /// <returns>一维等差数组</returns>
        static int[] GetArray(int min = 1, int gap = 5, int length = 10)
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

        /// <summary>
        /// 二分法查找数组中数据，并返回所在位置
        /// </summary>
        /// <param name="arr">数组</param>
        /// <param name="start">首项下标</param>
        /// <param name="end">尾项下标</param>
        /// <param name="khey">需要寻找的值</param>
        /// <returns></returns>
        static int binary_search(int[] arr, int end, int khey, int start = 0)
        {
            int mid;
            //此方法的精髓在于start和end随着mid的变动
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (arr[mid] < khey)
                    start = mid + 1;
                else if (arr[mid] > khey)
                    end = mid - 1;
                else
                    return mid;
            }
            return -1;
        }



        public void LogOn(string username, string password, string verificode)
        {
            if (verificode != "5656")
            {
                Console.WriteLine("验证码输入错误");
            }
            else
            {
                if (username !="赵淼")
                {
                    Console.WriteLine("用户名不存在");
                }
                else
                {
                    if (password != "26554554")
                    {
                        Console.WriteLine("密码错误");
                    }
                    else
                    {
                        Console.WriteLine("登录成功");
                    }
                }
            }
        }

    }
}
