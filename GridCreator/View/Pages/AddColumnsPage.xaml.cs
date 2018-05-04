using GridCreator.Model;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace GridCreator.View.Pages
{
    /// <summary>
    /// Interaction logic for AddCollumnsPage.xaml
    /// </summary>
    public partial class AddColumnsPage : IBasePage
    {
        public AddColumnsPage()
        {
            DataContext = JqGridModelSingletonFactory.Instance;
            InitializeComponent();
        }

        public void GoToNextPage(GridCreatorWindow baseWindow)
        {
            throw new NotImplementedException();
        }

        public void GoToPreviousPage(GridCreatorWindow baseWindow)
        {
            throw new NotImplementedException();
        }

        private void SizeChangedTest(object sender, System.Windows.SizeChangedEventArgs e)
        {
            var header = e.OriginalSource as GridViewColumnHeader;
          
            if (header.Column.ActualWidth < 100)
            {
                header.Column.Width = 100;
            }
            if (header.Column.ActualWidth > 500)
            {
                header.Column.Width = 500;
            }
        }

        private void test(object sender, System.Windows.RoutedEventArgs e)
        {
            var test = new AddColumnWindow();
            test.ShowDialog();
        }

        private void DisplaySelected(object sender, System.Windows.RoutedEventArgs e)
        {
            var test = listOfCollumns.SelectedItem as ColumnModel;
            if(test!=null)
                MessageBox.Show(test.Label);
            else
                MessageBox.Show("You must select");
        }
    }
}
