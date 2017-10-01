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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UserViewAllLeaves : Page
    {
        public UserViewAllLeaves()
        {
            this.InitializeComponent();
        }

        User user = new User();

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            user = e.Parameter as User;
            LeaveController controller = new LeaveController();            
            all_leaves_list.ItemsSource = controller.allUserLeaves(user.NIC);
        }

        private void back_btn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WelcomPage), user);
        }

        private void all_leaves_list_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
