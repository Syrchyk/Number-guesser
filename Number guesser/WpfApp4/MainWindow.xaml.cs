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

namespace WpfApp4
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

        private int a = 0;
        private int b = 200;

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TBNumber.Text))
            {
                TBNumber.Text = (((a = Convert.ToInt32(TBNumber.Text)) + b) / 2).ToString();
            }
        }

        private void Border_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if(String.IsNullOrWhiteSpace(TBNumber.Text))
            {
                TBNumber.Text = new Random().Next(0, 200).ToString();

            }
            else
            {
                MessageBox.Show("Congratulation");
            }
        }

        private void Border_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TBNumber.Text))
            { 

                TBNumber.Text = (((b = Convert.ToInt32(TBNumber.Text)) + a) / 2).ToString();
            }
        }
    }
}
