using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Windows.UI;

namespace XamlBrewer.WinUI.Models
{
    public partial class Particle : ObservableObject
    {
        [ObservableProperty]
        private string group;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Color))]
        private string type;

        [ObservableProperty]
        private string name;

        [ObservableProperty]
        private string symbol;

        [ObservableProperty]
        private string spin;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(MassGlyph), nameof(MassText))]
        private double mass;

        [ObservableProperty]
        private string charge;

        [Display(AutoGenerateField = false)]
        public Color Color => StandardModel.GetColor(Type);

        [Display(AutoGenerateField = false)]
        public string MassGlyph => StandardModel.Glyph(Mass);

        [Display(AutoGenerateField = false)]
        public string MassText => $"{Mass} MeV/c²";
    }
}
