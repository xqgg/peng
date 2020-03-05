using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage
{
    public class ForgetModel : PageModel
    {
        public string Email { set; get; }
        public string UserName { set; get; }
        public string SecurityCode { get; set; }

        public void OnGet()
        {

        }
    }
}