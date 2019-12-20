using System;

namespace Training1
{
    class Program
    {
        static void Main(string[] args)
        {

            //构造一个能装任何数据的数组，并完成数据的读写
            dynamic[] allArray = new dynamic[10];
            allArray[0] = "sasdf";
            allArray[1] = 2;
            allArray[3] = true;
            //没有默认值无法取未赋值的数组成员
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(allArray[i]);
            //}
            Console.WriteLine(allArray[0]);
            Console.WriteLine(allArray[2]);

        }
    }





}
