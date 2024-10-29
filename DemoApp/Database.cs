using Microsoft.Data.SqlClient;

namespace DemoApp;

public class Database
{
    private SqlConnection con = new SqlConnection("Data Source=NARUTO\\SQLEXPRESS;Database=libraries;Trusted_Connection=True;TrustServerCertificate=True;");


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