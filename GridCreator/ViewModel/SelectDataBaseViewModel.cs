using GridCreator.Commands;
using GridCreator.View;
using GridCreator.View.Pages;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GridCreator.ViewModel
{
    class SelectDataBaseViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand PopulateComboBoxWithDatabasesCommand { get; set; }
        public ICommand HandleCredentialsFormVisibilityCommand { get; set; }


        private void onPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        private string _SqlServerName="Enter Sql Server Name";
        private string _Username="Enter username";
        private string _Password="Enter password";
        private bool _UseWindowsIdentity = false;

        public SelectDataBaseViewModel()
        {
            PopulateComboBoxWithDatabasesCommand = new CustomCommand(Populate, CanExecuteCommand);
            HandleCredentialsFormVisibilityCommand = new CustomCommand(HandleCredentialsFormVisibility, CanExecuteCommand);
        }

        public string SqlServerName
        {
            get { return _SqlServerName; }
            set
            {
                if (value != _SqlServerName)
                {
                    _SqlServerName = value;
                    onPropertyChanged("SqlServerName");
                }
            }
        }

        public string Username
        {
            get { return _Username; }
            set
            {
                if (value != _Username)
                {
                    _Username = value;
                    onPropertyChanged("Username");
                }
            }
        }

        public string Password
        {
            get { return _Password; }
            set
            {
                if (value != _Password)
                {
                    _Password = value;
                    onPropertyChanged("Password");
                }
            }
        }

        public bool UseWindowsIdentity
        {
            get { return _UseWindowsIdentity; }
            set
            {
                if (value != _UseWindowsIdentity)
                {
                    _UseWindowsIdentity = value;
                    onPropertyChanged("UseWindowsIdentity");
                    HandleCredentialsFormVisibilityCommand.Execute(null);
                }
            }
        }

        public bool CanExecuteCommand(object parameter)
        {
            return true;
        }

        public void Populate(object parameter)
        {
            var _baseWindowInstance = GridCreatorWindow.Instance;
            var frame = _baseWindowInstance.PageFrame.NavigationService.Navigate(new testPage(_SqlServerName)) ;
        }

        private void HandleCredentialsFormVisibility(object obj)
        {
            var CredentialFormStackPanel = obj as StackPanel;

            if (_UseWindowsIdentity == true)
                CredentialFormStackPanel.Visibility = Visibility.Collapsed;
            else
                CredentialFormStackPanel.Visibility = Visibility.Visible;
        }
    }
}
