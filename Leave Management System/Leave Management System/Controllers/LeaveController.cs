using Leave_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leave_Management_System.Controllers
{
    public class LeaveController
    {

        public int newLeave(Leave leave)
        {
            DBHandler handler = new DBHandler();
            return handler.newLeaveMethod(leave);
        }

        public Leave[] allUserLeaves(string userID)
        {
            DBHandler handler = new DBHandler();
            return handler.userAllLeavesMethod(userID);
        }
    }
}
