using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.IO;
using popovazhdan.Test;

namespace popovazhdan
{
     
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            
        }

        int kol;
        protected void GetAllData(string strCommand)
        {
            
        }

        private void BtnLec1(object sender, RoutedEventArgs e)
        {
            _txtBlock1.Height = 700;
            _txtBlock1.Width = 750;
            StreamReader stream = new StreamReader("C:\\Users\\WSR\\Desktop\\Lection\\1.txt");
            string relust = stream.ReadToEnd();
            _txtBlock1.Text = relust;
            kol = 1;
        }

        private void BtnLec2(object sender, RoutedEventArgs e)
        {
            _txtBlock1.Height = 700;
            _txtBlock1.Width = 750;
            StreamReader stream = new StreamReader("C:\\Users\\WSR\\Desktop\\Lection\\2.txt");
            string relust = stream.ReadToEnd();
            _txtBlock1.Text = relust;
            kol = 2;
        }

        private void BtnLec3(object sender, RoutedEventArgs e)
        {
            _txtBlock1.Height = 700;
            _txtBlock1.Width = 750;
            StreamReader stream = new StreamReader("C:\\Users\\WSR\\Desktop\\Lection\\3.txt");
            string relust = stream.ReadToEnd();
            _txtBlock1.Text = relust;
            kol = 3;
        }

        private void BtnLec4(object sender, RoutedEventArgs e)
        {
            _txtBlock1.Height = 700;
            _txtBlock1.Width = 750;
            StreamReader stream = new StreamReader("C:\\Users\\WSR\\Desktop\\Lection\\4.txt");
            string relust = stream.ReadToEnd();
            _txtBlock1.Text = relust;
            kol = 4;
        }

        private void BtnLec5(object sender, RoutedEventArgs e)
        {
            _txtBlock1.Height = 700;
            _txtBlock1.Width = 750;
            StreamReader stream = new StreamReader("C:\\Users\\WSR\\Desktop\\Lection\\5.txt");
            string relust = stream.ReadToEnd();
            _txtBlock1.Text = relust;
            kol = 5;
        }

        private void BtnLec6(object sender, RoutedEventArgs e)
        {
            _txtBlock1.Height = 700;
            _txtBlock1.Width = 750;
            StreamReader stream = new StreamReader("C:\\Users\\WSR\\Desktop\\Lection\\6.txt");
            string relust = stream.ReadToEnd();
            _txtBlock1.Text = relust;
            kol = 6;
        }

        private void BtnLec7(object sender, RoutedEventArgs e)
        {
            _txtBlock1.Height = 700;
            _txtBlock1.Width = 750;
            StreamReader stream = new StreamReader("C:\\Users\\WSR\\Desktop\\Lection\\7.txt");
            string relust = stream.ReadToEnd();
            _txtBlock1.Text = relust;
            kol = 7;
        }

        private void BtnLec8(object sender, RoutedEventArgs e)
        {
            _txtBlock1.Height = 700;
            _txtBlock1.Width = 750;
            StreamReader stream = new StreamReader("C:\\Users\\WSR\\Desktop\\Lection\\8.txt");
            string relust = stream.ReadToEnd();
            _txtBlock1.Text = relust;
            kol = 8;
        }

        private void BtnLec9(object sender, RoutedEventArgs e)
        {
            _txtBlock1.Height = 700;
            _txtBlock1.Width = 750;
            StreamReader stream = new StreamReader("C:\\Users\\WSR\\Desktop\\Lection\\9.txt");
            string relust = stream.ReadToEnd();
            _txtBlock1.Text = relust;
            kol = 9;
        }

        private void BtnLec10(object sender, RoutedEventArgs e)
        {
            _txtBlock1.Height = 700;
            _txtBlock1.Width = 750;
            StreamReader stream = new StreamReader("C:\\Users\\WSR\\Desktop\\Lection\\10.txt");
            string relust = stream.ReadToEnd();
            _txtBlock1.Text = relust;
            kol = 10;
        }

        private void BtnTest1(object sender, RoutedEventArgs e)
        {

            Test1 test1 = new Test1(kol);
            test1.Show();

        }

        private void _scroll1_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void BtnClose2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
