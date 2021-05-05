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
            doubleAnimation.To = 600;
            doubleAnimation.Duration = TimeSpan.FromSeconds(2);
            Cont_Button.BeginAnimation(Button.WidthProperty, doubleAnimation);
        }

        private void Button_Continue_Girls_Click(object sender, RoutedEventArgs e)
        {
            string WeightGirls = WeightGirlsBox.Text.Trim();
            string HeightGirls = HeightGirlsBox.Text.Trim();
            string AgeGirls = AgeGirlsBox.Text.Trim();
            double a;
            bool flag;
            flag = double.TryParse(WeightGirls, out a);
            double b;
            flag = double.TryParse(HeightGirls, out b);
            int c;
            flag = int.TryParse(AgeGirls, out c);
            if (a <= 0)
            {
                WeightGirlsBox.ToolTip = "Заповніть поле, або введіть коректні дані!";
                WeightGirlsBox.Background = Brushes.Red;
            }
            else if (b <= 0)
            {
                HeightGirlsBox.ToolTip = "Заповніть поле, або введіть коректні дані!";
                HeightGirlsBox.Background = Brushes.Red;
            }
            else if(c <= 0)
            {
                AgeGirlsBox.ToolTip = "Заповніть поле, або введіть коректні дані!";
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
                    menuForGirlsWindow.textBox2.Text = "Cніданок:\nРис на молоці 100 гр, чай 50 - 100 мл, скибочка хліба\n\nОбід:\nОвочевий суп 100 мл, гречка з м’ясом або рибою 100 гр, печиво 2 шт\n\nВечеря:\nОвочеве пюре з м’ясом 100 гр, грудне молоко або дитяча суміш";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 1 | IMT > 14.5 | IMT < 18)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nГречка на молоці 100 гр, чай 50-100 мл, скибочка хліба\n\nОбід:\nОвочевий суп 50 мл, пшенична каша з м’ясом або рибою 100 гр\n\nВечеря:\nГрудне молоко або дитяча суміш";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 1 | IMT > 18 | IMT < 20)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Cніданок:\nМолочна каша 150 г, сік 100 мл\n\nОбід:\nСуп з 2 фрикадельками 50 мл, каша 70 г, риба 50 г\n\nВечеря:\nЯблучний мус 50 г, молоко 100 г, хліб 20 г, печиво 20 г";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 1 | IMT > 20)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Cніданок:\nМолоко 100 мл, творог  50 г\n\nОбід:\nСуп 50 мл, хліб  20 г, сік 100 мл\n\nВечеря:\nКефір 100 мл, фрукти 50 г";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 2 | IMT < 14)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Cніданок:\nМанна каша 200 г, чай 100 мл, бутерброд з сиром \n\nОбід:\nСалат 40 г, борщ 150 мл, риба 80 г, сік 100 мл\n\nВечеря:\nБанан 1 шт, кефір з печивом, яйце круто зварене";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 2 | IMT > 14 | IMT < 17.2)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Cніданок:\nСирники зі сметаною 100 г, чай 100 мл\n\nОбід:\nСалат 100 г, молоко 100 мл, суп з фрикадельками 100 мл, хліб 40 г\n\nВечеря:\nЗапечене яблуко  1 шт, рисова запіканка 100 г, чай 100 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 2 | IMT > 17.2 | IMT < 19)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Cніданок:\nКаша вівсяна з яблуками 100 г, чай 150 мл\n\nОбід:\nСуп-пюре гарбузове 100 г, хліб 40 г, компот 100 мл\n\nВечеря:\nРисова каша з курагою 100 г, чай 100 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 2 | IMT > 19)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Cніданок:\nБутерброд з сиром , чай 150 мл\n\nОбід:\nСуп з кабачками 150 мл, м’ясна котлета 1 шт, сік 150 мл\n\nВечеря:\nКефір 150 мл, печиво 15 г";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 3 | IMT < 14)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Cніданок:\nВівсяна каша з фруктами 250 г, хліб з маслом 30г/10 г , молоко 250 мл\n\nОбід:\nБорщ 250 мл, рис 250 г, яблучний компот 200 мл, хліб 100 г, салат 200 г\n\nВечеря:\nКартопляна запіканка з капустою 200 г, хліб 40 г, настій шипшини 150 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 3 | IMT > 14 | IMT < 17)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Cніданок:\nОмлет 50 г, молочна гречана каша 200 г, какао з молоком 150 мл\n\nОбід:\nБульйон з локшиною 200 мл, овочеве рагу 110 г, тушкована яловичина 70 г, компот 150 мл\n\nВечеря:\nГречана каша 150 г, тушкована печінка 50 г, хліб 40 г, кисіль 150 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 3 | IMT > 17 | IMT < 18.1)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Cніданок:\nМанна каша 200г, какао з молоком 150 г\n\nОбід:\nБорщ 150 мл, котлета 70 г, салат з огірка і помідора 70 г, вода 200 мл\n\nВечеря:\nКефір 150 мл, печиво 20 г";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 3 | IMT > 18.1)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Cніданок:\nХліб з сиром 30/10 г, чай 150 мл\n\nОбід:\nБорщ 150 мл, кефір 150 мл\n\nВечеря:\nТушковані овочі 150 г, молоко 150 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 4 | IMT < 13.3)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nПшенична молочна каша 300 г, чай з медом 200 мл, хліб з маслом \n\nОбід:\nСуп-пюре з цвітної капусти 250 мл, кролик в сметані 120 г , рис 130 г, гарбузовий кисіль 150 мл, хліб \n\nВечеря:\nКартопляно-гарбузова запіканка 250 г, чай з молоком 250 мл, хліб 60 г";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 4 | IMT > 13.3 | IMT < 17)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nМанна каша з ягодами 150 г, омлет 100 г, цикорій з молоком 150 мл\n\nОбід:\nСалат з картоплі 50 г, борщ 250 мл, рибна котлета 80 г, овочеве рагу 130 г, персиковий сік 150 мл\n\nВечеря:\nСирний пудинг 200 г, чай з медом 150 мл, хліб 40 г";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 4 | IMT > 17 | IMT < 18)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nСирники з яблуком 150 г, чай з молоком 200 мл\n\nОбід:\n Картопляний суп 200 мл, гречана каша 150 г, томатний сік 150  мл\n\nВечеря:\nОмлет з молоком 80 г , чай 150 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 4 | IMT > 18)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nВівсяна каша з родзинками та горіхами 150 г, чай 200 мл\n\nОбід:\nБорщ 150 мл, гречана каша 100 г, салат з огірка та помідора 50 г, сік 200 мл\n\nВечеря:\nЗапечене яблуко 100 г, молоко 150 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 5 | IMT < 13.2)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nМюслі з сухофруктами 250 г, хліб з маслом, чай з медом 200 мл\n\nОбід:\nСалат із зеленого горошку 100 г, борщ зелений 300 мл, запечена риба 100 г, тушкована капуста 130 г, виноградний сік 150 мл\n\nВечеря:\nКартопляні зрази з печінкою  200 г, молоко 150 мл, хліб 90 г";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 5 | IMT > 13.2 | IMT < 17)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nМорквяно-сирна запіканка 150 г, хліб з маслом, чай з медом 150 мл\n\nОбід:\nОвочевий суп 250 мл, смажена печінка з цибулею 150 г, відварена цвітна капуста 130 г, салат 150 г, сік яблучний 200 мл\n\nВечеря:\nГречана молочна каша 150 г, молоко 150 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 5 | IMT > 17 | IMT < 18.2)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nЯчна молочна каша 150 г, чай 150 мл\n\nОбід:\nСалат з буряка 100 г, бульйон 150 мл, вишневий кисіль 150 мл\n\nВечеря:\nВівсяне печиво 50г, молоко 100 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 5 | IMT > 18.2)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nТерте яблуко з морквою та цукром 100 г, чай 150 мл\n\nОбід:\nКартопляний суп 200 мл, хліб 40 г, сік 150 мл\n\nВечеря:\nЗапечене яблуко, молоко 100 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 6 | IMT < 13.2)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nСирники з яблуком та сметаною 300 г, чай з молоком 200 мл, хліб з маслом\n\nОбід:\nБорщ 300 мл, гречана каша 200 г, відварене м’ясо 70 г, чай 150 мл\n\nВечеря:\n Тушені овочі 200 г, яблуко, печиво 40 г, молоко 150 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 6 | IMT > 13.2 | IMT < 17.1)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nВівсяна каша з родзинками і горіхами 250 г, чай з варенням 150/50, обід овочевий суп 300 мл, пшенична каша 150 мл, риба 40 г, сік 150 мл\n\nОбід:\nБорщ 300 мл, гречана каша 200 г, відварене м’ясо 70 г, чай 150 мл\n\nВечеря:\nСирне печиво 50 г, ряжанка 100 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 6 | IMT > 17.1 | IMT < 18.9)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nВівсяна каша з ягодами 150 г, чай 150 мл\n\nОбід:\nМакаронно-м’ясна запіканка 150 г, овочевий суп 250 мл, сік 100 мл\n\nВечеря:\nЯблуко, печиво 40 г";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 6 | IMT > 18.9)
                {
                    MenuForGirlsWindow menuForBoysWindow = new MenuForGirlsWindow();
                    menuForBoysWindow.textBox2.Text = "Сніданок:\nТворог з бананом 200 г, чай з молоком 150 мл\n\nОбід:\nСуп з фрикадельками 200 мл, рибна котлета 50 г, сік яблучний 150 мл\n\nВечеря:\nСалат фруктовий 100 г, йогурт 150 мл";
                    menuForBoysWindow.Show();
                    Hide();
                }
                else if (c != 7 | IMT < 13.3)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\n Омлет з овочами 150 г, каша вівсяна на молоці 200 г, яблуко 1 шт, чай 150 мл\n\nОбід:\n Овочевий салат 150 г, суп курячий з домашньою локшиною 150 мл, кролик в сметані 80 / 20, компот100 мл\n\nВечеря:\nРиба відварена 70 г, овочеве рагу 200 г, кефір 150 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 7 | IMT > 13.3 | IMT < 17.5)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nРисова молочна каша з родзинками 300 г, какао 200 мл, бутерброд 100 г\n\nОбід:\nСалат з буряка 100 г, бульйон з яйцем 300 мл, биточки з яловичини 100 г, тушкована капуста з кабачками 200 г, яблучний сік 200 мл, хліб 75 г\n\nВечеря:\nМлинці з сиром та родзинками 300 г, молоко 200 мл, хліб 75 г";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 7 | IMT > 17.5 | IMT < 19.6)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nВівсяна каша з ягодами 250 г, какао 200 мл, бутерброд 50 г\n\nОбід:\nСалат з яблука і моркви зі сметаною 100 г, бульйон з локшиною 250 мл, бефстроганов з тушкованими овочами 200 г, компот з винограду та яблук 200 мл, хліб 50г\n\nВечеря:\nКартопляні котлети зі сметаною 200 г, молоко 200 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 7 | IMT > 19.6)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nГречана каша 200 г, м’ясо 50 г, чай 150 мл\n\nОбід:\nОвочевий суп 200 мл, відварена картопля 150 г, компот 200 мл\n\nВечеря:\nПарова котлета 40 г, відварна цвітна капуста 100 г, чай 150 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 8 | IMT < 13.5)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nБулгур 300 г, чай 200мл\n\nОбід:\nОвочевий салат 100 г, борщ зелений 300 г, гречана каша з м’ясом 300/100 г, сік вишневий 200 мл\n\nВечеря:\nТворог 300 г, кефір 200 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 8 | IMT > 13.5 | IMT < 18.1)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nОмлет з сиром 300 г, рибна котлета 150 г, чай 200 мл, бутерброд 100 г\n\nОбід:\nБаклажанна ікра 100 г, картопляний суп з галушками 300 мл, тушкована печінка 100 г, кукурудзяна каша 200 г, фруктовий кисіль 200 мл, хліб 75 г\n\nВечеря:\nМлинці з сиром та родзинками 300 г, молоко 200 мл, хліб 75 г, запечене яблуко 100 г";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 8 | IMT > 18.1 | IMT < 20.5)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nКаша гречана з молоком 200 г, компот з яблук 150 мл\n\nОбід:\nБорщ 100 мл, тушкована картопля з овочами 150/100 г\n\nВечеря:\nОвочевий салат 150 г, кисіль 100 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 8 | IMT > 20.5)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nОмлет з відвареною морквою 150 г, чай шипшини 150 мл\n\nОбід:\nОкрошка овочева 200 мл, сік 150 мл, хліб 30 г\n\nВечеря:\nВівсяна каша 100г, чай 150 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 9 | IMT < 13.9)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nЗварені яйця 2 шт, бутерброд з сиром 2 шт, чай 200 мл\n\nОбід:\nКурячий суп 300 мл, відварна картопля 200 г, сік 150 мл\n\nВечеря:\nЗапечене з овочами м’ясо 250 г, салат 200 г, хліб 60 г, чай 150 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 9 | IMT > 13.9 | IMT < 18.9)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nГречка на молоці 300 г, бутерброд з сиром , чай 200 мл\n\nОбід:\nБорщ 300 мл, плов 200 г, яблуко, сік 200 мл\n\nВечеря:\nТворожна запіканка 150 г, молоко 150 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 9 | IMT > 18.9 | IMT < 21.9)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nПшоняна каша 250 г, відварене яйце, чай 150 мл\n\nОбід:\nОвочевий суп 250 мл, гречка 150 г, м’ясо 100 г, сік 200 мл\n\nВечеря:\nОвочевий салат 100 г, риба 50 г, хліб 40 г, чай 150 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 9 | IMT > 21.9)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nОмлет з овочами 200 г, чай 200 мл\n\nОбід:\nНежирний борщ 200 мл, рис 150 г, риба 100 г, компот 150 мл\n\nВечеря:\nЛіниві голубці 100 г, чай 200 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 10 | IMT < 14)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nОмлет з помідорами та ковбасою 200 г, бутерброд 3 шт, сік 300 мл\n\nОбід:\nРис з м’ясом 300 г, салат 200г, котлета 150 г, печиво 4 шт, сік 200 мл\n\nВечеря:\nЗапечена тріска 300 г, молоко 200 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 10 | IMT > 14 | IMT < 19.5)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nЗварені яйця 3 шт, бутерброд з сиром, омлет 200 г, чай 150 мл\n\nОбід:\nКурячий суп із рисом 300 мл, картопля 150 г, котлета 150 г, печиво 150 г, сік 300 мл\n\nВечеря:\nФарширований перець 250 г, чай 200 мл";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 10 | IMT > 19.5 | IMT < 23)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nРисова каша 200 г, гуляш 100 мл, чай 150 мл\n\nОбід:\nОвочеве рагу 150 г, суп 200 мл, м’ясо на пару 100 г, чай 200 мл\n\nВечеря:\nВідварені овочі 150 г, хліб 50 г, чай 200 г";
                    menuForGirlsWindow.Show();
                    Hide();
                }
                else if (c != 10 | IMT > 23)
                {
                    MenuForGirlsWindow menuForGirlsWindow = new MenuForGirlsWindow();
                    menuForGirlsWindow.textBox2.Text = "Сніданок:\nПшенична каша 150 г, відварене яйце 2 , чай 200 мл\n\nОбід:\nОвочевий суп 250 мл, котлета 100 г, чай 200 мл, сир 150 г, сік 200 мл\n\nВечеря:\nЛіниві голубці 100 г, чай 200 мл";
                    menuForGirlsWindow.Show();
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
            App.Current.Shutdown();
        }
        private void ToolBar_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
    }
}
