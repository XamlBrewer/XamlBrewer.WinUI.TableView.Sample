using Microsoft.UI.Xaml;
using XamlBrewer.WinUI.TableView.Sample;
using XamlBrewer.WinUI.Services;

namespace XamlBrewer.WinUI.TableView.Sample
{
    public partial class App : Application
    {
        private Shell shell;

        public App()
        {
            InitializeComponent();
        }

        internal INavigation Navigation => shell;

        internal UIElement AppRoot => shell.AppRoot;

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            shell = new Shell();
            shell.Activate();
        }
    }
}
