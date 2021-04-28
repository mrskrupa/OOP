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
using System.Windows.Media.Animation;

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


            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = 0;
            doubleAnimation.To = 230;
            doubleAnimation.Duration = TimeSpan.FromSeconds(2);
            Girls_Button.BeginAnimation(Button.WidthProperty, doubleAnimation);


            DoubleAnimation thirdanimation = new DoubleAnimation();
            thirdanimation.From = 0;
            thirdanimation.To = 230;
            thirdanimation.Duration = TimeSpan.FromSeconds(2);
            Boys_Button.BeginAnimation(Button.WidthProperty, thirdanimation);
        }

        private void Button_Boys_Click(object sender, RoutedEventArgs e)
        {
            WeightAndHeightListBoysWindow weightAndHeightListBoysWindow = new WeightAndHeightListBoysWindow();
            weightAndHeightListBoysWindow.Show();
            Hide();
        }

        private void Button_Girls_Click(object sender, RoutedEventArgs e)
        {
            WeightAndHeightListGirlsWindow weightAndHeightListGirlsWindow = new WeightAndHeightListGirlsWindow();
            weightAndHeightListGirlsWindow.Show();
            Hide(); 
        }
    }
}
