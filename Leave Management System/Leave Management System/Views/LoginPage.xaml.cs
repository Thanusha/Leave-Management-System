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


namespace Leave_Management_System.Views
{
    
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
        }
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void login_btn_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(username_box.Text) && !string.IsNullOrWhiteSpace(password_box.Text))
            {
                UserController controller = new UserController();
                User user = controller.loginUser(username_box.Text, password_box.Text);

                //Pass the user obj param if needed.
                if(user == null)
                {

                }
                else if(user.IsHR)
                {
                    Frame.Navigate(typeof(HRWelcomPage), user);
                }
                else
                {
                    Frame.Navigate(typeof(WelcomPage), user);
                }
                
            }
            
        }
    }
}
