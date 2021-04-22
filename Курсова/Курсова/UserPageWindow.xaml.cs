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

namespace Курсова
{
    /// <summary>
    /// Логика взаимодействия для UserPageWindow.xaml
    /// </summary>
    public partial class UserPageWindow : Window
    {
        public UserPageWindow()
        {
            InitializeComponent();
        }

        private void Button_Boys_Click(object sender, RoutedEventArgs e)
        {
            AgeListBoysWindow ageListBoysWindow = new AgeListBoysWindow();
            ageListBoysWindow.Show();
            Hide();
        }

        private void Button_Girls_Click(object sender, RoutedEventArgs e)
        {
            AgeListGirlsWindow ageListGirlsWindow = new AgeListGirlsWindow();
            ageListGirlsWindow.Show();
            Hide(); 
        }
    }
}
