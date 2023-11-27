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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для FivePage.xaml
    /// </summary>
    public partial class FivePage : Page
    {
        public FivePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            answer.Clear();
            if (!int.TryParse(textbox1.Text, out int x))
            {
                MessageBox.Show("Поле А только число!");
            }
            else
            {
                int k = 1, d = 10, s = 10;
                while (s <= 200)
                {
                    ++k;
                    d += d * x / 100;
                    s += d;
                }

                answer.Text += $"суммарный пробег лыжника за все дни превысит 200 км в {d} день \n суммарный пробег = {s}";
            }
        }
    }
}
