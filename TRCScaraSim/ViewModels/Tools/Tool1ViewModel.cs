using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using TRCScaraSim.ViewModels.AD;
using TRCScaraSim.ViewModels.Base;

namespace TRCScaraSim.ViewModels.Tools
{
    internal class Tool1ViewModel : ToolViewModel
    {
        public const string ToolTitle = "Tool1";
        private string _TestText;
        public string TestText
        {
            get { return _TestText; }
            set
            {
                _TestText = value;
                this.RaisePropertyChanged(()=> TestText);
            }
        }
        private ICommand _TestButtonCommand;
        public ICommand TestButtonCommand
        {
            get
            {
                if (_TestButtonCommand == null)
                {
                    _TestButtonCommand = new RelayCommand(()=> 
                    {
                        MessageBox.Show($"{TestText}");
                        TestText = DateTime.Now.ToString();
                    });
                }
                return _TestButtonCommand;
            }
        }
        public Tool1ViewModel()
            :base(ToolTitle)
        {


        }
    }
}
