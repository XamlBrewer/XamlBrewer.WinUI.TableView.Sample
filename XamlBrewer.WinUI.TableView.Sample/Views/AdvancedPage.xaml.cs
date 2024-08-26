using Microsoft.UI.Xaml.Controls;
using System.Linq;
using XamlBrewer.WinUI.Models;
using Ctl = WinUI.TableView.TableView;
namespace XamlBrewer.WinUI.TableView.Sample.Views
{
    public sealed partial class AdvancedPage : Page
    {
        public AdvancedPage()
        {
            InitializeComponent();
        }

        private void TableView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DeleteButton.IsEnabled = (sender as Ctl).SelectedItems.Count > 0;
        }

        private void AddButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            StandardModel.Particles.Insert(
                    0,
                    new Particle
                    {
                        Group = "boson",
                        Charge = "0",
                        Mass = 0,
                        Name = "graviton",
                        Spin = "2 ħ",
                        Symbol = "G",
                        Type = "tensor boson",
                        Hypothetical = true
                    }
            );
        }

        private void DeleteButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            foreach (var particle in ParticlesTable.SelectedItems.ToList()) // ToList() is important.
            {
                StandardModel.Particles.Remove((Particle)particle);
            }
        }

        private void UpdateButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            StandardModel.Particles[0].Name = "heart";
            StandardModel.Particles[0].Type = "lepton";
            StandardModel.Particles[0].Mass = 0;
            StandardModel.Particles[0].Symbol = "❤️";

            //ParticlesTable.ItemsSource = ParticlesTable.ItemsSource; // Force refresh ... in vain.
            //ParticlesTable.UpdateLayout(); // Force refresh ... in vain.
            //ParticlesTable.InvalidateMeasure(); // Force refresh ... in vain.
            //ParticlesTable.InvalidateArrange(); // Force refresh ... in vain.
            ParticlesTable.CollectionView.Refresh(); // Tadaa !
        }
    }
}

