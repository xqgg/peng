using System;

namespace Training1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");




            //object[] arr = new object[10];
            //arr[0] = 10;
            //Console.WriteLine(arr[0]);


            //dynamic o = 12;
            //int sum = o + 111;
            //Console.WriteLine(sum);
            //Console.WriteLine(sum.GetType());
            //int a = 1 << 2;
            //Console.WriteLine(a);


            //object sample;
            //sample = 88;
            //int a = (int)sample;

            //Console.WriteLine(a+22);


            //Console.WriteLine(a.GetType().Name);
            //Type type = typeof(int);
            //Console.WriteLine(type);

            //Student<int> pzq = new Student<int>(165, 88);

            //Console.WriteLine(pzq.Score);
            //Console.WriteLine(pzq);

            //pzq.SetHeight(177);
            //Console.WriteLine(pzq.GetHeght());

            //pzq.x = 66;
            //Console.WriteLine(pzq.x);
            Console.WriteLine(default(int));

      
            
        }
    }

    class Sample<T> where T : struct
    {

    }

    class Student<T>
    {
        public T Score { get; set; }
        private T _height;


        //public T x { get { return Score; } set { x = Score; } }
        public Student(T height, T score)
        {
            Score = score;
            _height = height;

        }
        public T SetHeight(T height)
        {
            return _height = height;

        }

        public T GetHeght()
        {
            return _height;
        }
    }



}
