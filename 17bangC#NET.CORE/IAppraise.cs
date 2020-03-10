using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    interface IAppraise
    {
        void Agree(User voter);
        void Disagree(User voter);
        int Agrees { get; set; }
        int Disagrees { get; set; }
    }
}
