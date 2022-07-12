using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using DialogHostDemo.Models;
using System;

namespace DialogHostDemo.Views
{
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void OpenDialogWithView(object? sender, RoutedEventArgs e)
        {
            DialogHost.DialogHost.Show(this.Resources["Sample3View"]!, "MainDialogHost");
        }

        private void OpenDialogWithModel(object? sender, RoutedEventArgs e)
        {
            DialogHost.DialogHost.Show(new Sample2Model(new Random().Next(0, 100)), "MainDialogHost");
        }

        private void OpenNoAnimationDialog(object? sender, RoutedEventArgs e)
        {
            DialogHost.DialogHost.Show(this.Resources["Sample2View"]!, "NoAnimationDialogHost");
        }
    }
}
