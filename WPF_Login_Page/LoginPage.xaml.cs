using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.IO;

namespace WPF_Login_Page
{
    /// <summary>
    /// Interaction logic for login_page.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        // Page Constructor: 
        public LoginPage()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(UpdateTimer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();

        }


        // Event Handler Update Timer Tick: 
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {

            DateTimebox.Text = DateTime.Now.ToString();
        }

        // Login Button: 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // In future connect to SQL database to retrieve user and pass: 
            string username = "Apple01";
            string password = "123ABC";

            // Some success message: 
            string success_message = "Login Success!";

            // Some error message: 
            string error_message = "Invalid Username or Password!";

            // Getting user input and comparing against username and password hard-coded, need to change in future for SQL: 
            if (Textbox_login.Text.Equals(username) && password.Equals(Password_box_1.Password))
            {
                // Login Success message: 
                MessageBox.Show(success_message, "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                // Login failed message: 
                MessageBox.Show(error_message, "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        // Exit Button:
        private void Button_Click_exit(object sender, RoutedEventArgs e)
        {

            // Exiting application. 
            System.Environment.Exit(0);
        }



    }

}
