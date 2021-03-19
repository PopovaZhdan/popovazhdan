using System;
using System.Collections.Generic;
using System.IO;
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

namespace popovazhdan.Test
{
    /// <summary>
    /// Логика взаимодействия для Test1.xaml
    /// </summary>
    public partial class Test1 : Window
    {
        public Test1()
        {
            InitializeComponent();
           

        }

        public Test1(int numTest)
        {
            InitializeComponent();

            
            StreamReader stream1 = new StreamReader($"C:\\Users\\WSR\\Desktop\\Lection\\Test{numTest}\\Задание1.txt");
            string relust1 = stream1.ReadToEnd();
            tbZad1.Text = relust1;

            StreamReader stream2 = new StreamReader($"C:\\Users\\WSR\\Desktop\\Lection\\Test{numTest}\\Задание2.txt");
            string relust2 = stream2.ReadToEnd();
            tbZad2.Text = relust2;

            StreamReader stream3 = new StreamReader($"C:\\Users\\WSR\\Desktop\\Lection\\Test{numTest}\\Задание3.txt");
            string relust3 = stream3.ReadToEnd();
            tbZad3.Text = relust3;

            StreamReader stream4 = new StreamReader($"C:\\Users\\WSR\\Desktop\\Lection\\Test{numTest}\\Задание4.txt");
            string relust4 = stream4.ReadToEnd();
            tbZad4.Text = relust4;

            StreamReader otvet1 = new StreamReader($"C:\\Users\\WSR\\Desktop\\Lection\\Test{numTest}\\Ответ1.txt");
            string relust11 = otvet1.ReadToEnd();
            tbOt1.Text = relust11;
            StreamReader otvet11 = new StreamReader($"C:\\Users\\WSR\\Desktop\\Lection\\Test{numTest}\\Ответ2.txt");
            string relust111 = otvet11.ReadToEnd();
            tbOt11.Text = relust111;
            StreamReader otvet111 = new StreamReader($"C:\\Users\\WSR\\Desktop\\Lection\\Test{numTest}\\Ответ3.txt");
            string relust1111 = otvet111.ReadToEnd();
            tbOt111.Text = relust1111;
            StreamReader otvet1111 = new StreamReader($"C:\\Users\\WSR\\Desktop\\Lection\\Test{numTest}\\Ответ4.txt");
            string relust11111 = otvet1111.ReadToEnd();
            tbOt1111.Text = relust11111;

        }

      

        private void BtnClose2(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            this.Hide();
            window2.Show();
        }
    }
}
