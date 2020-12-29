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

namespace MibbitChatToHTML
{
    /// <summary>
    /// Interaction logic for CorrectionControl.xaml
    /// </summary>
    public partial class CorrectionControl : Window 
    {
        public CorrectionControl()
        {
            InitializeComponent();
        }

        public string GetMyResult { get; internal set; }

        private void CommitEditClick(object sender, RoutedEventArgs e)
        {

            DialogResult = true;
        }
    }
}
