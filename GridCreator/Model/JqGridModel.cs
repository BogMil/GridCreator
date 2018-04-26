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
        private List<CollumnModel> _Collumns;
        private string _AddColumnsOption = "Manualy add columns and their definition";
        private string _TableId = "TestTableId";
        private string _PagerId = "TestPagerId";
        private string _TableWidth = "Test_TableWidth";
        private string _TableHeight= "Test_TableHeight";
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

                    onPropertyChanged("TableId");
                }
            }
        }

        public string PagerId
        {
            get { return _PagerId; }
            set
            {
                if (_PagerId != value)
                {
                    _PagerId = value;
                    onPropertyChanged("PagerId");
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
                    onPropertyChanged("Url");
                }
            }
        }

        public string TableWidth
        {
            get { return _TableWidth; }
            set
            {
                if (_TableWidth != value)
                {
                    _TableWidth = value;
                    onPropertyChanged("TableWidth");
                }
            }
        }

        public string TableHeight
        {
            get { return _TableHeight; }
            set
            {
                if (_TableHeight != value)
                {
                    _TableHeight = value;
                    onPropertyChanged("TableHeight");
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
