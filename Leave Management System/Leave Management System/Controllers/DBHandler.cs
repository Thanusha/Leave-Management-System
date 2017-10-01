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
            //Check the typed username and password from the table and if matches, return the whole User obj
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

            User userHard2 = new User();

            userHard2.FirstName = "Nuwan";
            userHard2.LastName = "Madushan";
            userHard2.NIC = "11";
            userHard2.Telephone = "01126544523";
            userHard2.Email = "nuwan@gmail.com";
            userHard2.DOB = new DateTime(1985, 8, 12);
            userHard2.Password = "a";
            userHard2.TotalLeaves = 20;
            userHard2.IsHR = true;


            //userList[0] = new User() { FirstName = "Thanusha", LastName = "Nirmana", DOB = new DateTime(1985, 11, 02), Email = "test1@gmail.com", NIC = "10", Password = "t", Telephone = "0112651332", TotalLeaves = 20, IsHR = false };
            //userList[0] = new User() { FirstName = "Peter", LastName = "Collins", DOB = new DateTime(1993, 10, 02), Email = "test2@gmail.com", NIC = "11", Password = "t", Telephone = "0112651332", TotalLeaves = 20, IsHR = false };
            //userList[0] = new User() { FirstName = "Allan", LastName = "Allman", DOB = new DateTime(1982, 10, 02), Email = "test3@gmail.com", NIC = "12", Password = "t", Telephone = "0112651332", TotalLeaves = 20, IsHR = false };
            //userList[0] = new User() { FirstName = "Anna", LastName = "Wiestra", DOB = new DateTime(1998, 10, 02), Email = "test4@gmail.com", NIC = "13", Password = "t", Telephone = "0112651332", TotalLeaves = 20, IsHR = false };
            //userList[0] = new User() { FirstName = "Gina", LastName = "Perera", DOB = new DateTime(1981, 10, 02), Email = "test5@gmail.com", NIC = "14", Password = "t", Telephone = "0112651332", TotalLeaves = 20, IsHR = false };

            if (userHard.NIC.Equals(username) && userHard.Password.Equals(password))
            {
                return userHard;
            }
            else
            {
                return null;
            }            
        }

        public Leave[] hrLeaveRequestMethod()
        {
            //Only return the leaves with pending status.

            Leave[] leaveList = new Leave[10];

            leaveList[0] = new Leave() { Reason = "Sickness 1", Status = 2, UserID = "10", LeaveID = "123", FromDate = new DateTime(2017, 10, 01).ToString(), ToDate = new DateTime(2017, 10, 03).ToString() };
            leaveList[1] = new Leave() { Reason = "Sickness 2", Status = 2, UserID = "11", LeaveID = "124", FromDate = new DateTime(2017, 10, 01).ToString(), ToDate = new DateTime(2017, 10, 03).ToString() };
            leaveList[2] = new Leave() { Reason = "Sickness 3", Status = 2, UserID = "12", LeaveID = "125", FromDate = new DateTime(2017, 10, 01).ToString(), ToDate = new DateTime(2017, 10, 03).ToString() };
            leaveList[3] = new Leave() { Reason = "Sickness 4", Status = 2, UserID = "13", LeaveID = "126", FromDate = new DateTime(2017, 10, 01).ToString(), ToDate = new DateTime(2017, 10, 03).ToString() };
            leaveList[4] = new Leave() { Reason = "Sickness 5", Status = 2, UserID = "14", LeaveID = "127", FromDate = new DateTime(2017, 10, 01).ToString(), ToDate = new DateTime(2017, 10, 03).ToString() };
            leaveList[5] = new Leave() { Reason = "Sickness 1", Status = 2, UserID = "10", LeaveID = "123", FromDate = new DateTime(2017, 10, 01).ToString(), ToDate = new DateTime(2017, 10, 03).ToString() };
            leaveList[6] = new Leave() { Reason = "Sickness 2", Status = 2, UserID = "11", LeaveID = "124", FromDate = new DateTime(2017, 10, 01).ToString(), ToDate = new DateTime(2017, 10, 03).ToString() };
            leaveList[7] = new Leave() { Reason = "Sickness 3", Status = 2, UserID = "12", LeaveID = "125", FromDate = new DateTime(2017, 10, 01).ToString(), ToDate = new DateTime(2017, 10, 03).ToString() };
            leaveList[8] = new Leave() { Reason = "Sickness 4", Status = 2, UserID = "13", LeaveID = "126", FromDate = new DateTime(2017, 10, 01).ToString(), ToDate = new DateTime(2017, 10, 03).ToString() };
            leaveList[9] = new Leave() { Reason = "Sickness 5", Status = 2, UserID = "14", LeaveID = "127", FromDate = new DateTime(2017, 10, 01).ToString(), ToDate = new DateTime(2017, 10, 03).ToString() };


            return leaveList;
        }

        public int updateLeaveMethod(DBHandler handler)
        {
            //Update the selected leave using the given whole Leave obj and return 0 or 1. 0 - Failed, 1 - Success
            throw new NotImplementedException();
        }

        public int deleteLeaveMethod(string leaveID)
        {
            //Delete the selected leave using the given leaveID and return 0 or 1. 0 - Failed, 1 - Success
            throw new NotImplementedException();
        }

        public Leave[] userAllLeavesMethod(string userID)
        {
            //Return a Leave obj array with the given users all leaves in the db
            Leave[] leaveList = new Leave[10];

            leaveList[0] = new Leave() { Reason = "Sickness 1", Status = 0, UserID = "10", LeaveID = "123", FromDate = new DateTime(2017, 10, 01).ToString(), ToDate = new DateTime(2017, 10, 03).ToString() };
            leaveList[1] = new Leave() { Reason = "Sickness 2", Status = 2, UserID = "11", LeaveID = "124", FromDate = new DateTime(2017, 10, 01).ToString(), ToDate = new DateTime(2017, 10, 03).ToString() };
            leaveList[2] = new Leave() { Reason = "Sickness 3", Status = 2, UserID = "12", LeaveID = "125", FromDate = new DateTime(2017, 10, 01).ToString(), ToDate = new DateTime(2017, 10, 03).ToString() };
            leaveList[3] = new Leave() { Reason = "Sickness 4", Status = 2, UserID = "13", LeaveID = "126", FromDate = new DateTime(2017, 10, 01).ToString(), ToDate = new DateTime(2017, 10, 03).ToString() };
            leaveList[4] = new Leave() { Reason = "Sickness 5", Status = 2, UserID = "14", LeaveID = "127", FromDate = new DateTime(2017, 10, 01).ToString(), ToDate = new DateTime(2017, 10, 03).ToString() };
            leaveList[5] = new Leave() { Reason = "Sickness 1", Status = 2, UserID = "10", LeaveID = "123", FromDate = new DateTime(2017, 10, 01).ToString(), ToDate = new DateTime(2017, 10, 03).ToString() };
            leaveList[6] = new Leave() { Reason = "Sickness 2", Status = 2, UserID = "11", LeaveID = "124", FromDate = new DateTime(2017, 10, 01).ToString(), ToDate = new DateTime(2017, 10, 03).ToString() };
            leaveList[7] = new Leave() { Reason = "Sickness 3", Status = 2, UserID = "12", LeaveID = "125", FromDate = new DateTime(2017, 10, 01).ToString(), ToDate = new DateTime(2017, 10, 03).ToString() };
            leaveList[8] = new Leave() { Reason = "Sickness 4", Status = 2, UserID = "13", LeaveID = "126", FromDate = new DateTime(2017, 10, 01).ToString(), ToDate = new DateTime(2017, 10, 03).ToString() };
            leaveList[9] = new Leave() { Reason = "Sickness 5", Status = 2, UserID = "14", LeaveID = "127", FromDate = new DateTime(2017, 10, 01).ToString(), ToDate = new DateTime(2017, 10, 03).ToString() };

            return leaveList;
        }

        public int newLeaveMethod(Leave leave)
        {
            //Send the whole Leave obj to the DB
            Debug.WriteLine(leave.Reason + " || " + leave.FromDate + " || " + leave.ToDate + " || " + leave.Status + " || " + leave.UserID);

            return 1;
        }
        
    }
}
