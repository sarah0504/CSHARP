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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DAL;
using WpfApplication3.ViewModels;

namespace WpfApplication3.ViewModel2
{
    /// <summary>
    /// Logique d'interaction pour DistUserControl.xaml
    /// </summary>
    public partial class DistUserControl : UserControl
    {
        DisViewModel mydisvm;
        public DistUserControl()
        {
            InitializeComponent();
            mydisvm = new DisViewModel(this,page);
            
            listView.ItemsSource = mydisvm.GetAllDistribution();
             this.DataContext = mydisvm;
        }
    }
}
