﻿using System;
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
    /// Logika interakcji dla klasy CounterPartyListWindowView.xaml
    /// </summary>
    public partial class CounterPartyListWindowView : Window
    {
        public CounterPartyListWindowView()
        {
            InitializeComponent();
        }
        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            NewCounterpartyView newCounterparty = new NewCounterpartyView();
            newCounterparty.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            newCounterparty.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
