using Magazynuj.View;
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

namespace Magazynuj
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

        private void OpenWindowCompanyDataView(object sender, RoutedEventArgs e)
        {
            CompanyDataView companyDataView = new CompanyDataView();
            companyDataView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            companyDataView.Show();
        }
        private void OpenWindowNewInvoiceView(object sender, RoutedEventArgs e)
        {
            NewInvoiceView newInvoiceView = new NewInvoiceView();
            newInvoiceView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            newInvoiceView.Show();
        }
        private void WindowOpenNewCounterPartyView(object sender, RoutedEventArgs e)
        {
            NewCounterpartyView newCounterPartyView = new NewCounterpartyView();
            newCounterPartyView.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            newCounterPartyView.Show();
        }
    }
}
