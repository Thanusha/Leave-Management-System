using Leave_Management_System.Controllers;
using Leave_Management_System.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Leave_Management_System.Views
{

    public sealed partial class ViewLeave : Page
    {
        public ViewLeave()
        {
            this.InitializeComponent();
        }

        User user = new User();
        Leave leave = new Leave();

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Object[] arr = e.Parameter as Object[];
            user = arr[0] as User;
            leave = arr[1] as Leave;

            reason_box.Text = leave.Reason;
            from_box.Text = leave.FromDate;
            to_box.Text = leave.ToDate;

            if (leave.Status == 0)
            {
                status_box.Foreground = new SolidColorBrush(Colors.Green);
                status_box.Text = "Accepted";
                edit_btn.Visibility = Visibility.Collapsed;
                delete_btn.Visibility = Visibility.Collapsed;
            }
            else if (leave.Status == 1)
            {
                status_box.Foreground = new SolidColorBrush(Colors.Red);
                status_box.Text = "Rejected";
                edit_btn.Visibility = Visibility.Collapsed;
                delete_btn.Visibility = Visibility.Collapsed;
            }
            else if(leave.Status == 2)
            {
                status_box.Foreground = new SolidColorBrush(Colors.Orange);
                status_box.Text = "Pending";
                edit_btn.Visibility = Visibility.Visible;
                delete_btn.Visibility = Visibility.Visible;
            }

            

        }

        private void cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(UserViewAllLeaves), user);
        }

        private async void delete_btn_Click(object sender, RoutedEventArgs e)
        {
            LeaveController controller = new LeaveController();
            int status = controller.deleteLeave(leave.LeaveID);

            if(status == 1)
            {
                MessageDialog msg = new MessageDialog("Successfully Deleted!");
                await msg.ShowAsync();
            }
            else
            {
                MessageDialog msg = new MessageDialog("Failed to Delete!");
                await msg.ShowAsync();
            }

            Frame.Navigate(typeof(UserViewAllLeaves), user);
        }

        private async void edit_btn_Click(object sender, RoutedEventArgs e)
        {
            LeaveController controller = new LeaveController();
            int status = controller.updateLeave(leave);

            if (status == 1)
            {
                MessageDialog msg = new MessageDialog("Successfully Edited!");
                await msg.ShowAsync();
            }
            else
            {
                MessageDialog msg = new MessageDialog("Failed to Edit!");
                await msg.ShowAsync();
            }

            Frame.Navigate(typeof(UserViewAllLeaves), user);
        }
    }
}
