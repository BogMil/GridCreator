using GridCreator.Model;
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
    /// Interaction logic for ChoseDataSourcePage.xaml
    /// </summary>
    public partial class ChoseDataSourcePage : IBasePage
    {
        private JqGridModel _jqGridModel;

        public ChoseDataSourcePage()
        {
            _jqGridModel = JqGridModelSingletonFactory.Instance;
            InitializeComponent();
            DataContext = JqGridModelSingletonFactory.Instance;
        }

        public void GoToNextPage(GridCreatorWindow baseWindow)
        {
            if(_jqGridModel.AddColumnsOption== "Manualy add columns and their definition")
             baseWindow.PageFrame.NavigationService.Navigate(new BasicJqGridOptions());

            if (_jqGridModel.AddColumnsOption == "Add columns from SQL Server")
                baseWindow.PageFrame.NavigationService.Navigate(new SelectDataBasePage());

        }

        public void GoToPreviousPage(GridCreatorWindow baseWindow)
        {
            return;
        }
    }
}
