using System.ComponentModel;

namespace GridCreator.Model
{
    public class JqGridModel : INotifyPropertyChanged
    {
        public static int test = 0;
        private string _TableId;
        public string TableId
        {

            get { return _TableId; }
            set
            {

                if (_TableId != value)
                {
                    _TableId = value;
                    test++;
                    OnPropertyChanged("PagerId");
                    OnPropertyChanged("TableId");
                }
            }
        }
        private string _PagerId = test.ToString();
        public string PagerId
        {

            get { return "Promena" + test.ToString(); }
            set {
                
                    OnPropertyChanged("PagerId");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
