using Melody.Service.Dbo.Interfaces;
using Melody.Service.SqlExecuters.Interfaces;
using System;
using System.Data.SqlClient;

namespace Melody.Service.Logic
{
  public class AppAccess
  { 
    private readonly IDboConnect _connect;
    private readonly ISqlExecute _sqlExecute;

    public AppAccess(IDboConnect dboConnect, ISqlExecute sqlExecute)
    {
       _connect = dboConnect ?? throw new ArgumentNullException(nameof(IDboConnect));
       _sqlExecute = sqlExecute ?? throw new ArgumentNullException(nameof(ISqlExecute));
    }

    public bool Access(AccessParms accessParms)
    {
      try
      {

        using (var connection = _connect.Connect())
        {
          var commandString = _sqlExecute.LogIn;
          SqlCommand command = new SqlCommand(commandString, connection);

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