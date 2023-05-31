using SingletonDP;

//DatabaseConnection db1 = new DatabaseConnection();
//db1.Connect();
//db1.Disconnect();
//db1 = new DatabaseConnection();
//db1.Connect();
//db1.Disconnect();

var database = DatabaseConnection.Instance;
database.Connect();
database.Disconnect();
database.Connect();
database.Disconnect();


//public class DatabaseConnection
//{
//    string Id = Guid.NewGuid().ToString();
//    public void Connect()
//    {
//        Console.WriteLine("{0}: You are connected!", Id);
//    }

//    public void Disconnect()
//    {
//        Console.WriteLine("{0}: You are disconnected!", Id);
//    }
//}
