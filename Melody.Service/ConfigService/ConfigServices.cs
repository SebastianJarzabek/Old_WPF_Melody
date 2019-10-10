using Melody.Service.ConfigService.Interfaces;
using System;

namespace Melody.Service.ConfigService
{
  public class ConfigServices : IConfigServices
  {
    private string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

    public string GetConnectionString()
    {
      return _connectionString;
    }
  }
}
