using System.Windows;

namespace GridCreator
{
    /// <summary>
    /// Interaction logic for GridCreatorDialog.xaml
    /// </summary>
    public partial class GridCreatorDialog
    {
        public GridCreatorDialog()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var test = ShowWizardForGridCreation.Instance;
            test.test();
        }
    }
}
