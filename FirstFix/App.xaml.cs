using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ReactiveUI;
using Splat;

namespace FirstFix
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
        }

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            Locator.CurrentMutable.Register(() => new SubLayoutView(), typeof(IViewFor<SubLayoutViewModel>));

            var mw = new MainWindow();
            App.Current.MainWindow = mw;
            mw.Show();
        }
    }
}
