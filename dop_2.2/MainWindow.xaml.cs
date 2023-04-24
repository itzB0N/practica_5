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

namespace dop_2._2
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
        private void OK_Click_1(object sender, RoutedEventArgs e)
        {
              int n = Convert.ToInt32(polA.Text);
            double nak = 0;
            for (int i = 1; i <= n; i++)
            {
                nak += 1 / Math.Pow(i, 8);
                if (Math.Abs(nak) < n)
                {
                    Otv.Content = $"a) {nak}\n";
                }
            }

            for (int i = 1; i <= n; i++)
            {
                nak += 1 / (i*(i+1));
                if (Math.Abs(nak) < n)
                {
                    Otv1.Content = $"б) {nak}";
                }
            }

            for (int i = 1; i <= n; i++)
            {
                nak += Math.Pow(-1,i) /(i * i +1);
                if (Math.Abs(nak) < n)
                {
                    Otv2.Content = $"в) {nak}";
                }
            }

            for (int i = 0; i <= n; i++)
            {
                nak += Math.Pow(-2, i) / (i * i + 1);
                if (Math.Abs(nak) < n)
                {
                    Otv3.Content = $"г) {nak}";
                }
            }

            for (int i = 1; i <= n; i++)
            {
                nak += Math.Pow(-1, i + 1) / (i * (i + 1) * (i + 2));
                if (Math.Abs(nak) < n)
                {
                    Otv4.Content = $"д) {nak}";
                }
            }

            for (int i = 0; i <= n; i++)
            {
                nak += 1 / (Math.Pow(4,i) + Math.Pow(5, i+2));
                if (Math.Abs(nak) < n)
                {
                    Otv5.Content = $"e) {nak}";
                }
            }

            }
        }
    }
}
