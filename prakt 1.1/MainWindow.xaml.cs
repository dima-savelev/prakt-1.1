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
using Lib_13;

namespace prakt_1._1
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

        private void Start(object sender, RoutedEventArgs e)
        {
            Practice.Power(out string numbers, out string results);
            valueOut.Text = numbers;
            rezultOut.Text = results;
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Савельев Дмитрий Александрович В13\nПрактическая работа №1\n.Генерировать случайные числа Х, распределенные в диапазоне от -5 до 5 и вычислять для чисел > 0 √X , а для чисел < 0 функцию x^2. Вычисления прекратить, когда подряд появится два одинаковых случайных числа. На экран необходимо выводить сгенерированное число и результат расчета функции на разных строках", "Информация о программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            valueOut.Clear();
            rezultOut.Clear();
        }
    }
}
