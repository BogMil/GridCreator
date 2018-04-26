using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;

namespace GridCreator.Model
{
    public class JqGridModel : INotifyPropertyChanged
    {
        public JqGridModel()
        {
            IList<AddColumnOption> list = new List<AddColumnOption>();
            list.Add(new AddColumnOption("Manualy add columns and their definition"));
            list.Add(new AddColumnOption("Add columns from SQL Server"));
            _AddColumnsOptions = new CollectionView(list);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private CollectionView _AddColumnsOptions;  
        private string _AddColumnsOption = "Manualy add columns and their definition";
        private string _TableId = "TestTableId";
        private string _NavigatorId = "TestNavigatorId";
        private string _Url = "Test url";
        private int i = 0;

        public CollectionView AddColumnsOptions
        {
            get { return _AddColumnsOptions; }
        }

        public string AddColumnsOption
        {
            get { return _AddColumnsOption; }
            set
            {
                if (_AddColumnsOption != value)
                    _AddColumnsOption = value;
            }
        }

        public string TableId
        {
            get { return _TableId; }
            set
            {
                if (_TableId != value)
                {
                    _TableId = value;
                    i++;
                    _NavigatorId = i.ToString();

                    onPropertyChanged("TableId");
                    onPropertyChanged("NavigatorId");
                }
            }
        }

        public string NavigatorId
        {
            get { return _NavigatorId; }
            set
            {
                if (_NavigatorId != value)
                {
                    _NavigatorId = value;
                    onPropertyChanged("_NavigatorId");
                }
            }
        }

        public string Url
        {
            get { return _Url; }
            set
            {
                if (_Url != value)
                {
                    _Url = value;
                    onPropertyChanged("_Url");
                }
            }
        }

        private void onPropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }

    public class AddColumnOption
    {
        public string Name { get; set; }

        public AddColumnOption(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
