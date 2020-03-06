using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    static class Repository
    {
        public const int version = 1;
        internal static readonly string connection;



    }

    public class ProblemRepository
    {
        //public IList<Problem> Get()
        //{
        //    return new List<Problem>
        //    {


        //    };
        //}
        public Problem Get()
        {
            return new Problem("1", new User("sda12#", "asdfas@22"));
        }
    }
}
