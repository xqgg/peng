using System;
using System.Reflection;
using CSharp;
using System.Linq;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Content.ContentDo();
            //Article.ArticleDo();
            //User.UserDo();
            //GetCount.GetCountDo();
            //Console.WriteLine(new MimicJoin().mimicJoin("~","soijd8","21123ejoi"));
            //;
            //CheckPassword check = new CheckPassword();
            //Console.WriteLine(check.Checked("222&g"));
            int wait = new Random().Next(0, 3000);
            for (int i = 0; i < 10; i++)
            {
                LinqQuery.Wait();
                Console.WriteLine(wait);

            }





        }





    }
}