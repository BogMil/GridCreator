using GridCreator.View;
using System;
using System.Windows;
using System.Windows.Input;

namespace GridCreator.Commands
{
    class HandleButtonsVisibilityCommand : ICommand
    {
        public GridCreatorWindow _baseWindowInstance;
        public event EventHandler CanExecuteChanged;

        public HandleButtonsVisibilityCommand(GridCreatorWindow baseWindowInstance)
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
            var currentPageType = frame.Content.GetType().Name;

            _baseWindowInstance.NextButton.IsEnabled = true;
            _baseWindowInstance.BackButton.IsEnabled = true;
            _baseWindowInstance.FinishButton.Visibility = Visibility.Hidden;

            if (currentPageType == PageNames.ChoseDataSourcePage)
            {
                _baseWindowInstance.BackButton.IsEnabled = false;
            }

            if (currentPageType == PageNames.Page2)
            {
                _baseWindowInstance.NextButton.IsEnabled = false;
            }
        }
    }
}
