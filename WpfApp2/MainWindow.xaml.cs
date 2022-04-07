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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string log = "123";
            string pass = "123";
            if (string.IsNullOrEmpty(LOGIN.Text))
            {
                MessageBox.Show("Введите логин");
            }
            if (string.IsNullOrEmpty(PASS.Password))
            {
                MessageBox.Show("Введите пароль");
            }
            if (LOGIN.Text == log && PASS.Password == pass)
            {
                MessageBox.Show("Вы вошли");
            }
            if (LOGIN.Text != log && PASS.Password != pass)
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }
}
