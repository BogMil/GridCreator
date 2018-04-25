using GridCreator.Model;
using GridCreator.View.Pages;
using System.Windows;

namespace GridCreator.View
{
    /// <summary>
    /// Interaction logic for GridCreatorDialog.xaml
    /// </summary>
    public partial class GridCreatorWindow : Window
    {
        public static GridCreatorWindow Instance { get; set; }

        public GridCreatorWindow()
        {
            DataContext = JqGridModelSingletonFactory.Instance;
            Instance = this;

            InitializeComponent();

            PageFrame.NavigationService.Navigate(new ChoseDataSourcePage());
        }

        private void Close(object sender, System.EventArgs e)
        {
            JqGridModelSingletonFactory.setInstanceToNull();
        }
    }
}
