using GridCreator.View;
using GridCreator.View.Pages;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GridCreator.Commands
{
    public class GoToNextPageCommand :ICommand
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

            var x = currentPage.NextPage.GetType();

            var nextPage = (Page)Activator.CreateInstance(x);


            NavigateToPage(frame, nextPage);
            //switch (currentPage)
            //{
            //    case PageNames.ChoseDataSourcePage :

            //        NavigateToPage(frame, new Page1());
            //        break;
            //    case PageNames.Page1:
            //        NavigateToPage(frame, new Page2());
            //        break;
            //}
        }

        private void NavigateToPage(Frame frame, Page page)
        {
            frame.NavigationService.Navigate(page);
        }
    }
}
