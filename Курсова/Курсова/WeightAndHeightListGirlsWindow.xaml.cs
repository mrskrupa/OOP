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
    /// Логика взаимодействия для WeightAndHeightListGirlsWindow.xaml
    /// </summary>
    public partial class WeightAndHeightListGirlsWindow : Window
    {
        public WeightAndHeightListGirlsWindow()
        {
            InitializeComponent();

            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = 0;
            doubleAnimation.To = 230;
            doubleAnimation.Duration = TimeSpan.FromSeconds(2);
            Cont_Button.BeginAnimation(Button.WidthProperty, doubleAnimation);
        }

        private void Button_Continue_Girls_Click(object sender, RoutedEventArgs e)
        {
            string WeightGirls = WeightGirlsBox.Text.Trim();
            string HeightGirls = HeightGirlsBox.Text.Trim();
            string AgeGirls = AgeGirlsBox.Text.Trim();
            double a = double.Parse(WeightGirls);
            double b = double.Parse(HeightGirls);
            int c = int.Parse(AgeGirls);
            if (a <= 0)
            {
                WeightGirlsBox.ToolTip = "Це поле введено не коректно";
                WeightGirlsBox.Background = Brushes.Red;
            }
            else if (b <= 0)
            {
                HeightGirlsBox.ToolTip = "Це поле введено не коректно";
                HeightGirlsBox.Background = Brushes.Red;
            }
            else if(c <= 0)
            {
                AgeGirlsBox.ToolTip = "Це поле введено не коректно";
                AgeGirlsBox.Background = Brushes.Red;
            }
            else
            {
                WeightGirlsBox.ToolTip = "";
                WeightGirlsBox.Background = Brushes.Transparent;
                HeightGirlsBox.ToolTip = "";
                HeightGirlsBox.Background = Brushes.Transparent;
                AgeGirlsBox.ToolTip = "";
                AgeGirlsBox.Background = Brushes.Transparent;

                double IMT;
                IMT = a / (b * b);
                #region Харчування
                if (c != 1 | IMT < 14.5)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 1 | IMT > 14.5 | IMT < 18)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 1 | IMT > 18 | IMT < 20)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 1 | IMT > 20)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 2 | IMT < 14)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 2 | IMT > 14 | IMT < 17.2)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 2 | IMT > 17.2 | IMT < 19)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 2 | IMT > 19)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 3 | IMT < 14)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 3 | IMT > 14 | IMT < 17)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 3 | IMT > 17 | IMT < 18.1)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 3 | IMT > 18.1)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 4 | IMT < 13.3)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 4 | IMT > 13.3 | IMT < 17)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 4 | IMT > 17 | IMT < 18)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 4 | IMT > 18)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 5 | IMT < 13.2)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 5 | IMT > 13.2 | IMT < 17)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 5 | IMT > 17 | IMT < 18.2)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 5 | IMT > 18.2)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 6 | IMT < 13.2)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 6 | IMT > 13.2 | IMT < 17.1)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 6 | IMT > 17.1 | IMT < 18.9)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 6 | IMT > 18.9)
                {
                    MenuForGirlsWindow menuForBoysWindow = new MenuForGirlsWindow();
                    menuForBoysWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 7 | IMT < 13.3)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 7 | IMT > 13.3 | IMT < 17.5)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 7 | IMT > 17.5 | IMT < 19.6)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 7 | IMT > 19.6)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 8 | IMT < 13.5)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 8 | IMT > 13.5 | IMT < 18.1)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 8 | IMT > 18.1 | IMT < 20.5)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 8 | IMT > 20.5)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 9 | IMT < 13.9)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 9 | IMT > 13.9 | IMT < 18.9)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 9 | IMT > 18.9 | IMT < 21.9)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 9 | IMT > 21.9)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 10 | IMT < 14)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 10 | IMT > 14 | IMT < 19.5)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 10 | IMT > 19.5 | IMT < 23)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 10 | IMT > 23)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                #endregion
            }
        }
    }
}
