using System;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using ReactiveUI;

namespace FirstFix
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            ViewModel = new MainWindowViewModel();
            InitializeComponent();
            this.WhenActivated(disposable =>
            {
                this.Bind(ViewModel, vm => vm.SubLayoutViewModel, v => v.SubLayoutViewModelViewHost.ViewModel)
                    .DisposeWith(disposable);
            });

        }
    }
}
