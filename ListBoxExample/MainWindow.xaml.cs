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
            Reports_ListBox.Items.Clear();

            foreach(KeyValuePair<string, List<ListBoxItem>> entry in reportsDictionary)
            {
                string reportKey = entry.Key;
                List<ListBoxItem> reportList = entry.Value;
                
                foreach  (ListBoxItem report in reportList)
                {
                    string reportName = report.Content.ToString();
                    if (inputString.Contains(reportName))
                    {
                        Client_ListBox.SelectedValue = reportKey;
                        Reports_ListBox.SelectedItem = report;
                    }
                    else if (inputString.Contains(reportKey))
                    {
                        Client_ListBox.SelectedItem = Client_ListBox.Items.IndexOf(reportKey);
                    }
                }
            }
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
            else
            {
                ListBoxItem emptyListBoxItem = new ListBoxItem();
                emptyListBoxItem.Content = @"(empty)";
                Reports_ListBox.Items.Add(emptyListBoxItem);
            }

        }

        private static Dictionary<string, List<ListBoxItem>> RetrieveReportsDictionary()
        {
            Dictionary<string, List<ListBoxItem>> reportsDictionary = new Dictionary<string, List<ListBoxItem>>();

            List<ListBoxItem> bankOneReports = getBankOneReports();
            List<ListBoxItem> bankTwoReports = getBankTwoReports();
            List<ListBoxItem> bankThreeReports = getBankThreeReports();
            List<ListBoxItem> bankFourReports = getBankFourReports();
            List<ListBoxItem> bankFiveReports = getBankFiveReports();
            List<ListBoxItem> bankSixReports = getBankSixReports();
            List<ListBoxItem> bankSevenReports = getBankSevenReports();

            reportsDictionary.Add("Bank 1", bankOneReports);
            reportsDictionary.Add("Bank 2", bankTwoReports);
            reportsDictionary.Add("Bank 3", bankThreeReports);
            reportsDictionary.Add("Bank 4", bankFourReports);
            reportsDictionary.Add("Bank 5", bankFiveReports);
            reportsDictionary.Add("Bank 6", bankSixReports);
            reportsDictionary.Add("Bank 7", bankSevenReports);

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
            ListBoxItem bankTwoReportNine = new ListBoxItem();
            ListBoxItem bankTwoReportTen = new ListBoxItem();

            bankTwoReportOne.Content = "Bank 2 Report 1";
            bankTwoReportTwo.Content = "Bank 2 Report 2";
            bankTwoReportThree.Content = "Bank 2 Report 3";
            bankTwoReportFour.Content = "Bank 2 Report 4";
            bankTwoReportFive.Content = "Bank 2 Report 5";
            bankTwoReportSix.Content = "Bank 2 Report 6";
            bankTwoReportSeven.Content = "Bank 2 Report 7";
            bankTwoReportEight.Content = "Bank 2 Report 8";
            bankTwoReportNine.Content = "Bank 2 Report 9";
            bankTwoReportTen.Content = "Bank 2 Report 10";

            bankTwoReports.Add(bankTwoReportOne);
            bankTwoReports.Add(bankTwoReportTwo);
            bankTwoReports.Add(bankTwoReportThree);
            bankTwoReports.Add(bankTwoReportFour);
            bankTwoReports.Add(bankTwoReportFive);
            bankTwoReports.Add(bankTwoReportSix);
            bankTwoReports.Add(bankTwoReportSeven);
            bankTwoReports.Add(bankTwoReportEight);
            bankTwoReports.Add(bankTwoReportNine);
            bankTwoReports.Add(bankTwoReportTen);

            return bankTwoReports;
        }

        private static List<ListBoxItem> getBankThreeReports()
        {
            List<ListBoxItem> bankThreeReports = new List<ListBoxItem>();

            ListBoxItem bankThreeReportOne = new ListBoxItem();
            ListBoxItem bankThreeReportTwo = new ListBoxItem();
            ListBoxItem bankThreeReportThree = new ListBoxItem();
            ListBoxItem bankThreeReportFour = new ListBoxItem();

            bankThreeReportOne.Content = "Bank 3 Report 1";
            bankThreeReportTwo.Content = "Bank 3 Report 2";
            bankThreeReportThree.Content = "Bank 3 Report 3";
            bankThreeReportFour.Content = "Bank 3 Report 4";

            bankThreeReports.Add(bankThreeReportOne);
            bankThreeReports.Add(bankThreeReportTwo);
            bankThreeReports.Add(bankThreeReportThree);
            bankThreeReports.Add(bankThreeReportFour);

            return bankThreeReports;
        }

        private static List<ListBoxItem> getBankFourReports()
        {
            List<ListBoxItem> bankFourReports = new List<ListBoxItem>();

            ListBoxItem bankFourReportOne = new ListBoxItem();

            bankFourReportOne.Content = "Bank 4 Report 1";

            bankFourReports.Add(bankFourReportOne);

            return bankFourReports;
        }

        private static List<ListBoxItem> getBankFiveReports()
        {
            List<ListBoxItem> bankFiveReports = new List<ListBoxItem>();

            ListBoxItem bankFiveReportOne = new ListBoxItem();
            ListBoxItem bankFiveReportTwo = new ListBoxItem();
            ListBoxItem bankFiveReportThree = new ListBoxItem();
            ListBoxItem bankFiveReportFour = new ListBoxItem();

            bankFiveReportOne.Content = "Bank 5 Report 1";
            bankFiveReportTwo.Content = "Bank 5 Report 2";
            bankFiveReportThree.Content = "Bank 5 Report 3";
            bankFiveReportFour.Content = "Bank 5 Report 4";

            bankFiveReports.Add(bankFiveReportOne);
            bankFiveReports.Add(bankFiveReportTwo);
            bankFiveReports.Add(bankFiveReportThree);
            bankFiveReports.Add(bankFiveReportFour);

            return bankFiveReports;

        }

        private static List<ListBoxItem> getBankSixReports()
        {
            List<ListBoxItem> bankSixReports = new List<ListBoxItem>();

            ListBoxItem bankSixReportOne = new ListBoxItem();
            ListBoxItem bankSixReportTwo = new ListBoxItem();
            ListBoxItem bankSixReportThree = new ListBoxItem();
            ListBoxItem bankSixReportFour = new ListBoxItem();
            ListBoxItem bankSixReportFive = new ListBoxItem();

            bankSixReportOne.Content = "Bank 6 Report 1";
            bankSixReportTwo.Content = "Bank 6 Report 2";
            bankSixReportThree.Content = "Bank 6 Report 3";
            bankSixReportFour.Content = "Bank 6 Report 4";
            bankSixReportFive.Content = "Bank 6 Report 5";

            bankSixReports.Add(bankSixReportOne);
            bankSixReports.Add(bankSixReportTwo);
            bankSixReports.Add(bankSixReportThree);
            bankSixReports.Add(bankSixReportFour);
            bankSixReports.Add(bankSixReportFive);

            return bankSixReports;
        }

        private static List<ListBoxItem> getBankSevenReports()
        {
            List<ListBoxItem> bankSevenReports = new List<ListBoxItem>();

            ListBoxItem bankSevenReportOne = new ListBoxItem();
            ListBoxItem bankSevenReportTwo = new ListBoxItem();

            bankSevenReportOne.Content = "Bank 7 Report 1";
            bankSevenReportTwo.Content = "Bank 7 Report 2";

            bankSevenReports.Add(bankSevenReportOne);
            bankSevenReports.Add(bankSevenReportTwo);

            return bankSevenReports;
        }
    }
}
