using Melody.Service.ConfigService.Interfaces;
using Melody.Service.Dbo.Interfaces;
using System;
using System.Data.SqlClient;

namespace Melody.Service.Dbo
{
  class DboConnect : IDboConnect
  {
    private readonly IConfigServices _configService;

    public DboConnect(IConfigServices configService)
    {
      _configService = configService ?? throw new ArgumentNullException(nameof(IDboConnect));
    }

    public SqlConnection Connect()
    {
      try
      {
        var pom = _configService.GetConnectionString();
        ////Error.
        using (SqlConnection connection = new SqlConnection(_configService.GetConnectionString().ToString()))
        {
          return connection;
        }
      }
      catch (Exception e)
      {
        throw new Exception("SQL- connection fail." + e);
      }
    }
  }
}
