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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace zadanie_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(polA.Text);
            int n = Convert.ToInt32(polB.Text);
            if(n>0)
            {

                double a2 = 1;
                double summ = 1;
                for (int i = 1; i <= n; ++i)
                {
                    a2 = a2 * a * (-1);
                    summ = summ + a2;
                }
                Otv.Content = "Ответ: " + summ;
            }
            else
            {
                Otv.Content = $"Число меньше нуля";
            }
        }
    }
}
