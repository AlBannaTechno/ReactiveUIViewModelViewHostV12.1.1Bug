using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace FirstFix
{
    public class SubLayoutViewModel : ReactiveObject
    {
        [Reactive] public string Text { get; set; } = "Osama Al Banna";
    }
}
