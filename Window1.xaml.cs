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

namespace popovazhdan
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        BazaSSEntities2 context = new BazaSSEntities2();
        public Window1()
        {
            InitializeComponent();
        }

        private void nameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            nameBox.Clear();
        }

        private void snameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            snameBox.Clear();
        }

        private void reglogBox_GotFocus(object sender, RoutedEventArgs e)
        {
            reglogBox.Clear();
        }

        private void regpassBox_GotFocus(object sender, RoutedEventArgs e)
        {
            regpassBox.Clear();
        }

        private void groupBox_GotFocus(object sender, RoutedEventArgs e)
        {
            groupBox.Clear();
        }

        private void BtnReg(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();

            registration.login = nameBox.Text;
            registration.sname = snameBox.Text;
            registration.login = reglogBox.Text;
            registration.password = regpassBox.Text;
            registration.groupname = groupBox.Text;

            context.Registration.Add(registration);

            context.SaveChanges();
            MainWindow mainWindow = new MainWindow();
            this.Hide();
            mainWindow.Show();
        }

        private void BtnClose3(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
