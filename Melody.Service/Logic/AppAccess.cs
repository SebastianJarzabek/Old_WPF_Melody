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
      if (dboConnect != null && sqlExecute != null)
      {
        this._connect = dboConnect;
        this._sqlExecute = sqlExecute;
      }
      else
      {
        throw new ArgumentNullException();
      }
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

          return command.ExecuteNonQuery() == 1 ? true : false;
        }
      }
      catch (Exception)
      {

        throw new Exception();
      }
    }
  }
}