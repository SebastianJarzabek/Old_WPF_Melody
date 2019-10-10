using Melody.Service.ConfigService.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melody.Service.Dbo.Interfaces;

namespace Melody.Service.Dbo
{
  class DboConnect : IDboConnect
  {
    private readonly IConfigService cfg;

    public DboConnect(IConfigService configService)
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
        using (SqlConnection connection = new SqlConnection(cfg.connectionString))
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
