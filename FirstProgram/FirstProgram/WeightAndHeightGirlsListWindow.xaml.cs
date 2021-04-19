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
    /// Логика взаимодействия для WeightAndHeightGirlsListWindow.xaml
    /// </summary>
    public partial class WeightAndHeightGirlsListWindow : Window
    {
        public WeightAndHeightGirlsListWindow()
        {
            InitializeComponent();
        }

        private void Button_ContinueGirls_Click(object sender, RoutedEventArgs e)
        {
            string WeightGirls = WeightGirlsBox.Text.Trim();
            string HeightGirls = HeightGirlsBox.Text.Trim();
            int a = int.Parse(WeightGirls);
            int b = int.Parse(HeightGirls);
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
            else
            {
                WeightGirlsBox.ToolTip = "";
                WeightGirlsBox.Background = Brushes.Transparent;
                HeightGirlsBox.ToolTip = "";
                HeightGirlsBox.Background = Brushes.Transparent;
            }
        }
    }
}
