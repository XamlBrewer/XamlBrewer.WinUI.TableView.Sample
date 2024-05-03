using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml.Media;
using System.ComponentModel.DataAnnotations;

namespace XamlBrewer.WinUI.Models
{
    public partial class Particle : ObservableObject
    {
        [ObservableProperty]
        private string group;

        [ObservableProperty]
        private string type;

        [ObservableProperty]
        public string name;

        [ObservableProperty]
        public string symbol;

        [ObservableProperty]
        public string spin;

        [ObservableProperty]
        public double mass;

        [ObservableProperty]
        public string charge;

        [Display(AutoGenerateField = false)]
        public Brush Color => new SolidColorBrush(StandardModel.GetColor(Type));
    }
}
