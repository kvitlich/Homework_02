using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectedLevel
{
  public class DbAccess : IDisposable
  {
    SqlConnection connection;

    public DbAccess(string DbName, string ServerName)
    {
      SqlConnectionStringBuilder conString = new SqlConnectionStringBuilder();
      conString["Trusted_Connection"] = true;
      conString["Server"] = ServerName;
      conString["Database"] = DbName;
      connection = new SqlConnection(conString.ConnectionString);
      connection.Open();
      Console.WriteLine("Connected!");
    }



    public void Dispose()
    {
      connection.Close();
      Console.WriteLine("Disconnected!");
    }
  }
}
