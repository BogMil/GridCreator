using GridCreator.Commands;
using GridCreator.Model;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace GridCreator.ViewModel
{
    class AddColumnViewModel : INotifyPropertyChanged
    {
        private JqGridModel _JqGridModelInstance;
        private ColumnModel _Column;

        public ICommand AddColumnCommand { get; set; }
        public ICommand DeleteColumnCommand { get; set; }

        public AddColumnViewModel()
        {
            _JqGridModelInstance = JqGridModelSingletonFactory.Instance;
            _Column = new ColumnModel() { ColumnName = "testColumnNameeeee", Label = "testLabelllll", ID=0 };
            AddColumnCommand = new CustomCommand(AddColumn, CanAddColumn);
            DeleteColumnCommand = new CustomCommand(DeleteColumn, CanDeleteColumn);
        }

        public ColumnModel Column
        {
            get => _Column;
            set
            {
                _Column = value;
            }
        }

        public bool CanAddColumn(object parameter)
        {
            return true;
        }

        public void AddColumn(object parameter)
        {
            var newColumn = new ColumnModel();
            newColumn.ColumnName = Column.ColumnName;
            newColumn.Label = Column.Label;
            newColumn.ID = _JqGridModelInstance.ColumnId;
            _JqGridModelInstance.ColumnId++;
            _JqGridModelInstance.Columns.Add(newColumn);
        }

        public bool CanDeleteColumn(object parameter)
        {
            return true;
        }

        public void DeleteColumn(object parameter)
        {
            var columnModel = parameter as ColumnModel;
            _JqGridModelInstance.Columns.Remove(columnModel);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void onPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
