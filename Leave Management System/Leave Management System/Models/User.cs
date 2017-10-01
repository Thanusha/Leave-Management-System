using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leave_Management_System.Models
{
    public class User
    {
        private string first_name;
        private string last_name;
        private string nic;
        private string telephone;
        private string email;
        private DateTime dob;
        private string password;
        private int total_leaves;
        private bool isHR;

        public string FirstName
        {
            get { return this.first_name;  }
            set { this.first_name = value; }
        }

        public string LastName
        {
            get { return this.last_name; }
            set { this.last_name = value; }
        }

        public string NIC
        {
            get { return this.nic; }
            set { this.nic = value; }
        }

        public string Telephone
        {
            get { return this.telephone; }
            set { this.telephone = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public DateTime DOB
        {
            get { return this.dob; }
            set { this.dob = value; }
        }
        
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public int TotalLeaves
        {
            get { return this.total_leaves; }
            set { this.total_leaves = value; }
        }

        public bool IsHR
        {
            get { return this.isHR; }
            set { this.isHR = value; }
        }


    }
}
