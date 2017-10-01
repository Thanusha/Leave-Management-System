using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leave_Management_System.Models
{
    public class Leave
    {
        private string userID;
        private string fromDate;
        private string toDate;
        private string reason;
        private string leaveID;
        private int status;

        public string UserID
        {
            get { return this.userID; }
            set { this.userID = value; }
        }

        public string FromDate
        {
            get { return this.fromDate; }
            set { this.fromDate = value; }
        }

        public string ToDate
        {
            get { return this.toDate; }
            set { this.toDate = value; }
        }

        public string Reason
        {
            get { return this.reason; }
            set { this.reason = value; }
        }

        public string LeaveID
        {
            get { return this.leaveID; }
            set { this.leaveID = value; }
        }

        public int Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        //Status : Accepted - 0, Rejected - 1, Pending - 2
    }
}
