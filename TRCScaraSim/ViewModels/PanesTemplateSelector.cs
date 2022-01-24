using AvalonDock.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TRCScaraSim.ViewModels.Tools;

namespace TRCScaraSim.ViewModels
{
    internal class PanesTemplateSelector : DataTemplateSelector
    {
        public PanesTemplateSelector()
        {

        }
        public DataTemplate Tool1ViewTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var itemAsLayoutContent = item as LayoutContent;
            if (item is Tool1ViewModel)
            {
                return Tool1ViewTemplate;
            }
            return base.SelectTemplate(item, container);
        }
    }
}
