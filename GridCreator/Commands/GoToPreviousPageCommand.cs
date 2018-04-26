using GridCreator.View;
using GridCreator.View.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GridCreator.Commands
{
    class GoToPreviousPageCommand : ICommand
    {
        public GridCreatorWindow _baseWindowInstance;
        public event EventHandler CanExecuteChanged;

        public GoToPreviousPageCommand(GridCreatorWindow baseWindowInstance)
        {
            _baseWindowInstance = baseWindowInstance;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var frame = _baseWindowInstance.PageFrame;
            var currentPageType = frame.Content.GetType();

            var currentPage = (IBasePage)Activator.CreateInstance(currentPageType);

            currentPage.GoToPreviousPage(_baseWindowInstance);
        }
    }
}
