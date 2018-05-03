using GridCreator.View;
using GridCreator.View.Pages;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GridCreator.Commands
{
    public class GoToNextPageCommand : ICommand
    {
        public GridCreatorWindow _baseWindowInstance;
        public event EventHandler CanExecuteChanged;

        public GoToNextPageCommand(GridCreatorWindow baseWindowInstance)
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

            currentPage.GoToNextPage(_baseWindowInstance);
        }
    }
}
