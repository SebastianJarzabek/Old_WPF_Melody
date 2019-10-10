using Melody.Service.ConfigService.Interfaces;
using Melody.Service.Dbo.Interfaces;
using System;
using System.Data.SqlClient;

namespace Melody.Service.Dbo
{
  class DboConnect : IDboConnect
  {
    private readonly IConfigServices cfg;

    public DboConnect(IConfigServices configService)
    {
      if (configService != null)
      {
        this.cfg = configService;
      }
      else
      {
        throw new ArgumentNullException();
      }
    }

    public SqlConnection Connect()
    {
      try
      {
        ////Error 
        using (SqlConnection connection = new SqlConnection(cfg.GetConnectionString()))
        {
          return connection;
        }
      }
      catch (Exception e)
      {
        throw new Exception("SQL- connection falied." + e);
      }
    }
  }
}
