using Leave_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leave_Management_System.Controllers
{
    public class DBHandler
    {
        public User loginMethod(string username, string password)
        {
            User userHard = new User();

            userHard.FirstName = "Thanusha";
            userHard.LastName = "Nirmana";
            userHard.NIC = "10";
            userHard.Telephone = "0112655623";
            userHard.Email = "thanusha@gmail.com";
            userHard.DOB = new DateTime(1995, 10, 2);
            userHard.Password = "t";
            userHard.TotalLeaves = 20;
            userHard.IsHR = false;

            if(userHard.NIC.Equals(username) && userHard.Password.Equals(password))
            {
                return userHard;
            }
            else
            {
                return null;
            }            
        }

        public int newLeaveMethod(Leave leave)
        {
            Debug.WriteLine(leave.Reason + " || " + leave.FromDate + " || " + leave.ToDate + " || " + leave.Status + " || " + leave.UserID);

            return 1;
        }
        
    }
}
