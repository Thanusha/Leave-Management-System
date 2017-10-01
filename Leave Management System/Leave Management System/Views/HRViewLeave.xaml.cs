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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HRViewLeave : Page
    {
        public HRViewLeave()
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

            user_box.Text = leave.UserID;
            reason_box.Text = leave.Reason;
            from_box.Text = leave.FromDate;
            to_box.Text = leave.ToDate;
            status_box.Foreground = new SolidColorBrush(Colors.Orange);
            status_box.Text = "Pending";
        }

        private void back_btn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HRWelcomPage), user);
        }

        private async void reject_btn_Click(object sender, RoutedEventArgs e)
        {
            leave.Status = 1;
            LeaveController controller = new LeaveController();
            int status = controller.rejectLeave(leave);

            if (status == 1)
            {
                MessageDialog msg = new MessageDialog("Successfully Rejected!");
                await msg.ShowAsync();
            }
            else
            {
                MessageDialog msg = new MessageDialog("Failed to Reject!");
                await msg.ShowAsync();
            }

            Frame.Navigate(typeof(HRWelcomPage), user);
        }

        private async void approve_btn_Click(object sender, RoutedEventArgs e)
        {
            leave.Status = 0;
            LeaveController controller = new LeaveController();
            int status = controller.acceptLeave(leave);

            if(status == 1)
            {
                MessageDialog msg = new MessageDialog("Successfully Approved!");
                await msg.ShowAsync();
            }
            else
            {
                MessageDialog msg = new MessageDialog("Failed to Approve!");
                await msg.ShowAsync();
            }

            Frame.Navigate(typeof(HRWelcomPage), user);
        }
    }
}
