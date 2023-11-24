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
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        public FirstPage()
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
            if (x < 1 || x > 12)
            {
                MessageBox.Show("От 1 до 12!");
            }
            switch (x)
            {
                case 1:
                    answer.Text += "в этом месяце 31 дней";
                    break;
                case 2:
                    answer.Text += "в этом месяце 30 дней";
                    break;
                case 3:
                    answer.Text += "в этом месяце 31 дней";
                    break;
                case 4:
                    answer.Text += "в этом месяце 30 дней";
                    break;
                case 5:
                    answer.Text += "в этом месяце 31 дней";
                    break;
                case 6:
                    answer.Text += "в этом месяце 30 дней";
                    break;
                case 7:
                    answer.Text += "в этом месяце 31 дней";
                    break;
                case 8:
                    answer.Text += "в этом месяце 31 дней";
                    break;
                case 9:
                    answer.Text += "в этом месяце 30 дней";
                    break;
                case 10:
                    answer.Text += "в этом месяце 31 дней";
                    break;
                case 11:
                    answer.Text += "в этом месяце 30 дней";
                    break;
                case 12:
                    answer.Text += "в этом месяце 31 дней";
                    break;
            }
            
                
            
        }
    }
}
