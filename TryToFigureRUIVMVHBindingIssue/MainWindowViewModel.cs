using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace TryToFigureRUIVMVHBindingIssue
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
