using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using XamlBrewer.WinUI.Models;

namespace XamlBrewer.WinUI.TableView.Sample.Services
{
    public class ParticleDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Regular { get; set; }
        public DataTemplate Hypothetical { get; set; }

        protected override DataTemplate SelectTemplateCore(object particle)
        {
            if (particle is Particle particle1)
            {
                if (particle1.Mass > 0)  // Dummy test
                {
                    return Regular;
                }
                else
                {
                    return Hypothetical;
                }
            }

            return Hypothetical;
        }

        protected override DataTemplate SelectTemplateCore(object particle, DependencyObject container)
        {
            if (particle is Particle particle1)
            {
                if (particle1.Hypothetical)
                {
                    return Hypothetical;
                }
                else
                {
                    return Regular;
                }
            }

            return Regular;
        }
    }
}
