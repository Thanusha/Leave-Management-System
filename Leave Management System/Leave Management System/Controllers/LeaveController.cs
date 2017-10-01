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
        DBHandler handler;

        public LeaveController()
        {
            handler = new DBHandler();
        }

        public int newLeave(Leave leave)
        {
            return handler.newLeaveMethod(leave);
        }

        public Leave[] allUserLeaves(string userID)
        {
            return handler.userAllLeavesMethod(userID);
        }

        public int deleteLeave(string leaveID)
        {
            return handler.deleteLeaveMethod(leaveID);
        }

        public int updateLeave(Leave leave)
        {
            return handler.updateLeaveMethod(handler);
        }

        public int rejectLeave(Leave leave)
        {
            throw new NotImplementedException();
        }

        public int acceptLeave(Leave leave)
        {
            throw new NotImplementedException();
        }

        public Leave[] hrLeaveRequests()
        {
            return handler.hrLeaveRequestMethod();
        }
    }
}
