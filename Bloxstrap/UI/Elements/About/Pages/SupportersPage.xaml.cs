﻿using System.Windows;

using Hellstrap.UI.ViewModels.About;

namespace Hellstrap.UI.Elements.About.Pages
{
    /// <summary>
    /// Interaction logic for SupportersPage.xaml
    /// </summary>
    public partial class SupportersPage
    {
        private readonly SupportersViewModel _viewModel = new();

        public SupportersPage()
        {
            DataContext = _viewModel;
            InitializeComponent();
        }

        private void UiPage_SizeChanged(object sender, SizeChangedEventArgs e)
            => _viewModel.WindowResizeEvent?.Invoke(sender, e);
    }
}
