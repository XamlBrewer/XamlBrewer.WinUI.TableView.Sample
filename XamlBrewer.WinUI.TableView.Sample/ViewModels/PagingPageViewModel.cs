using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamlBrewer.WinUI.Models;
using XamlBrewer.WinUI.Services;

namespace XamlBrewer.WinUI.TableView.Sample.ViewModels
{
    public partial class PagingPageViewModel : ObservableObject
    {
        private List<Particle> sourceParticles = [.. StandardModel.Particles];

        [ObservableProperty]
        private int pageSize = 5;

        [ObservableProperty]
        private int pageNumber;

        [ObservableProperty]
        private int pageCount;

        [ObservableProperty]
        private List<Particle> particles;

        public PagingPageViewModel()
        {
            FirstAsyncCommand = new AsyncRelayCommand(
                async () => await GetParticles(1, pageSize),
                () => pageNumber != 1
              );
            PreviousAsyncCommand = new AsyncRelayCommand(
                async () => await GetParticles(pageNumber - 1, pageSize),
                () => pageNumber > 1
              );
            NextAsyncCommand = new AsyncRelayCommand(
                async () => await GetParticles(pageNumber + 1, pageSize),
                () => pageNumber < pageCount
              );
            LastAsyncCommand = new AsyncRelayCommand(
                async () => await GetParticles(pageCount, pageSize),
                () => pageNumber != pageCount
              );

            Refresh();
        }

        public List<int> PageSizes => [5, 10, 20, 50, 100];

        public IAsyncRelayCommand FirstAsyncCommand { get; }

        public IAsyncRelayCommand PreviousAsyncCommand { get; }

        public IAsyncRelayCommand NextAsyncCommand { get; }

        public IAsyncRelayCommand LastAsyncCommand { get; }

        partial void OnPageSizeChanged(int value)
        {
            Refresh();
        }

        private async Task GetParticles(int pageIndex, int pageSize)
        {
            PaginatedList<Particle> pagedParticles = await PaginatedList<Particle>.CreateAsync(
                sourceParticles.OrderBy(p => p.Name).AsQueryable(),
                pageIndex,
                pageSize);
            PageNumber = pagedParticles.PageIndex;
            PageCount = pagedParticles.PageCount;
            Particles = pagedParticles;
            FirstAsyncCommand.NotifyCanExecuteChanged();
            PreviousAsyncCommand.NotifyCanExecuteChanged();
            NextAsyncCommand.NotifyCanExecuteChanged();
            LastAsyncCommand.NotifyCanExecuteChanged();
        }

        private void Refresh()
        {
            PageNumber = 0;
            FirstAsyncCommand.Execute(null);
        }
    }
}
