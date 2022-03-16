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

namespace Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int CounterValue { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            CounterValue++;
            CounterTextBlock.Text = "Counter: " + CounterValue;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextFieldValueBlock.Text = "Textfield value: " + ((TextBox)sender).Text;
        }
    }
}
