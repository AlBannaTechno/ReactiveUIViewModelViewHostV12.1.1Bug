using System.Reactive.Disposables;
using ReactiveUI;

namespace FirstFix
{
    /// <summary>
    /// Interaction logic for SubLayoutView.xaml
    /// </summary>
    public partial class SubLayoutView : ReactiveUserControl<SubLayoutViewModel>
    {
        public SubLayoutView()
        {
            InitializeComponent();
            this.WhenActivated(disposable =>
            {
                this.Bind(ViewModel, vm => vm.Text, v => v.TextBlock.Text).DisposeWith(disposable);
            });
        }
    }
}
