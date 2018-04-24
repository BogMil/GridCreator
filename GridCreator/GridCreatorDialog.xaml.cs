using GridCreator.Model;
using GridCreator.View.Pages;
using System.Windows;

namespace GridCreator
{
    /// <summary>
    /// Interaction logic for GridCreatorDialog.xaml
    /// </summary>
    public partial class GridCreatorDialog : Window
    {
        JqGridModel context;
        public GridCreatorDialog()
        {
            InitializeComponent();
            context = JqGridModelSingletonFactory.Instance;

            testFrame.NavigationService.Navigate(new ChoseDataSourcePage());

            DataContext = context;
        }

        private void Close(object sender, System.EventArgs e)
        {
            JqGridModelSingletonFactory.setInstanceToNull();
        }
    }
}
