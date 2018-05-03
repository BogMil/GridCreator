using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GridCreator.View.Pages
{
    /// <summary>
    /// Interaction logic for BasicJqGridOptions.xaml
    /// </summary>
    public partial class BasicJqGridOptions : IBasePage
    {
        public BasicJqGridOptions()
        {
            InitializeComponent();
            DataContext = JqGridModelSingletonFactory.Instance;
        }

        public void GoToNextPage(GridCreatorWindow baseWindow)
        {
            baseWindow.PageFrame.NavigationService.Navigate(new AddColumnsPage());
        }

        public void GoToPreviousPage(GridCreatorWindow baseWindow)
        {
            baseWindow.PageFrame.NavigationService.Navigate(new ChoseDataSourcePage());
        }
    }
}
