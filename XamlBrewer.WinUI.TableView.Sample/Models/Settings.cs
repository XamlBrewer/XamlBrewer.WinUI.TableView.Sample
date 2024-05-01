using CommunityToolkit.Mvvm.ComponentModel;

namespace XamlBrewer.WinUI.Models
{
    public partial class Settings : ObservableObject
    {
        [ObservableProperty]
        private bool isLightTheme;

        public Settings()
        {
            // Required for serialization.
        }
    }
}