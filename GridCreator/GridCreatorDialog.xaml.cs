using GridCreator.Model;
using System.Windows;

namespace GridCreator
{
    /// <summary>
    /// Interaction logic for GridCreatorDialog.xaml
    /// </summary>
    public partial class GridCreatorDialog
    {
        JqGridModel context;
        public GridCreatorDialog()
        {
            InitializeComponent();
            context = new JqGridModel()
            {

            };

            testFrame.NavigationService.Navigate(new Page1(context));
            
            DataContext=context;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            testFrame.NavigationService.Navigate(new Page1(context));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            testFrame.NavigationService.Navigate(new Page2());

        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    var test = ShowWizardForGridCreation.Instance;
        //    test.test();
        //}
    }
}
