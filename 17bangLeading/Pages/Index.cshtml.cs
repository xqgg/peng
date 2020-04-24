using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Pages.Shared;

namespace RazorPage.Pages
{
    public class IndexModel : _AllModel
    {
        public void OnGet()
        {
            base.SetLogOnStatus();
        }
    }
}
