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
        public double mmresult { get; set; }
        public string Textbox { get; } = "0";

        public MainWindow()
        {
            InitializeComponent();
           
        }
        //trying to clear the 0 that is there already but it wont clear on a click event
        private void input1_TextChanged(object sender, TextChangedEventArgs e)
        {
            input1.Text = String.Empty;

        }
        //When you click the addition button, it will add the two entered values together
        private void Addition_Click(object sender, RoutedEventArgs e)
        {

            double A = Convert.ToDouble(this.input1.Text);
            double B = Convert.ToDouble(this.input2.Text);
            double result = (A + B);
            this.Result.Content = result;
        }
        //When you click the subtraction button, it will subtract the two entered values together
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            double A = Convert.ToDouble(this.input1.Text);
            double B = Convert.ToDouble(this.input2.Text);
            double result = (A - B);
            this.Result.Content = result;
        }
        //When you click the multiplication button, it will multiply the two entered values together
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            double A = Convert.ToDouble(this.input1.Text);
            double B = Convert.ToDouble(this.input2.Text);
            double result = (A * B);
            this.Result.Content = result;
        }
        //When you click the division button, it will divide the two entered values together
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            double A = Convert.ToDouble(this.input1.Text);
            double B = Convert.ToDouble(this.input2.Text);
            double result = (A / B);
            this.Result.Content = result;
        }
        //When you click the modulus button, it will return the absolute value of the two entered values together
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            double A = Convert.ToDouble(this.input1.Text);
            double B = Convert.ToDouble(this.input2.Text);
            double result = (A % B);
            this.Result.Content = result;
        }

        //was not able to get my level 2 memory buttons to work
        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
        private void button2_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
