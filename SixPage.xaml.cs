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
    /// Логика взаимодействия для SixPage.xaml
    /// </summary>
    public partial class SixPage : Page
    {
        public SixPage()
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
            while (x > 0 && x % 10 != 2)
            {               
                x /= 10;
            }
            if (x > 0 && x % 10 == 2)
            { answer.Text += "true" + "\n"; }
            else
            { answer.Text += "false" + "\n"; }

        }
    }
}
