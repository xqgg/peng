using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Data.Common;
using RazorPage.Entities;

namespace RazorPage
{
    [BindProperties]
    public class RegisterModel : PageModel
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
                ModelState.AddModelError("CheckPassword", "用户名或密码不规范");
                return Page();
            }

            //DBHelper dBHelper = new DBHelper();
            //using (dBHelper.HelperConnection)
            //{
            //    dBHelper.HelperConnection.Open();
            //    if (!DuplicateChecking(Registrantinputted.UserName, dBHelper))
            //    {
            //        ModelState.AddModelError("", "用户名已被占用");
            //        return Page();
            //    }




            //}

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    //connection.Open();
            //    //User inviter = new User("inviter", "mima@1") { };
            //    //if (!CheckTheInvitationCode(connection, InvitationCode, InviterName))
            //    //{
            //    //    ModelState.AddModelError("", "邀请人或邀请码不正确");
            //    //    return Page();
            //    //}
            //    //if (DuplicateChecking(string name)
            //    //{
            //    //    ModelState.AddModelError("", "用户名已被占用");
            //    //    return Page();
            //    //}

            //    //if (!DuplicateChecking(Registrantinputted.UserName))
            //    //{
            //    //    ModelState.AddModelError("", "用户名已被占用");
            //    //    return Page();
            //    //}






            //    return RedirectToPage("LogOn");
            //}



            //检查通过
            //if (InviterName == inviter.Name &&
            //    int.Parse(InvitationCode) == inviter.InvitationCode) { }








            return Page();
        }

        /// <summary>
        /// 用户名查重。
        /// </summary>
        /// <returns></returns>
        /// 
        //[AcceptVerbs("GET", "POST")]
        public bool DuplicateChecking(string name, DBHelper dBHelper)
        {
            return (Entities.User.GetUserByName(name).Id == -1);

        }
        public bool CheckTheInvitationCode(SqlConnection connection, string invitationCode, string inviter)
        {
            SqlCommand command = new SqlCommand { CommandText = "", Connection = connection };

            return true;
        }

        //[AcceptVerbs("GET", "POST")]
        //public bool VerifyEmail(string name)
        //{
        //    //if (!_userService.VerifyEmail(name))
        //    //{
        //    //    return Json($"Email {name} is already in use.");
        //    //}

        //    //return Json(true);
        //}


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


