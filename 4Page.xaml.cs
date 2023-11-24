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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для FourPage.xaml
    /// </summary>
    public partial class FourPage : Window
    {
        public FourPage()
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
            bool flag = false;
            if (Math.Log(x) % Math.Log(x) == 0)
                flag = true;
            else
                flag = false;
            answer.Text += flag;
        }
    }
}
