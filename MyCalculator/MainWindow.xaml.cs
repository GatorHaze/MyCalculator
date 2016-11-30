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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double mpresult { get; set; } 
        public double mrresult { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Addition_Click(object sender, RoutedEventArgs e)
        {

            double A = Convert.ToDouble(this.input1.Text);
            double B = Convert.ToDouble(this.input2.Text);
            double result = (A + B);
            this.Result.Content = result;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            double A = Convert.ToDouble(this.input1.Text);
            double B = Convert.ToDouble(this.input2.Text);
            double result = (A - B);
            this.Result.Content = result;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            double A = Convert.ToDouble(this.input1.Text);
            double B = Convert.ToDouble(this.input2.Text);
            double result = (A * B);
            this.Result.Content = result;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            double A = Convert.ToDouble(this.input1.Text);
            double B = Convert.ToDouble(this.input2.Text);
            double result = (A / B);
            this.Result.Content = result;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            double A = Convert.ToDouble(this.input1.Text);
            double B = Convert.ToDouble(this.input2.Text);
            double result = (A % B);
            this.Result.Content = result;
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            this.Result.Content = mpresult;
        }

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            this.Result.Content = mrresult;
        }
    }
}
