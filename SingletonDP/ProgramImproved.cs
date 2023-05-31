namespace SingletonDP
{
    public class DatabaseConnection
    {
        private static DatabaseConnection? _instance;
        string Id = Guid.NewGuid().ToString();

        private DatabaseConnection()
        {
            // Private constructor to prevent direct instantiation
        }

        public static DatabaseConnection Instance
        {
            get
            {
                // Create lazy only one instance 
                if (_instance == null)
                {
                    _instance = new DatabaseConnection();
                }
                return _instance;
            }
        }

        public void Connect()
        {
            Console.WriteLine("{0}: You are connected!", Id);
        }

        public void Disconnect()
        {
            Console.WriteLine("{0}: You are disconnected!", Id);
        }
    }

}
