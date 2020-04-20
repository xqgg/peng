using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using CSharp;
using Microsoft.AspNetCore.Http;

namespace RazorPage
{
    [BindProperties]
    public class LogOnModel : PageModel
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "*用户名不能为空")]
        [MaxLength(20, ErrorMessage = "*用户名长度不能大于20")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "*密码不能为空")]
        [StringLength(20, ErrorMessage = "*密码长度不小于6不大于20", MinimumLength = 6)]
        public string Password { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "*验证码不能为空")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "*验证码长度不正确")]
        public string SecurityCode { get; set; }

        public bool Remember { get; set; }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            if (correct(UserName, Password))
            {
                Response.Cookies.Append("UserName", $"{UserName}",
                    new CookieOptions
                    {
                        IsEssential = true
                    });
                //Response.Cookies.Delete("UserName");
            }


        }

        /// <summary>
        /// 检查用户输入的账号密码是否与数据库吻合。
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        private bool correct(string name, string password)
        {
            if (name == "1234" && password == "123456")
            {
                return true;
            }
            else
            {
                ModelState.AddModelError("", "用户名或密码不正确");
                return false;
            }
        }
    }
}