using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage
{
    public class RegisterModel : PageModel
    {
        public string Password { get; set; }
        public string VerifyPassword { get; set; }
        public string UserName { get; set; }
        public int InvitationCode { get; set; }
        public string inviter { get; set; }
        public string SecurityCode { get; set; }
        public void OnGet()
        {

        }
    }
}