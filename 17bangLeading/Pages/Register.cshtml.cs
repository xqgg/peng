using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharp;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Data.Common;

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

            if (new CheckNameOrPassword().Checked(Registrantinputted.UserName, Registrantinputted.Password))
            {
                ModelState.AddModelError("CheckPassword", "用户名或密码不规范");
                return Page();
            }

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bang;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                User inviter = new User("inviter", "mima@1") { };
                if (!CheckTheInvitationCode(connection, InvitationCode, InviterName))
                {
                    ModelState.AddModelError("", "邀请人或邀请码不正确");
                    return Page();
                }
                if (!DuplicateChecking(connection))
                {
                    ModelState.AddModelError("", "用户名已被占用");
                    return Page();
                }

                




                return RedirectToPage("LogOn");
            }



            //检查通过
            //if (InviterName == inviter.Name &&
            //    int.Parse(InvitationCode) == inviter.InvitationCode) { }









        }


        /// <summary>
        /// 用户名查重。/未实现，暂时固定返回true.
        /// </summary>
        /// <returns></returns>
        public bool DuplicateChecking(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand { CommandText = "", Connection = connection };
            return true;
        }
        public bool CheckTheInvitationCode(SqlConnection connection, string invitationCode, string inviter)
        {
            SqlCommand command = new SqlCommand { CommandText = "", Connection = connection };

            return true;
        }
    }






}

public class UserModel
{
    [DataType(DataType.Text)]
    [Required(ErrorMessage = "*要用户名不能为空")]
    public string UserName { get; set; }

    [DataType(DataType.Password)]
    [Required(ErrorMessage = "*密码不能为空")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Required(ErrorMessage = "*确认密码不能为空")]
    [Compare("Password", ErrorMessage = "确认密码与密码不一致")]
    public string VerifyPassword { get; set; }

}

