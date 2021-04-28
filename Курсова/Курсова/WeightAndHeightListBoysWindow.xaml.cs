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
    /// Логика взаимодействия для WeightAndHeightListBoysWindow.xaml
    /// </summary>
    public partial class WeightAndHeightListBoysWindow : Window
    {
        public WeightAndHeightListBoysWindow()
        {
            InitializeComponent();

            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = 0;
            doubleAnimation.To = 600;
            doubleAnimation.Duration = TimeSpan.FromSeconds(2);
            Continue_Button.BeginAnimation(Button.WidthProperty, doubleAnimation);
        }

        private void Button_Continue_Boys_Click(object sender, RoutedEventArgs e)
        {
            string WeightBoys = WeightBoysBox.Text.Trim();
            string HeightBoys = HeightBoysBox.Text.Trim();
            string AgeBoys = AgeBoysBox.Text.Trim();
            double a = double.Parse(WeightBoys);
            double b = double.Parse(HeightBoys);
            int c = int.Parse(AgeBoys);
            if (a <= 0)
            {
                WeightBoysBox.ToolTip = "Це поле введено не коректно";
                WeightBoysBox.Background = Brushes.Red;
            }
            else if (b <= 0)
            {
                HeightBoysBox.ToolTip = "Це поле введено не коректно";
                HeightBoysBox.Background = Brushes.Red;
            }
            else if (c <= 0)
            {
                AgeBoysBox.ToolTip = "Це поле введено не коректно";
                AgeBoysBox.Background = Brushes.Red;
            }
            else
            {
                WeightBoysBox.ToolTip = "";
                WeightBoysBox.Background = Brushes.Transparent;
                HeightBoysBox.ToolTip = "";
                HeightBoysBox.Background = Brushes.Transparent;
                AgeBoysBox.ToolTip = "";
                AgeBoysBox.Background = Brushes.Transparent;

                double IMT;
                IMT = a / (b * b);
                #region Харчування
                if (c != 1 | IMT < 17)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text =" Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони" ;
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 1 | IMT>17 | IMT<19)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 1 | IMT > 19 | IMT < 20)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 1 | IMT > 20 )
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 2 | IMT < 15)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 2 | IMT > 15 | IMT < 18)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 2 | IMT > 18 | IMT < 19)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 2 | IMT > 19)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 3 | IMT < 14.5)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 3 | IMT > 14.5 | IMT < 17.5)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 3 | IMT > 17.5 | IMT < 18.5)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 3 | IMT >18.5)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 4 | IMT < 14.3)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 4 | IMT > 14.3 | IMT < 17.6)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 4 | IMT > 17.6 | IMT < 19)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 4 | IMT >19)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 5 | IMT < 14.2)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 5 | IMT > 14.2 | IMT < 18)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 5 | IMT > 18 | IMT < 19.7)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 5 | IMT > 19.7)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 6 | IMT < 14.6)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 6 | IMT > 14.6 | IMT < 18.5)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 6 | IMT > 18.5 | IMT < 20.5)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 6 | IMT > 20.5)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 7 | IMT < 14.8)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 7 | IMT > 14.8 | IMT < 19.1)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 7 | IMT > 19.1 | IMT < 21.5)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 7 | IMT > 21.5)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 8 | IMT < 14.9)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 8 | IMT > 14.9 | IMT < 20)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 8 | IMT > 20 | IMT < 22.7)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 8 | IMT > 22.7)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 9 | IMT < 15)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 9 | IMT > 15 | IMT < 21)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 9 | IMT > 21 | IMT < 24)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 9 | IMT > 24)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 10 | IMT < 15.5)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 10 | IMT > 15.5 | IMT < 21.8)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 10 | IMT > 21.8 | IMT < 25.1)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 10 | IMT > 25.1)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                #endregion
            }
        }
    }
}
