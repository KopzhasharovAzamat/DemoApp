using Microsoft.Data.SqlClient;

namespace DemoApp;

public class Database
{
    private SqlConnection con = new SqlConnection("Data Source=DESKTOP-2BAMTAJ;Database=AidanaTest;Trusted_Connection=True;User ID=sa;Password=123;TrustServerCertificate=True;");


    public void openCon()
    {
        if (con.State == System.Data.ConnectionState.Closed) con.Open();
    }

    public void closeCon()
    {
        if (con.State == System.Data.ConnectionState.Open) con.Close();
    }

    public SqlConnection getCon()
    {
        return con;
    }
}