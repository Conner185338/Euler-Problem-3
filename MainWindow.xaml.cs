/*
 * Conner Warboys
 * Project Euler Problem 3
 * May 12th, 2019
 * ICS3U
*/
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

namespace _185338LargestPrimeFactor
{
    /// <summary>
    /// doubleeraction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(txtPrimeNum.Text, out double num);
            double greatestNum = 0;
            double counter = 2;
            while (counter * counter <= num)
            {
                if (num % counter == 0)
                {
                    num = num / counter;
                    greatestNum = counter;
                }
                else
                {
                    counter++;
                }
            }
            if (num > greatestNum)
            {
                greatestNum = num;
            }
            lblOuput.Content = greatestNum;
        }
    }
}
