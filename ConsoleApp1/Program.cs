using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            //string name = "彭志强";
            //ushort age = 20;
            //bool isFemale = false;
            //ushort height = 165;
            //string fromCity = "湖南";
            //Console.WriteLine("name:" + name);
            //Console.WriteLine("age:" + age);
            //Console.WriteLine("isFemale:" + isFemale);
            //Console.WriteLine("height:" + height);
            //Console.WriteLine("fromCity:" + fromCity);


            //输出两个整数/小数的和/差/积/商
            /*
            测试用例--
            （小数最高精确到小数点后两位）
            整数：
            10 + 3 = 13
            10 - 3 = 7
            10 * 3 = 30
            10 / 3 = 3.33
            小数
            1.5 + 1.3 = 2.8
            1.5 - 1.3 = 0
            1.5 * 1.3 = 1.95
            1.5 / 1.3 = 1.15
            */
            //整数：
            //int x = 10;
            //int y = 3;
            ////double z = 1.22315;
            //Console.WriteLine(x + y);
            //Console.WriteLine(x - y);
            //Console.WriteLine(x * y);
            //Console.WriteLine(Math.Round((x / y), 2));
            //Console.WriteLine(((double)x / y).ToString("n2"));

            //小数：
            //double x = 1.5;
            //double y = 1.3;
            //Console.WriteLine(Math.Round((x + y), 2));
            //Console.WriteLine(Math.Round((x - y), 2));
            //Console.WriteLine(Math.Round((x * y), 2));
            //Console.WriteLine(Math.Round((x / y), 2));


            //输入一个字符，显示这个字符的unicode值
            //char str = '用';
            //Console.WriteLine((int)str);

            //输入一个整数，如果这个整数：
            //能被6整除，显示：六六顺
            //能被8整除，显示：发发发
            //既能被6又能被6整除的显示：六六顺呀！发发发！
            //否则，显示：大吉大利

            //int parameter = 36;
            //if (parameter % 6 == 0 && parameter % 8 == 0)
            //{
            //    Console.WriteLine("六六顺呀！发发发！");
            //}
            //else if (parameter % 6 == 0)
            //{
            //    Console.WriteLine("六六顺");
            //}
            //else if (parameter % 8 == 0)
            //{
            //    Console.WriteLine("发发发");
            //}
            //else
            //{
            //    Console.WriteLine("大吉大利");
            //}




            //将源栈同学姓名 / 昵称分别：
            //按进栈时间装入一维数组，
            //按座位装入二维数组，
            ////并输出共有多少名同学。
            //string[] stutent = new string[] { "陈元", "幸龙泰", "彭志强", "于维谦", "王新", "曾俊清", "杨进文", "赵敬春", "刘江平" };
            //string[,] stutent_2 = new string[3, 4] { { "彭志强", "于维谦", "", "" }, { "陈元", "刘江平", "王新", "赵敬春" }, { "杨进文", "曾俊清", "幸龙泰", "" } };
            ////Console.WriteLine("源栈一共有："+stutent.Length+"名同学");




            //分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9
            //for (int i = 1; i < 6; i++)
            //{
            //    Console.WriteLine(i);
            //};
            //int j = 1;
            //while (j < 10)
            //{
            //    Console.WriteLine(j);
            //    j += 2;
            //}


            //用for循环输出存储在一维 
            //for (int i = 0; i < stutent.Length; i++)
            //{
            //    Console.WriteLine(stutent[i]);
            //};
            ////二维数组里的源栈所有同学姓名
            //for (int i = 0; i < stutent_2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < stutent_2.GetLength(1); j++)
            //    {
            //        if (stutent_2[i, j] != "")
            //        {
            //            Console.WriteLine(stutent_2[i, j]);
            //        }
            //        else
            //        {
            //            //ignore
            //        }
            //    }
            //};

            //让电脑计算并输出：99+97+95+93+...+1的值
            //int material = 99;
            //int result = 99;
            //while (material > 1)
            //{
            //    material -= 2;
            //    result += material;
            //}
            //Console.WriteLine(result);



            //将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //double[] stutentScore = new double[] { 99, 84, 56, 88, 50.5, 64.5, 67 };
            //static double max(double[] score)
            //{
            //    double temp = score[0];
            //    for (int i = 1; i < score.Length; i++)
            //    {
            //        if (temp < score[i])
            //        {
            //            temp = score[i];
            //        }
            //        else
            //        {
            //            //noting
            //        }
            //    };
            //    return temp;
            //};

            //static double min(double[] score)
            //{
            //    double temp = score[0];
            //    for (int i = 1; i < score.Length; i++)
            //    {
            //        if (temp > score[i])
            //        {
            //            temp = score[i];
            //        }
            //        else
            //        {
            //            //nothing
            //        }
            //    }

            //    return temp;
            //};
            //Console.WriteLine("最高分：" + max(stutentScore));
            //Console.WriteLine("最低分：" + min(stutentScore));



            ///猜数字游戏
            ///   测试用例
            ///   输入1001，返回“输入错误，请输入一个不超过1000的自然数!”和剩余的机会次数。
            ///   输入-1，返回“输入错误，请输入一个不超过1000的自然数!”和剩余的机会次数。
            ///   输入"",返回“输入错误，请输入一个不超过1000的自然数!”和剩余的机会次数。
            ///   输入"sjagh&%"“输入错误，请输入一个不超过1000的自然数!”和剩余的机会次数。
            ///   ps:只能输入0-1000以内的自然数
            ///   假设结果为888
            ///   输入777，返回：太小了哦！（还剩*次）
            ///   输入999，返回：太大了哟！（还剩*次)
            ///   输入888，所用次数小于4次，返回：真厉害！猜对了！只用了*次！/否则返回：恭喜你！猜对了！用了*次。
            ///   输入次数不得超过10次，超过10次，显示：游戏结束！未能猜中。


            //Random rnd = new Random();
            //int bingo = rnd.Next(0, 1000);
            ////int bingo = 888;
            //Console.WriteLine("猜数字游戏----");
            //Console.WriteLine("请输入一个不超过1000的自然数");
            //Console.WriteLine("共有10次机会");
            //int counter = 1;
            //while (counter < 11)
            //{
            //    string speculate = Console.ReadLine();
            //    bool isInt = int.TryParse(speculate, out int intSpeculate);
            //    int surplus = 10 - counter;
            //    if (!isInt || intSpeculate > 1000 || intSpeculate < 0)
            //    {
            //        Console.WriteLine("输入错误，请输入一个不超过1000的自然数!");
            //        Console.WriteLine($"还有{surplus}次机会。");
            //    }
            //    else if (intSpeculate > bingo)
            //    {
            //        Console.WriteLine($"太大了哟！（还剩{surplus}次)");
            //    }
            //    else if (intSpeculate < bingo)
            //    {
            //        Console.WriteLine($"太小了哦！（还剩{surplus}次）");
            //    }
            //    else
            //    {
            //        if (counter <= 4)
            //        {
            //            Console.WriteLine($"真厉害！猜对了！只用了{counter}次！");
            //        }
            //        else if (counter <= 10)
            //        {
            //            Console.WriteLine($"恭喜你！猜对了！用了{counter}次。");
            //        }
            //        break;
            //    }
            //    if (counter == 10)
            //    {
            //        Console.WriteLine("游戏结束,未能猜中!");
            //    }
            //    else
            //    {
            //        //keep
            //    }
            //    //Console.WriteLine(isInt);
            //    //Console.WriteLine(intSpeculate);
            //    counter++;
            //}

            //找出100以内的质数
            //for (int i = 0; i < 101; i++)
            //{
            //    for (int j = 2; j < i / 20 + 1; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            //Console.WriteLine(i + "不是质数！");
            //            break;
            //        }
            //        else if (j >= i / 2)
            //        {
            //            Console.WriteLine(i + "是质数");
            //        }
            //    }
            //}




            //SelfIntroduce("彭志强", 20, false, 165, "湖南");
            //Add(1, 2);
            //Minus(2, 4.55);
            //Mutiply(9, 1.2);
            //Divide(20, 5);

            //GetUnicode('哈');

            //GetMax(19, 55, 66, 99, 88, 77, 88, 99, 88, 77);

            //GetAverage(19, 55, 66, 99, 88, 77, 88, 99, 88, 77);
            string a = "彭志强";
            string b = "王新";
            string[] dormitory = new string[] { "彭志强" };
            //swapBed(ref a, ref b, ref string dormitory["jjj"]);



        }
        //将之前以下作业封装成方法（自行思考参数和返回值），并调用执行
        //自我介绍：SelfIntroduce()

        static void SelfIntroduce(string name, int age, bool isFemale, int height, string fromCity)
        {

            Console.WriteLine("姓名：" + name);
            Console.WriteLine("age:" + age);
            Console.WriteLine("isFemale:" + isFemale);
            Console.WriteLine("height:" + height);
            Console.WriteLine("fromCity:" + fromCity);

        }


        //加减乘除：Add() / Minus() / Mutiply() / Divide()

        static void Add(double addEnd1, double addEnd2)
        {
            Console.WriteLine(addEnd1 + addEnd2);
        }

        static void Minus(double minuend, double subtrahend)
        {
            Console.WriteLine(minuend - subtrahend);
        }

        static void Mutiply(double coefficient1, double coefficient2)
        {
            Console.WriteLine(coefficient1 * coefficient2);
        }

        static void Divide(double dividend, double divisor)
        {
            Console.WriteLine(dividend / divisor);
        }


        //取字符值：GetUnicode()
        static void GetUnicode(char input)
        {
            Console.WriteLine((int)input);
        }

        //取最高分：GetMaxFromScore()
        //取十个成绩中最高的，成绩只能是整数
        //成绩最低0分，最高100分
        static void GetMax(int score1,
                           int score2,
                           int score3,
                           int score4,
                           int score5,
                           int score6,
                           int score7,
                           int score8,
                           int score9,
                           int score10)
        {

            int[] score = new int[] { score1, score2, score3, score4, score5, score6, score7, score8, score9, score10 };
            for (int i = 0; i < score.Length; i++)
            {
                Console.WriteLine(score[i]);
                if (score[i] < 0 || score[i] > 100)
                {
                    Console.WriteLine("输入了不符合要求的成绩，请检查后重试。");
                    Console.WriteLine("成绩最低0分，满分100分。");
                    Console.WriteLine(score[i]);
                    return;
                }
                else
                {
                    //nothing
                }
            }
            int temp = 0;
            for (int j = 0; j < score.Length; j++)
            {
                if (temp < score[j])
                {
                    temp = score[j];
                }
                else
                {
                    //noting
                }
            }
            Console.WriteLine("最高分为：" + temp);
        }

        //计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
        static void GetAverage(int score1,
                               int score2,
                               int score3,
                               int score4,
                               int score5,
                               int score6,
                               int score7,
                               int score8,
                               int score9,
                               int score10)
        {
            int[] score = new int[] { score1, score2, score3, score4, score5, score6, score7, score8, score9, score10 };
            for (int i = 0; i < score.Length; i++)
            {
                //Console.WriteLine(score[i]);
                if (score[i] < 0 || score[i] > 100)
                {
                    Console.WriteLine("输入了不符合要求的成绩，请检查后重试。");
                    Console.WriteLine("成绩最低0分，满分100分。");
                    //Console.WriteLine(score[i]);
                    return;
                }
                else
                {
                    //nothing
                }
            }
            double temp = 0;
            for (int i = 0; i < score.Length; i++)
            {
                temp += score[i];
            }
            Console.WriteLine("源栈同学的平均分为：" + (temp / score.Length).ToString("n2"));
        }


        //用ref调用Swap()方法交换两个同学的床位号
        //string[] bed = new string[] { "", "", "" };


        //static void swapBed(ref string stutent1, ref string stutent2, ref dormitory)
        //{
        //    int stutent1NumberOfBed = 0;
        //    int stutent2NumberOfBed = 0;
        //    string temp = "";

        //    for (int i = 0; i <= dormitory.Length + 1; i++)
        //    {
        //        if (i == dormitory.Length)
        //        {
        //            Console.WriteLine("未找到该学生，请核查后重试。");
        //            return;
        //        }
        //        if (stutent1 == dormitory[i])
        //        {
        //            stutent1NumberOfBed = i;
        //            temp = dormitory[stutent1NumberOfBed];
        //            break;
        //        }
        //        else
        //        {
        //            //noting
        //        }
        //    }
        //    for (int j = 0; j < dormitory.Length + 1; j++)
        //    {
        //        if (j == dormitory.Length)
        //        {
        //            Console.WriteLine("未找到该学生，请核查后重试。");
        //            return;
        //        }
        //        if (stutent2 == dormitory[j])
        //        {
        //            stutent2NumberOfBed = j;
        //            dormitory[stutent2NumberOfBed] = dormitory[stutent1NumberOfBed];
        //            dormitory[stutent2NumberOfBed] = temp;
        //            break;
        //        }
        //        else
        //        {
        //            //noting
        //        }
        //    }


        }
    }
}