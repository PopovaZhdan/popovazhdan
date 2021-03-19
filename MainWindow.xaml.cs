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

namespace popovazhdan
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        BazaSSEntities2 context = new BazaSSEntities2();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnReg(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            this.Hide();
            window1.Show();
        }

        private void logbox_GotFocus(object sender, RoutedEventArgs e)
        {
            logBox.Clear();
        }

        private void passbox_GotFocus(object sender, RoutedEventArgs e)
        {
            passBox.Clear();
        }

        private void BtnOpen(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            string loginTextBox = logBox.Text;
            string passTextBox = passBox.Text;
            string loginbaza = context.Registration.Where(i => i.login == loginTextBox).Select(h => h.login).FirstOrDefault();
            if (loginbaza != null)
            {
                string passBaza = context.Registration.Where(i => i.password == passTextBox).Select(h => h.password).FirstOrDefault();
                if (passBaza == passTextBox)
                {
                    Window2 window2 = new Window2();
                    this.Hide();
                    window2.Show();
                }
                else
                {
                    MessageBox.Show("Вы ввели неверный пароль!");
                }

            }
            else
            {
                MessageBox.Show("Такого пользователя не существует!  Зарегестрируйтесь!!!");
            }

        }

        private void BtnClose(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
