using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharp;

namespace RazorPage
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public User inviter { get; set; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public string VerifyPassword { get; set; }
        [BindProperty]
        public string SecurityCode { get; set; }
        public void OnGet()
        {

        }
        public ActionResult OnPost()
        {
            inviter = new User("yqr", "mima!1") { InvitationCode="1234"};
            return RedirectToPage("LogOn");
        }

    }
}