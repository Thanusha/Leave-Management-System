using Leave_Management_System.Controllers;
using Leave_Management_System.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class NewLeave : Page
    {
        public NewLeave()
        {
            this.InitializeComponent();
        }

        User user = new User();
        string userNIC = string.Empty;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            warning_message.Text = "";
            user = e.Parameter as User;
            userNIC = user.NIC;
        }

        private async void apply_btn_Click(object sender, RoutedEventArgs e)
        {
            Leave leave = new Leave();

            //Add date validation to the if block
            if (!string.IsNullOrWhiteSpace(reason_textBox.Text) && !string.IsNullOrWhiteSpace(userNIC))
            {
                leave.Reason = reason_textBox.Text;
                leave.FromDate = from_date_picker.Date.ToString();
                leave.ToDate = to_date_picker.Date.ToString();
                leave.Status = 2;
                leave.UserID = userNIC;
                leave.LeaveID = "TestingID123";

                LeaveController controller = new LeaveController();
                int status = controller.newLeave(leave);

                if(status == 1)
                {
                    MessageDialog msg = new MessageDialog("Successfully Applied!");
                    await msg.ShowAsync();                    
                }
                else
                {
                    MessageDialog msg = new MessageDialog("Failed to Apply!");
                    await msg.ShowAsync();
                }

                Frame.Navigate(typeof(WelcomPage), user);
            }
            else
            {
                warning_message.Text = "Please fill all the fields!";
            }

            
        }

        private void cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WelcomPage), user);
        }
    }
}
