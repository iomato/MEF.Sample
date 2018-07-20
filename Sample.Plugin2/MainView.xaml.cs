﻿using Sample.Core;
using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace Sample.Plugin2
{
    [Export(typeof(IView))]
    [ExportMetadata("name", "Plugin2")]
    public partial class MainView : UserControl, IView
    {
        public MainView()
        {
            this.DataContext = new MainViewModel();
            InitializeComponent();
        }
    }
}