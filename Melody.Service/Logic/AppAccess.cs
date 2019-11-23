using Melody.Service.Dbo.Interfaces;
using System;
using System.Data.SqlClient;

namespace Melody.Service.Logic
{
  public class AppAccess
  { 
    private readonly IDboConnect _connect;
    private readonly string _sqlExecute;

    public AppAccess(IDboConnect dboConnect, string sqlExecute)
    {
       _connect = dboConnect ?? throw new ArgumentNullException(nameof(IDboConnect));
      this._sqlExecute = sqlExecute ?? throw new ArgumentNullException("ArgumentNullException- sqlExecute parm in AppAccess can not be null.");
    }

    public bool Access(AccessParms accessParms)
    {
      try
      {

        using (var connection = _connect.Connect())
        {
          var commandString = _sqlExecute;
          SqlCommand command = new SqlCommand("selest * from users", connection);

          command.Connection.Open();
          command.BeginExecuteReader();
          return command.ExecuteNonQuery() == 1 ? true : false;
        }
      }
      catch (SqlException ex)
      {
        throw new Exception(ex.Message);
      }
    }
  }
}