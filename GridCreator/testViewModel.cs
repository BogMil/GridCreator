using System.Windows;
using System.Windows.Input;

namespace GridCreator
{
    class testViewModel
    {
        public ICommand TestCommand { get; set; }

        public testViewModel()
        {
            TestCommand = new testCommand(exec,canExec);
        }

        public bool canExec(object parameter)
        {
            return true;
        }

        public void exec(object parameter)
        {
            //MessageBox.Show("Prosao test");
            var test = ShowWizardForGridCreation.Instance;
            test.test();
        }
    }
}
