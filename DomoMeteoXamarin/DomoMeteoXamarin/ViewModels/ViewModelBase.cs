using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DomoMeteoXamarin.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {


        public void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handle = PropertyChanged;
            if (handle != null)
                handle(this, new PropertyChangedEventArgs(propertyName));
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
