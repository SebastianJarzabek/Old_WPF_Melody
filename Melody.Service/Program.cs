using Melody.Service.ConfigService.Interfaces;
using Melody.Service.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melody.Service.PasswordCoder;
using Melody.Service.Dbo.Interfaces;
using Melody.Service.SqlExecuters.Interfaces;
using Melody.Service.Dbo;
using Melody.Service.ConfigService;
using Melody.Service.SqlExecuters;

namespace Melody.Service
{
  class Program 
  {
    static void Main(string[] args)
    {

      var pom = new AccessParms("admin ", "  admin");

      var code = new Coder(pom.Password);
      var isCode = code.CodePassword();
      IConfigServices cfg = new ConfigServices();

      IDboConnect dboConnect = new DboConnect(cfg);
      ISqlExecute sqlExecute = new SqlExecute();
      var asd = new AppAccess(dboConnect, sqlExecute);
      var qwe = asd.Access(pom);
    }

    ////public class SomeObjectFactory : ISomeObjectFactory
    ////{
    ////  private IYourService _service;
    ////  public SomeObjectFactory(IYourService service)
    ////  {
    ////    _service = service;
    ////  }

    ////  public ISomeObject Create(float someValue)
    ////  {
    ////    return new SomeObject(_service, someValue);
    ////  }
    ////}
  }
}
