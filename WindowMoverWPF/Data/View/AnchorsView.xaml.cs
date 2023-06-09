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
using WindowMoverWPF.Data.ViewModel;

namespace WindowMoverWPF.Data.View
{
    /// <summary>
    /// Interaction logic for AnchorsView.xaml
    /// </summary>
    public partial class AnchorsView : UserControl
    {
        public AnchorsView()
        {
            InitializeComponent();
        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            AnchorsViewModel viewModel = (AnchorsViewModel)this.DataContext;
            viewModel.AnchorsViewCommand.Execute(sender);
        }
    }
}
