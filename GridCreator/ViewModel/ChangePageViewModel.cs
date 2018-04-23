using GridCreator.Commands;
using System.Windows;
using System.Windows.Input;

namespace GridCreator.ViewModel
{
    class ChangePageViewModel
    {
        public ICommand TestCommand { get; set; }
        private Window BaseWindow { get; }

        public ChangePageViewModel()
        {
            TestCommand = new testCommand(exec, canExec);
        }

        public bool canExec(object parameter)
        {
            return true;
        }

        public void exec(object parameter)
        {
            var baseWindowInstance = ShowWizardForGridCreation.BaseWindowInstance;
            var currentPage = baseWindowInstance.testFrame.Content.GetType().Name;

            MessageBox.Show(currentPage);
        }
    }
}
