using System;
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
            InitializeComponent();
            DataContext = JqGridModelSingletonFactory.Instance;
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
            //GridViewColumnHeader header = senderAsThumb.TemplatedParent as GridViewColumnHeader;
            if (header.Column.ActualWidth < 100)
            {
                header.Column.Width = 100;
            }
            if (header.Column.ActualWidth > 500)
            {
                header.Column.Width = 500;
            }
        }
    }
}
