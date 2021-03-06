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
using ConfigurationToolStructurePOC.UI.Interfaces;
using ConfigurationToolStructurePOC.UI.ViewModels;

namespace ConfigurationToolStructurePOC.UI.Views
{
    /// <summary>
    /// Interaction logic for CreateRouteWindow.xaml
    /// </summary>
    public partial class CreateRouteWindow : Window, ICreateRouteView
    {
        public CreateRouteWindow()
        {
            InitializeComponent();
            DataContext = new CreateRouteViewModel(this);
        }


        public void CloseWindow()
        {
            this.Close();
        }

        public bool ConfirmMessage(string title, string text)
        {
            throw new NotImplementedException();
        }

        public void ShowMessage(string text)
        {
            MessageBox.Show(text);
        }
    }
}
