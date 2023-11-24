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
using static System.Math;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для ThreePage.xaml
    /// </summary>
    public partial class ThreePage : Page
    {
        public ThreePage()
        {
            InitializeComponent();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            answer.Clear();
            if (!int.TryParse(textbox1.Text, out int x))
            {
                MessageBox.Show("Поле А только число!");
            }
            if (!int.TryParse(textbox2.Text, out int y))
            {
                MessageBox.Show("Поле А только число!");
            }
            double a, c, h, s;          
            switch (x)
            {
                case 1:
                    a = y;
                    c = a * Sqrt(2);
                    h = c / 2;
                    s = c * h / 2;
                    answer.Text += $"катет ={a}\n гипотенуза ={c}\n высота ={h}\n площадь ={s}";
                    break;
                case 2:
                    c = y;
                    a = c / Sqrt(2);
                    h = c / 2;
                    s = c * h / 2;
                    answer.Text += $"катет ={a}\n гипотенуза ={c}\n высота ={h}\n площадь ={s}";
                    break;
                case 3:
                    h = y;
                    c = 2 * h;
                    a = c / Sqrt(2);
                    s = c * h / 2;
                    answer.Text += $"катет ={a}\n гипотенуза ={c}\n высота ={h}\n площадь ={s}";
                    break;
                case 4:
                    s = y;
                    h = Sqrt(s);
                    c = 2 * h;
                    a = c / Sqrt(2);
                    answer.Text += $"катет ={a}\n гипотенуза ={c}\n высота ={h}\n площадь ={s}";
                    break;
            }
        }
    }
}
