using Prism.Navigation;
using Reactive.Bindings;
using System;

namespace ListViewTest.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ReactiveCommand<string> PageChangeButton { get; } = new ReactiveCommand<string>();

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            PageChangeButton.Subscribe(async x => await navigationService.NavigateAsync(x));
        }
    }
}
