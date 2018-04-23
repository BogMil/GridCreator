using System;
using System.ComponentModel;

namespace GridCreator.Model
{
    public class JqGridModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _TableId = "TestTableId";
        private string _NavigatorId = "TestNavigatorId";
        private int i = 0;
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

        private void onPropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
