namespace SydneyMusic.MVVMHelper
{
    public class BaseViewModel : System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string memberName = null)
        {
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(memberName));
        }

        public void NotifyPropertyChanged<T>(ref T fieldValue, T value, [System.Runtime.CompilerServices.CallerMemberName] string memberName = null)
        {
            fieldValue = value;
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(memberName));
        }
    }
}
