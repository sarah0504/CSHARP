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
using WpfApplication3.View;

namespace WpfApplication3.Views
{
    /// <summary>
    /// Logique d'interaction pour UserControl6.xaml
    /// </summary>
    public partial class LoginV : UserControl
    {
      
            LoginViewModel myloginvm { get; set; }

            public LoginV()
            {
                InitializeComponent();
                myloginvm = new LoginViewModel(this);
                this.DataContext = myloginvm;
            
            }

      
    }
}
