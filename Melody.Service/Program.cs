using Melody.Service.ConfigService;
using Melody.Service.ConfigService.Interfaces;
using Melody.Service.Dbo;
using Melody.Service.Dbo.Interfaces;
using Melody.Service.Logic;
using Melody.Service.PasswordCoder;
using Melody.Service.SqlExecuters;
using Melody.Service.SqlExecuters.Interfaces;
using System;
using System.Data.SqlClient;

namespace Melody.Service
{
  class Program
  {
    public static void Main(string[] args)
    {
      ////var aaa = new ConfigServices();
      var pom = new AccessParms("admin ", "  admin");
      var insertCommand = "insert into  [PassToLogIn] (idEmployee, login, password) values (1,'admin','admin')";
     



      var code = new Coder(pom.Password);
      var isCode = code.CodePassword();
      var commandString = "select * from [PassToLogIn]";

      //using (SqlConnection connection = new SqlConnection(
      //         "Data Source=SEBASTIAN;Initial Catalog=MelodyDb;Integrated Security=True;Pooling=False"))
      //{
      //  SqlCommand command = new SqlCommand("SELECT TOP (1000) [id],[name],[surname],[login],[password]FROM[EFirmaDB].[dbo].[User]", connection);
      //  command.Connection.Open();
      //  var a = command.ExecuteNonQuery();
      //  using (SqlDataReader reader = command.ExecuteReader())
      //  {
      //    while (reader.Read())
      //    {
      //      Console.WriteLine(String.Format("{0}, {1},{2},{3}",
      //          reader[0], reader[1], reader[2], reader[3]));
      //    }
      //  }
      //}


      ConfigServices

      IConfigServices cfg = new ConfigServices();

      IDboConnect dboConnect = new DboConnect(cfg);
      ISqlExecute sqlExecute = new SqlExecute();
      var asd = new AppAccess(dboConnect, sqlExecute);
      var qwe = asd.Access(pom);
      Console.ReadKey();
    }

    //public class SomeObjectFactory : ISomeObjectFactory
    //{
    //  private IYourService _service;
    //  public SomeObjectFactory(IYourService service)
    //  {
    //    _service = service;
    //  }

    //  public ISomeObject Create(float someValue)
    //  {
    //    return new SomeObject(_service, someValue);
    //  }
    //}
  }
}
