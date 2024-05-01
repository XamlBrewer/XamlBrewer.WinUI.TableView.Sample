using Microsoft.UI.Xaml;

namespace XamlBrewer.WinUI.TableView.Sample
{
    public sealed partial class Shell : Window
    {
        public Shell()
        {
            Title = "XAML Brewer WinUI TableView Sample";

            InitializeComponent();

            AppWindow.SetIcon("Assets/Beer.ico");

            (Application.Current as App).EnsureSettings();
            ApplyTheme();
        }

        internal UIElement AppRoot => Root;

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            var settings = (Application.Current as App).Settings;
            settings.IsLightTheme = !settings.IsLightTheme;
            (Application.Current as App).SaveSettings();
            Root.ActualThemeChanged += Root_ActualThemeChanged;
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            var settings = (Application.Current as App).Settings;
            Root.RequestedTheme = settings.IsLightTheme ? ElementTheme.Light : ElementTheme.Dark;
        }
        private void Root_ActualThemeChanged(FrameworkElement sender, object args)
        {
            // Theme change refinements (e.g. content dialogs and title bar).
        }
    }
}
