﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Data.Common;
using RazorPage.Entities;
using RazorPage.Pages.Shared;
using RazorPage.Helper;

namespace RazorPage
{
    [BindProperties]
    public class RegisterModel : _AllModel
    {
        public UserModel Registrantinputted { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "*邀请人不能为空")]
        public string InviterName { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "*邀请码不能为空")]
        [StringLength(maximumLength: 4, MinimumLength = 4, ErrorMessage = "邀请码为4位数字")]
        public string InvitationCode { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "*验证码不能为空")]
        public string SecurityCode { get; set; }





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

            CheckNameOrPassword checker = new CheckNameOrPassword();
            if (!(checker.CheckName(Registrantinputted.UserName) && checker.CheckPassword(Registrantinputted.Password)))
            {
                ModelState.AddModelError(StringConst.Registrantinputted + "." + StringConst.PASSWORD, "*用户名密码不规范");
                return Page();
            }
            DBHelper dBHelper = new DBHelper();
            using (dBHelper.HelperConnection)
            {
                dBHelper.HelperConnection.Open();

                if (Entities.User.GetUserByName(Registrantinputted.UserName, dBHelper) != null)
                {
                    ModelState.AddModelError(StringConst.Registrantinputted + "." + StringConst.USER_NAME, "*用户名已被占用");
                    return Page();
                }
                User user = Entities.User.GetUserByName(InviterName, dBHelper);
                if (user == null || user.InvitationCode != InvitationCode)
                {
                    ModelState.AddModelError("InviterName", "*邀请人或邀请码不正确");
                }

                Entities.User Registrant = new User(Registrantinputted.UserName, Registrantinputted.Password);
                Registrant.Save(dBHelper);
                return RedirectToPage(StringConst.LogOn);
            }
        }
    }

    public class UserModel
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "*用户名不能为空")]
        //[Remote("DuplicateChecking", "Register", ErrorMessage = "用户名重复", HttpMethod = "GET")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "*密码不能为空")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "*确认密码不能为空")]
        [Compare("Password", ErrorMessage = "确认密码与密码不一致")]
        public string VerifyPassword { get; set; }

    }
}


