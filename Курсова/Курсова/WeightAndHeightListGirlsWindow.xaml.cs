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
    /// Логика взаимодействия для WeightAndHeightListGirlsWindow.xaml
    /// </summary>
    public partial class WeightAndHeightListGirlsWindow : Window
    {
        public WeightAndHeightListGirlsWindow()
        {
            InitializeComponent();
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

                if (c != 1 | IMT < 17)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 1 | IMT > 17 | IMT < 19)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 1 | IMT > 19 | IMT < 20)
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
                else if (c != 2 | IMT < 15)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 2 | IMT > 15 | IMT < 18)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 2 | IMT > 18 | IMT < 19)
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
                else if (c != 3 | IMT < 14.5)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 3 | IMT > 14.5 | IMT < 17.5)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 3 | IMT > 17.5 | IMT < 18.5)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 3 | IMT > 18.5)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 4 | IMT < 14.3)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 4 | IMT > 14.3 | IMT < 17.6)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 4 | IMT > 17.6 | IMT < 19)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 4 | IMT > 19)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 5 | IMT < 14.2)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 5 | IMT > 14.2 | IMT < 18)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 5 | IMT > 18 | IMT < 19.7)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 5 | IMT > 19.7)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 6 | IMT < 14.6)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 6 | IMT > 14.6 | IMT < 18.5)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 6 | IMT > 18.5 | IMT < 20.5)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 6 | IMT > 20.5)
                {
                    MenuForGirlsWindow menuForBoysWindow = new MenuForGirlsWindow();
                    menuForBoysWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 7 | IMT < 14.8)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 7 | IMT > 14.8 | IMT < 19.1)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 7 | IMT > 19.1 | IMT < 21.5)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 7 | IMT > 21.5)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 8 | IMT < 14.9)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 8 | IMT > 14.9 | IMT < 20)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 8 | IMT > 20 | IMT < 22.7)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 8 | IMT > 22.7)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 9 | IMT < 15)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 9 | IMT > 15 | IMT < 21)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 9 | IMT > 21 | IMT < 24)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 9 | IMT > 24)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 10 | IMT < 15.5)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 10 | IMT > 15.5 | IMT < 21.8)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 10 | IMT > 21.8 | IMT < 25.1)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 10 | IMT > 25.1)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = " Не сніданок: cмажена картопля\n\nОбід: борщик\n\nВечеря: макарони";
                    menuForGirlsWindow.Show();
                    Hide();
                }
            }
        }
    }
}
