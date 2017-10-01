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
        private DateTime fromDate;
        private DateTime toDate;
        private string reason;
        private string leaveID;
        private int status;

        public string UserID
        {
            get { return this.userID; }
            set { this.userID = value; }
        }

        public DateTime FromDate
        {
            get { return this.fromDate; }
            set { this.fromDate = value; }
        }

        public DateTime ToDate
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
    }
}
