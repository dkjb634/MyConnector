namespace MyConnector;

public class Connector
{
    private static Connector _instance;
    
    public static Connector getConnection()
    {
        if (_instance == null)
        {
            _instance = new Connector();
            
            //some
        }

        return _instance;
    }
    
    

    public string getConnectionDetails()
    {
        return "URL=127.0.0.1;User=Admin;Password=QS78SH";
    }
}