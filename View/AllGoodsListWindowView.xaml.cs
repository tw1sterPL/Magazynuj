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
using System.Windows.Shapes;

namespace Magazynuj.View
{
    /// <summary>
    /// Interaction logic for AllGoodsListWindowView.xaml
    /// </summary>
    public partial class AllGoodsListWindowView : Window
    {
        public AllGoodsListWindowView()
        {
            InitializeComponent();
        }
        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            AddGoodsView addGoodsView = new AddGoodsView();
            addGoodsView.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addGoodsView.Show();
        }
    }
}
