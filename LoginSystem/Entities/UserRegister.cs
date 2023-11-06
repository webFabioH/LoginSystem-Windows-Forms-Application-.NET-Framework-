using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.Entities
{
    static class UserRegister
    {
        private static User[] users =
        {
            new User(){ Name = "Gabriel", Password = "abc123"},
            new User(){ Name = "Danny", Password = "123abc"},
            new User(){ Name = "Arthur", Password = "abcd"}
        };

        private static User _userLogged = null;

        public static User UserLogged 
        {
            get
            {
                return _userLogged;
            }
            private set
            {
                _userLogged = value;
            }
        }

        public static bool Login(string name, string password)
        {
            foreach (User user in users)
            {
                if (user.Name == name && user.Password == password) 
                { 
                    UserLogged = user;
                    return true;
                }
            }

            return false;
        }
    }
}
