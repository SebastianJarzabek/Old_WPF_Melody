using Melody.Service.ConfigService.Interfaces;
using System;

namespace Melody.Service.ConfigService
{
  public class ConfigService : IConfigService
  {
    public string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

    string IConfigService.ConnectionString => _connectionString;
  }
}
