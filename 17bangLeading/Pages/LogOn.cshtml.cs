﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using RazorPage.Entities;
using Microsoft.AspNetCore.Http;
using RazorPage.Repositories;
using RazorPage.Pages.Shared;
using RazorPage.Helper;

namespace RazorPage
{
    [BindProperties]
    public class LogOnModel : _AllModel
    {
        private UserRepository _userRepository;
        public LogOnModel()
        {
            _userRepository = new UserRepository();
        }


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
            base.SetLogOnStatus();
        }
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            User user = _userRepository.GetUser(UserName);
                        if (user == null)
            {
                ModelState.AddModelError(StringConst.USER_NAME, "*用户名不存在");
                return Page(); ;
            }
            else if (user.Password == StringExtension.GetMd5Hash(Password))
            {
                sendsCookies(user, Remember);
                return RedirectToPage(StringConst.Index);
            }
            else
            {
                ModelState.AddModelError(StringConst.PASSWORD, "*用户名或密码错误");
                return Page();
            }


        }

        private void sendsCookies(User user, bool remember)
        {
            CookieOptions options = new CookieOptions
            {
                IsEssential = true,
            };
            if (remember)
            {
                options.Expires = DateTime.Now.AddDays(15);
            }//else nothing
            Response.Cookies.Append(StringConst.USER_ID, $"{user.Id.ToString()}", options);
            Response.Cookies.Append(StringConst.PASSWORD, $"{user.Password.ToString()}", options);
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