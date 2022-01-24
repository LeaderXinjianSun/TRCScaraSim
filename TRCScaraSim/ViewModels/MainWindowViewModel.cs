using Prism.Mvvm;
using System.Collections.Generic;
using TRCScaraSim.ViewModels.AD;
using TRCScaraSim.ViewModels.Tools;

namespace TRCScaraSim.ViewModels
{
    internal class MainWindowViewModel : BindableBase
    {
        #region 属性
        private string _title = "TRCScaraSim";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        private string version = "1.0";
        public string Version
        {
            get { return version; }
            set { SetProperty(ref version, value); }
        }
        private Tool1ViewModel _Tool1 = null;
        public Tool1ViewModel Tool1
        {
            get
            {
                if (_Tool1 == null)
                {
                    _Tool1 = new Tool1ViewModel();
                }
                return _Tool1;
            }
            set { SetProperty(ref _Tool1, value); }
        }
        private IEnumerable<ToolViewModel> _tools = null;
        public IEnumerable<ToolViewModel> Tools
        {
            get
            {
                if (_tools == null)
                {
                    _tools = new ToolViewModel[] { Tool1 };
                }
                return _tools;
            }
            set { SetProperty(ref _tools, value); }
        }
        #endregion
        #region 构造函数
        public MainWindowViewModel()
        {

        }
        #endregion
    }
}
