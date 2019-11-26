using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class DoubleLinked
    {
        public DoubleLinked Previous { get; private set; }
        public DoubleLinked Next { get; private set; }
        public bool IsHead
        {
            get
            {
                return Previous == null;
            }
        }
        public bool IsTail
        {
            get
            {
                return Next == null;
            }
        }
    }
}
