using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace FirstFix
{
    public class MainWindowViewModel : ReactiveObject
    {
        [Reactive] public SubLayoutViewModel SubLayoutViewModel { get; set; }
        public MainWindowViewModel()
        {
            SubLayoutViewModel = new SubLayoutViewModel();
        }
    }
}
