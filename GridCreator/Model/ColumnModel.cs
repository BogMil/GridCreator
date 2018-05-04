namespace GridCreator.Model
{
    public class ColumnModel
    {
        private string _Label;
        private string _ColumnName;
        private int _ID;

        public string Label { get => _Label; set => _Label = value; }
        public string ColumnName { get => _ColumnName; set => _ColumnName = value; }
        public int ID { get => _ID; set => _ID = value; }
    }
}
