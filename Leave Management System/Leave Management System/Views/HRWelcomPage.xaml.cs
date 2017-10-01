using Leave_Management_System.Controllers;
using Leave_Management_System.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    
    public sealed partial class HRWelcomPage : Page
    {
        public HRWelcomPage()
        {
            this.InitializeComponent();
        }

        User user = new User();

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            user = e.Parameter as User;
            fname_block.Text = user.FirstName;
            lname_block.Text = user.LastName;

            LeaveController controller = new LeaveController();
            leave_approval_listView.ItemsSource =  controller.hrLeaveRequests();
        }

        private void leave_approval_listView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Leave leave = e.ClickedItem as Leave;

            Object[] objArr = new Object[2];
            objArr[0] = user;
            objArr[1] = leave;

            Frame.Navigate(typeof(HRViewLeave), objArr);
        }

        private void logout_btn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(LoginPage));
        }
    }
}
