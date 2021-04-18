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

namespace FirstProgram
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new ApContext();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string Login = LoginBox.Text.Trim();
            string Password = PasswordBox.Password.Trim();
            string Password2 = PasswordBox2.Password.Trim();
            string Email = EmailBox.Text.Trim();

            if (Login.Length <= 5)
            {
                LoginBox.ToolTip = "Це поле введено не коректно";
                LoginBox.Background = Brushes.Red;
            }
            else if (Password.Length <= 5)
            {
                PasswordBox.ToolTip = "Це поле введено не коректно";
                PasswordBox.Background = Brushes.Red;
            }
            else if (Password != Password2)
            {
                PasswordBox2.ToolTip = "Це поле введено не коректно";
                PasswordBox2.Background = Brushes.Red;
            }
            else if (Email.Length <= 5 || !Email.Contains("@") || !Email.Contains("."))
            {
                EmailBox.ToolTip = "Це поле введено не коректно";
                EmailBox.Background = Brushes.Red;
            }
            else
            {
                LoginBox.ToolTip = "";
                LoginBox.Background = Brushes.Transparent;
                PasswordBox.ToolTip = "";
                PasswordBox.Background = Brushes.Transparent;
                PasswordBox2.ToolTip = "";
                PasswordBox2.Background = Brushes.Transparent;
                EmailBox.ToolTip = "";
                EmailBox.Background = Brushes.Transparent;

                User user = new User(Login, Password, Email);
                db.Users.Add(new User());
                db.SaveChanges();

                UserPageWindow userPageWindow = new UserPageWindow();
                userPageWindow.Show();
                Hide();
            }
        }

        private void Button_Window_Auth_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow secondWindow = new SecondWindow();
            secondWindow.Show();
            Hide();
        }
    }
}
