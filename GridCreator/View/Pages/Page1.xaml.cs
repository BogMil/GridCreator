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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class Page1 : IBasePage
    {
        public Page1()
        {
            InitializeComponent();
            DataContext = JqGridModelSingletonFactory.Instance;
        }

        public String NextPage {
            get => typeof(Page2).ToString();
            set => throw new NotImplementedException(); }
    }
}
