using GridCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GridCreator.Commands
{
    class SetAddColumnOptionCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private JqGridModel _jqGridModel;

        public SetAddColumnOptionCommand(JqGridModel jqGridModel)
        {
            _jqGridModel = jqGridModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _jqGridModel.AddColumnsOption = parameter.ToString();

        }
    }
}
