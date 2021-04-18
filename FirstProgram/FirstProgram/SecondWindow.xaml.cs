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
using System.Windows.Shapes;

namespace FirstProgram
{
    /// <summary>
    /// Логика взаимодействия для SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            string Login = LoginBox.Text.Trim();
            string Password = PasswordBox.Password.Trim();

            if (Login.Length < 5)
            {
                LoginBox.ToolTip = "Це поле введено не коректно";
                LoginBox.Background = Brushes.Red;
            }
            else if (Password.Length < 5)
            {
                PasswordBox.ToolTip = "Це поле введено не коректно";
                PasswordBox.Background = Brushes.Red;
            }
            else
            {
                LoginBox.ToolTip = "";
                LoginBox.Background = Brushes.Transparent;
                PasswordBox.ToolTip = "";
                PasswordBox.Background = Brushes.Transparent;

                User authUser = null;
                using (ApContext db = new ApContext())
                {
                    authUser = db.Users.Where(b => b.login == Login && b.password == Password).FirstOrDefault();
                }
                if (authUser != null)
                {
                    UserPageWindow userPageWindow = new UserPageWindow();
                    userPageWindow.Show();
                    Hide();
                }
                else
                    MessageBox.Show("Данні не коректні");
            }
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
    } 
}
