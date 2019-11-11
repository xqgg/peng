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
            //并输出共有多少名同学。
            string[] stutent = new string[] { "陈元", "幸龙泰", "彭志强", "于维谦", "王新", "曾俊清", "杨进文", "赵敬春", "刘江平" };
            string[,] stutent_2 = new string[3, 4] { { "彭志强", "于维谦", "", "" }, { "陈元", "刘江平", "王新", "赵敬春" }, { "杨进文", "曾俊清", "幸龙泰", "" } };
            Console.WriteLine("源栈一共有："+stutent.Length+"名同学");
        }
    }
}