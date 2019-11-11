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
            char str = '用';
            Console.WriteLine((int)str);

        }
    }
}