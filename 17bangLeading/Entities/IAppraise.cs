using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPage.Entities
{
    interface IAppraise
    {
        void Agree(User voter);
        void Disagree(User voter);
        int Agrees { get; set; }
        int Disagrees { get; set; }
    }
}
