﻿using System;
using System.Windows.Input;

namespace GridCreator
{
    class testCommand : ICommand
    {
        Action<object> _executeMethod;
        Func<object, bool> _canExecuteMethod;

        public event EventHandler CanExecuteChanged;

        public testCommand(Action<object> executeMethod, Func<object, bool> canExecuteMethod)
        {
            _executeMethod = executeMethod;
            _canExecuteMethod = canExecuteMethod;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _executeMethod(parameter);
        }
    }
}
