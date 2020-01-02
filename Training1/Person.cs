using System;
using System.Collections.Generic;
using System.Text;

namespace Training1
{
    //1.声明一个委托：打水（ProvideWater），可以接受一个Person类的参数，返回值为int类型
    internal delegate int ProvideWater(Person person);

    class Person
    {
        //public int GetWater(ProvideWater provideWater)
        //{
        //    provideWater(new Person());
        //    return 1;
        //}


    }
}
