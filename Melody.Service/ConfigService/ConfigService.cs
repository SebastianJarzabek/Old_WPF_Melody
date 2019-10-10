using Melody.Service.ConfigService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melody.Service.ConfigService
{
  class ConfigService : IConfigService
  {

    string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

    string IConfigService.connectionString => throw new NotImplementedException();
  }
}
