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
    /// Логика взаимодействия для WeightAndHeightListBoysWindow.xaml
    /// </summary>
    public partial class WeightAndHeightListBoysWindow : Window
    {
        public WeightAndHeightListBoysWindow()
        {
            InitializeComponent();
        }

        private void Button_Continue_Boys_Click(object sender, RoutedEventArgs e)
        {
            string WeightBoys = WeightBoysBox.Text.Trim();
            string HeightBoys = HeightBoysBox.Text.Trim();
            int a = int.Parse(WeightBoys);
            int b = int.Parse(HeightBoys);
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
            else
            {
                WeightBoysBox.ToolTip = "";
                WeightBoysBox.Background = Brushes.Transparent;
                HeightBoysBox.ToolTip = "";
                HeightBoysBox.Background = Brushes.Transparent;
            }
        }
    }
}
