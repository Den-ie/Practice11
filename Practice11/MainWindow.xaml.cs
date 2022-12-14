using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Practice11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height += 25;
        }

        private void Abbba(object sender, RoutedEventArgs e)
        {
            string a = "aa aba abba abbba abca abea";
            Regex regex = new Regex(@"ab{1,3}a");
            MatchCollection match = regex.Matches(a);

            for (int i = 0; i < match.Count; i++)
            {
                MessageBox.Show(match[i].ToString());
            }
        }

        private void Numbers(object sender, RoutedEventArgs e)
        {
            string a = "23 2+3 2++3 2+++3 445 677";
            Regex regex = new Regex(@"2\+{0,3}3");
            MatchCollection match = regex.Matches(a);

            for (int i = 0; i < match.Count; i++)
            {
                MessageBox.Show(match[i].ToString());
            }
        }
        
        private void AboutProgram(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дана строка 'aa aba abba abbba abca abea'. Напишите регулярное выражение, которое найдет строки aba, abba, abbba." +
                "\rДана строка '23 2+3 2++3 2+++3 445 677'.Напишите регулярное выражение, которое найдет строки 23, 2+3, 2++3, 2+++3, не захватив остальные.");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
