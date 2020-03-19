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
        public string InviterName { get; set; }
        [BindProperty]
        public string InvitationCode { get; set; }
        [BindProperty]
        public string UserName { get; set; }
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
            User inviter = new User("inviter", "mima@1") { };
            //检查通过
            if (InviterName == inviter.Name &&
                InvitationCode == inviter.InvitationCode &&
                DuplicateChecking() &&
                Password == VerifyPassword)
            {
                if (new User(UserName, Password).Register())
                {
                    return RedirectToPage("LogOn");//注册成功后重定向到登录页面
                }
                else
                {
                    return Page();
                }
            }
            else
            {
                return Page();
            }

        }

        /// <summary>
        /// 用户名查重。
        /// </summary>
        /// <returns></returns>
        public bool DuplicateChecking()
        {
            return true;
        }

    }
}