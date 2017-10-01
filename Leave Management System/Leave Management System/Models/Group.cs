using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leave_Management_System.Models
{
    public class Group
    {
        private string team_name;
        private string group_id;

        public string TeamName
        {
            get { return this.team_name; }
            set { this.team_name = value; }
        }

        public string GroupID
        {
            get { return this.group_id; }
            set { this.group_id = value; }
        }
    }
}
