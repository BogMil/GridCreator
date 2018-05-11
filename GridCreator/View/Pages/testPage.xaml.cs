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
    /// Interaction logic for testPage.xaml
    /// </summary>
    public partial class testPage : UserControl
    {
        public testPage(string test)
        {
            InitializeComponent();
            var t = new Test(test);
            DataContext = t;
        }
    }

    public class Test
    {
        public Test(string t)
        {
            test = t;
        }
        public string test { get; set; }
    }
}
