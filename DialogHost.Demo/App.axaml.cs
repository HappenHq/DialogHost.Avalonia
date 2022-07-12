using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using DialogHostDemo.ViewModels;
using DialogHostDemo.Views;

namespace DialogHostDemo
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
            base.Initialize();
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };
            }
            else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewLifetime)
            {
                singleViewLifetime.MainView = new MainView
                {
                    DataContext = new MainWindowViewModel(),
                };
            }
            else if (ApplicationLifetime is null)
            {
                // Running in Avalonia designer/previewer process
            }
            else
            {
                throw new System.Exception($"Unsupported ApplicationLifetime {ApplicationLifetime.GetType().Name}");
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}