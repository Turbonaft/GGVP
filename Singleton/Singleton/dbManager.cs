namespace Singleton
{
    public class dbManager
    {
        private static dbManager _instance;

       
        private dbManager()
        {
            
        }

        public static dbManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new dbManager();
                }
                return _instance;
            }
        }

        public void Connect()
        {
            
        }
    }
}
