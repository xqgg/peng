using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharp;
using System.ComponentModel.DataAnnotations;

namespace RazorPage
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "*邀请人不能为空")]
        public string InviterName { get; set; }

        [BindProperty]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "*邀请码不能为空")]
        [StringLength(maximumLength: 4, MinimumLength = 4, ErrorMessage = "邀请码为4位数字")]
        public string InvitationCode { get; set; }

        [BindProperty]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "*要用户名不能为空")]
        public string UserName { get; set; }

        [BindProperty]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "*密码不能为空")]
        public string Password { get; set; }

        [BindProperty]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "*确认密码不能为空")]
        [Compare("Password", ErrorMessage = "确认密码与密码不一致")]
        public string VerifyPassword { get; set; }

        [BindProperty]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "*验证码不能为空")]
        public string SecurityCode { get; set; }

        public void OnGet()
        {

        }
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }



            User inviter = new User("inviter", "mima@1") { };
            //检查通过
            if (InviterName == inviter.Name &&
                int.Parse(InvitationCode) == inviter.InvitationCode &&
                DuplicateChecking()
                )
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
        /// 用户名查重。/未实现，暂时固定返回true.
        /// </summary>
        /// <returns></returns>
        public bool DuplicateChecking()
        {
            return true;
        }

    }
}