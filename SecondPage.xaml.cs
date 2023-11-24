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
    /// Логика взаимодействия для SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Page
    {
        public SecondPage()
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
            if (x < 20 || x > 69)
            {
                MessageBox.Show("От 20 до 69!");
            }
            switch (x /10)
            {
                case 2:
                   answer.Text += "двадцать ";
                    break;
                case 3:
                    answer.Text += "тридцать ";
                    break;
                case 4:
                    answer.Text += "сорок ";
                    break;
                case 5:
                    answer.Text += "пятдесят ";
                    break;
                case 6:
                    answer.Text += "шестьдесят ";
                    break;
            }
            switch (x % 10)
            {
                case 1:
                    answer.Text += "один ";
                    break;
                case 2:
                    answer.Text += "два ";
                    break;
                case 3:
                    answer.Text += "три ";
                    break;
                case 4:
                    answer.Text += "четыре ";
                    break;
                case 5:
                    answer.Text += "пять ";
                    break;
                case 6:
                    answer.Text += "шесть ";
                    break;
                case 7:
                    answer.Text += "семь ";
                    break;
                case 8:
                    answer.Text += "восемь ";
                    break;
                case 9:
                    answer.Text += "девять ";
                    break;
            }
            switch (x % 10)
            {
                case 0:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    answer.Text += "лет.\n ";
                    break;
                case 1:
                    answer.Text += "год.\n ";
                    break;
                case 2:
                case 3:
                case 4:
                    answer.Text += "года.\n ";
                    break;
            }
        }
    }
}
