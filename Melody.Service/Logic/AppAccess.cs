using Melody.Service.Dbo.Interfaces;
using Melody.Service.SqlExecuters.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melody.Service.Logic
{
  public class AppAccess
  {
    private readonly IDboConnect _connect;
    private readonly ISqlExecute _sqlExecute;

    public AppAccess(IDboConnect dboConnect, ISqlExecute sqlExecute)
    {
      if (dboConnect != null)
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
          command.ExecuteNonQuery();
        }
      }
      catch (Exception)
      {

        throw new Exception();
      }
      return false;
    }
  }
}