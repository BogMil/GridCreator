using GridCreator.Model;

namespace GridCreator
{
    public static class JqGridModelSingletonFactory
    {
        private static JqGridModel _Instance = null;

        public static JqGridModel Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new JqGridModel();
                }
                return _Instance;
            }
        }

        public static void setInstanceToNull()
        {
            _Instance = null;
        }
    }
}
