using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Service
{
    public class UserRegistrationRL
    {
        public UserRegistrationRL() 
        {
        }

        public string registrationRL(string UserName, string Password)
        {
            return " UserName : " + UserName + " Password : " +  Password ;
        }
    }
}
