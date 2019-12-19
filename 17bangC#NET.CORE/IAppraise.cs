using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    interface IAppraise
    {
        public void Agree(User voter);
        public void Disagree(User voter);
    }
}
