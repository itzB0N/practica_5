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

namespace dop_1._1
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
            double nak = 0;
            int N = Convert.ToInt32(polA.Text);
            int K = Convert.ToInt32(polB.Text);

            if (N > 0 && K > 0)
            {
                for (int i = 1; i <= N; i++)
                {
                    nak += Math.Pow(i, K);
                }
                Otv.Content = $"Ответ: {nak}";
            }
            else
            {
                Otv.Content = $"Числа отрицательные";
            }

        }
    }
}
