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
                    menuForBoysWindow.textBox1.Text = " Cніданок:\nРис на молоці 100 гр, чай 50-100 мл, скибочка хліба\n\nОбід:\nОвочевий суп 100 мл, гречка з м’ясом або рибою 100 гр, печиво 2 шт\n\nВечеря:\nОвочеве пюре з м’ясом 100 гр, грудне молоко або дитяча суміш";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 1 | IMT>17 | IMT<19)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Сніданок:\nГречка на молоці 100 гр, чай 50-100 мл, скибочка хліба\n\nОбід:\nОвочевий суп 50 мл, пшенична каша з м’ясом або рибою 100 гр\n\nВечеря:\nГрудне молоко або дитяча суміш";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 1 | IMT > 19 | IMT < 20)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = "Cніданок:\nМолочна каша 150 г, сік 100 мл\n\nОбід:\nСуп з 2 фрикадельками 50 мл, каша 70 г, риба 50 г\n\nВечеря:\nЯблучний мус 50 г, молоко 100 г, хліб 20 г, печиво 20 г";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 1 | IMT > 20 )
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Cніданок:\nМолоко 100 мл, творог  50 г\n\nОбід:\nСуп 50 мл, хліб  20 г, сік 100 мл\n\nВечеря:\nКефір 100 мл, фрукти 50 г";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 2 | IMT < 15)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Cніданок:\nМанна каша 200 г, чай 100 мл, бутерброд з сиром \n\nОбід:\nСалат 40 г, борщ 150 мл, риба 80 г, сік 100 мл\n\nВечеря:\nБанан 1 шт, кефір з печивом, яйце круто зварене";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 2 | IMT > 15 | IMT < 18)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Cніданок:\nСирники зі сметаною 100 г, чай 100 мл\n\nОбід:\nСалат 100 г, молоко 100 мл, суп з фрикадельками 100 мл, хліб 40 г\n\nВечеря:\nЗапечене яблуко  1 шт, рисова запіканка 100 г, чай 100 мл";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 2 | IMT > 18 | IMT < 19)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Cніданок:\nКаша вівсяна з яблуками 100 г, чай 150 мл\n\nОбід:\nСуп-пюре гарбузове 100 г, хліб 40 г, компот 100 мл\n\nВечеря:\nРисова каша з курагою 100 г, чай 100 мл";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 2 | IMT > 19)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Cніданок:\nБутерброд з сиром , чай 150 мл\n\nОбід:\nСуп з кабачками 150 мл, м’ясна котлета 1 шт, сік 150 мл\n\nВечеря:\nКефір 150 мл, печиво 15 г";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 3 | IMT < 14.5)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Cніданок:\nВівсяна каша з фруктами 250 г, хліб з маслом 30г/10 г , молоко 250 мл\n\nОбід:\nБорщ 250 мл, рис 250 г, яблучний компот 200 мл, хліб 100 г, салат 200 г\n\nВечеря:\nКартопляна запіканка з капустою 200 г, хліб 40 г, настій шипшини 150 мл";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 3 | IMT > 14.5 | IMT < 17.5)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Cніданок:\nОмлет 50 г, молочна гречана каша 200 г, какао з молоком 150 мл\n\nОбід:\nБульйон з локшиною 200 мл, овочеве рагу 110 г, тушкована яловичина 70 г, компот 150 мл\n\nВечеря:\nГречана каша 150 г, тушкована печінка 50 г, хліб 40 г, кисіль 150 мл";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 3 | IMT > 17.5 | IMT < 18.5)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Cніданок:\nМанна каша 200г, какао з молоком 150 г\n\nОбід:\nБорщ 150 мл, котлета 70 г, салат з огірка і помідора 70 г, вода 200 мл\n\nВечеря:\nКефір 150 мл, печиво 20 г";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 3 | IMT >18.5)
                {
                    MenuForBoysWindow menuForBoysWindow = new MenuForBoysWindow();
                    menuForBoysWindow.textBox1.Text = " Cніданок:\n Хліб з сиром 30/10 г, чай 150 мл\n\nОбід:\nБорщ 150 мл, кефір 150 мл\n\nВечеря:\nТушковані овочі 150 г, молоко 150 мл";
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
        private void MinimizedButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ExitButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
