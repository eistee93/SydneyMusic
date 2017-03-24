using System.Windows;
using System.Windows.Input;

namespace SydneyMusic.ViewModel
{
    public class NotifyIconViewModel : MVVMHelper.BaseViewModel
    {
        /// <summary>
        /// Zeigt ein Fenster an, wenn noch keins geöffnet ist.
        /// </summary>
        public ICommand ShowWindowCommand
        {
            get
            {
                return new MVVMHelper.DelegateCommand(() =>
                {
                    Application.Current.MainWindow = new MainWindow();
                    Application.Current.MainWindow.Show();
                });
            }
        }

        /// <summary>
        /// Schließt die Applikation.
        /// </summary>
        public ICommand ExitApplicationCommand
        {
            get
            {
                return new MVVMHelper.DelegateCommand(() => Application.Current.Shutdown());
            }
        }
    }
}
