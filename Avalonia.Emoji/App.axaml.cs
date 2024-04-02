using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Emoji.ViewModels;
using Avalonia.Emoji.Views;
using Avalonia.Markup.Xaml;

namespace Avalonia.Emoji
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
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

            base.OnFrameworkInitializationCompleted();
        }
    }
}