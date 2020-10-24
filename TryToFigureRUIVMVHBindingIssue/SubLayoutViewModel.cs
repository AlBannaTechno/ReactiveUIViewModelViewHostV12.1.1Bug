using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace TryToFigureRUIVMVHBindingIssue
{
    public class SubLayoutViewModel : ReactiveObject
    {
        [Reactive] public string Text { get; set; } = "Osama Al Banna";
    }
}
