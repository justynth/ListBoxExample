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

namespace ListBoxExample
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

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            string inputString = Search_TextBox.Text;
            Search_TextBox.Text = String.Empty;
        }

        private void Client_ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string currentClient = Client_ListBox.SelectedItem.ToString();
            currentClient = currentClient.Substring(37);

            foreach (ListBoxItem listBoxItem in Reports_ListBox.Items)
            {
                listBoxItem.Visibility = Visibility.Hidden;
            }

            switch (currentClient)
            {
                case "Bank 1":
                    BankOneReportOne.Visibility = Visibility.Visible;
                    BankOneReportTwo.Visibility = Visibility.Visible;
                    break;
                /*case "Bank 2":
                    BankTwoReportOne.Visibility = Visibility.Visible;
                    break;
                */
                default:
                    break;
            }
            
        }
    }
}
