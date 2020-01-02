using System;
using System.Collections.Generic;
using System.Text;

namespace Training1
{
    //1.声明一个委托：打水（ProvideWater），可以接受一个Person类的参数，返回值为int类型
    internal delegate int ProvideWater(Person person);

    class Person
    {
        public static int UseDelegate(Person person)
        {
            return 1;
        }



        public static void GetWater(ProvideWater provideWater)
        {
            Console.WriteLine($"得到水{provideWater(new Person())}");
        }

        public static void Do()
        {
            //使用：
            //1.方法
            Person man = new Person();
            ProvideWater provide = new ProvideWater(UseDelegate);
            Console.WriteLine(provide(man));

            //2.匿名方法
            provide = delegate (Person person)
            {
                return 2;
            };
            Console.WriteLine(provide(man));

            //3.lambda表达式
            provide = p => 3;
            Console.WriteLine(provide(man));

            //声明一个方法GetWater()，该方法接受ProvideWater作为参数，并能将ProvideWater的返回值输出
            GetWater(provide);


        }
    }
}
