using Leave_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leave_Management_System.Controllers
{
    public class UserController
    {
        public User loginUser(string username, string password)
        {

            DBHandler handler = new DBHandler();
            return handler.loginMethod(username, password);   

        }
    }
}
