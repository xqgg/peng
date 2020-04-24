using CSharp;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPage.Pages.Shared
{
    public class _AllModel : PageModel
    {
        private Repositories.UserRepository _userRepository = new Repositories.UserRepository();


        public virtual void OnGet()
        {
            bool hasUserId = Request.Cookies.TryGetValue("UserId", out string userId);
            if (hasUserId)
            {
                User user = _userRepository.load(Convert.ToInt32(userId));
                ViewData["UserName"] = user.Name;
            }
        }
    }
}
