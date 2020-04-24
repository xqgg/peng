using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPage.Entities;

namespace RazorPage.Repositories
{
    public class UserRepository
    {

        public  User GetUser(string name)
        {
            return User.GetUserByName(name);
        }

        internal User load(int userId)
        {
            return User.GetUserById(userId);
        }
    }
}
