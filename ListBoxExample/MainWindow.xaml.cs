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
        private Dictionary<string, List<ListBoxItem>> reportsDictionary = RetrieveReportsDictionary();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            string inputString = Search_TextBox.Text;
            Search_TextBox.Text = String.Empty;
            MessageBox.Show(inputString);
        }

        private void Client_ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem clientSelection = ((sender as ListBox).SelectedItem as ListBoxItem);
            string currentClient = clientSelection.Content.ToString();
            Reports_ListBox.Items.Clear();

            if (reportsDictionary.ContainsKey(currentClient))
            {
                List<ListBoxItem> reportsList = reportsDictionary[currentClient];

                foreach (ListBoxItem listBoxItem in reportsList)
                {
                    Reports_ListBox.Items.Add(listBoxItem);
                }
            }

        }

        private static Dictionary<string, List<ListBoxItem>> RetrieveReportsDictionary()
        {
            Dictionary<string, List<ListBoxItem>> reportsDictionary = new Dictionary<string, List<ListBoxItem>>();

            List<ListBoxItem> bankOneReports = getBankOneReports();
            List<ListBoxItem> bankTwoReports = getBankTwoReports();

            reportsDictionary.Add("Bank 1", bankOneReports);
            reportsDictionary.Add("Bank 2", bankTwoReports);

            return reportsDictionary;
        }

        private static List<ListBoxItem> getBankOneReports()
        {
            List<ListBoxItem> bankOneReports = new List<ListBoxItem>();

            ListBoxItem bankOneReportOne = new ListBoxItem();
            ListBoxItem bankOneReportTwo = new ListBoxItem();
            ListBoxItem bankOneReportThree = new ListBoxItem();

            bankOneReportOne.Content = "Bank 1 Report 1";
            bankOneReportTwo.Content = "Bank 1 Report 2";
            bankOneReportThree.Content = "Bank 1 Report 3";

            bankOneReports.Add(bankOneReportOne);
            bankOneReports.Add(bankOneReportTwo);
            bankOneReports.Add(bankOneReportThree);

            return bankOneReports;
        }

        private static List<ListBoxItem> getBankTwoReports()
        {
            List<ListBoxItem> bankTwoReports = new List<ListBoxItem>();

            ListBoxItem bankTwoReportOne = new ListBoxItem();
            ListBoxItem bankTwoReportTwo = new ListBoxItem();
            ListBoxItem bankTwoReportThree = new ListBoxItem();
            ListBoxItem bankTwoReportFour = new ListBoxItem();
            ListBoxItem bankTwoReportFive = new ListBoxItem();
            ListBoxItem bankTwoReportSix = new ListBoxItem();
            ListBoxItem bankTwoReportSeven = new ListBoxItem();
            ListBoxItem bankTwoReportEight = new ListBoxItem();

            bankTwoReportOne.Content = "Bank 2 Report 1";
            bankTwoReportTwo.Content = "Bank 2 Report 2";
            bankTwoReportThree.Content = "Bank 2 Report 3";
            bankTwoReportFour.Content = "Bank 2 Report 4";
            bankTwoReportFive.Content = "Bank 2 Report 5";
            bankTwoReportSix.Content = "Bank 2 Report 6";
            bankTwoReportSeven.Content = "Bank 2 Report 7";
            bankTwoReportEight.Content = "Bank 2 Report 8";

            bankTwoReports.Add(bankTwoReportOne);
            bankTwoReports.Add(bankTwoReportTwo);
            bankTwoReports.Add(bankTwoReportThree);
            bankTwoReports.Add(bankTwoReportFour);
            bankTwoReports.Add(bankTwoReportFive);
            bankTwoReports.Add(bankTwoReportSix);
            bankTwoReports.Add(bankTwoReportSeven);
            bankTwoReports.Add(bankTwoReportEight);

            return bankTwoReports;
        }
    }
}
