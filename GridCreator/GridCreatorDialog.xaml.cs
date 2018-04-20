using System.Windows;

namespace GridCreator
{
    /// <summary>
    /// Interaction logic for GridCreatorDialog.xaml
    /// </summary>
    public partial class GridCreatorDialog
    {
        TestPerson context;
        public GridCreatorDialog()
        {
            InitializeComponent();
            context = new TestPerson()
            {
                Ime = "testIme",
                Prezime = "testPrezime"
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
            context.Ime = "promena";

        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    var test = ShowWizardForGridCreation.Instance;
        //    test.test();
        //}
    }

    public class TestPerson
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
    }
}
