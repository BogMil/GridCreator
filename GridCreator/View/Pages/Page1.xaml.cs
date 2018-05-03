using System;
using System.Windows.Controls;

namespace GridCreator.View.Pages
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class Page1 : IBasePage
    {
        public Page1()
        {
            InitializeComponent();
            DataContext = JqGridModelSingletonFactory.Instance;
        }

        public void GoToNextPage(GridCreatorWindow baseWindow)
        {
            baseWindow.PageFrame.NavigationService.Navigate(new Page2());
        }

        public void GoToPreviousPage(GridCreatorWindow baseWindow)
        {
            baseWindow.PageFrame.NavigationService.Navigate(new ChoseDataSourcePage());

        }
    }
}
