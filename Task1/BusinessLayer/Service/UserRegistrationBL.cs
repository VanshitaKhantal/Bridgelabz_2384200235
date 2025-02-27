using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Service;

namespace BusinessLayer.Service
{
    public class UserRegistrationBL
    {
        UserRegistrationRL _userRegistrationRL;
        public UserRegistrationBL(UserRegistrationRL userRegistrationRL) 
        {
            _userRegistrationRL = userRegistrationRL;
        }

        public string registrationBL(string UserName, string Password)
        {
            if ("root".Equals(UserName) && "root".Equals(Password))
            {
                return " Login Successful " + _userRegistrationRL.registrationRL(UserName, Password);
            }
            else
            {
                return "Invalid username and password" +  _userRegistrationRL.registrationRL(UserName, Password);
            }
        }
    }
}
