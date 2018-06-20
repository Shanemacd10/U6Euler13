//U6Euler13
//Shane MacDonald
//Program calculates first 10 digits of the calculated sum
//June 19, 2018
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

namespace U6Euler13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double total;
        System.IO.StreamReader streamReader = new System.IO.StreamReader("H:/euler13.txt");
        public MainWindow()
        {
            InitializeComponent();
            total += Convert.ToDouble(streamReader.ReadLine());
            string tots = total.ToString();
            tots = tots.Remove(11, tots.Length -11);
            total = Convert.ToDouble(tots) * Math.Pow(10, 10);
            MessageBox.Show(total.ToString());
        }
    }
}
