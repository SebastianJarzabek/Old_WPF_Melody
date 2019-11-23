﻿using Melody.Service.ConfigService.Interfaces;

namespace Melody.Service.ConfigService
{
  public class ConfigServices : IConfigServices
  {
    private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionStringTest"].ConnectionString;

    public string GetConnectionString()
    {
      return _connectionString;
    }
  }
}
