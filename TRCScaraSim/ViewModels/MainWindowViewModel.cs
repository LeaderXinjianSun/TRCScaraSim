using Prism.Mvvm;

namespace TRCScaraSim.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "TRCScaraSim";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
