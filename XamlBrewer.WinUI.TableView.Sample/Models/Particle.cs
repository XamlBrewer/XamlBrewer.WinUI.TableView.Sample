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
        public Color Color => StandardModel.GetColor(Type);

        [Display(AutoGenerateField = false)]
        public string MassGlyph => StandardModel.Glyph(Mass);

        [Display(AutoGenerateField = false)]
        public string MassText => $"{Mass} MeV/c²";
    }
}
