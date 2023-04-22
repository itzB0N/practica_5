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
                if (Math.Abs(nak) < Math.E)
                {
                    Otv.Content = $"{nak}";
                }

            }
        }
    }
}
