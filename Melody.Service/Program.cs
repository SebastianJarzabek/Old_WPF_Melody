using Melody.Service.ConfigService;
using Melody.Service.ConfigService.Interfaces;
using Melody.Service.Dbo;
using Melody.Service.Dbo.Interfaces;
using Melody.Service.Logic;
using Melody.Service.PasswordCoder;
using Melody.Service.SqlExecuters;
using System;
using System.Data.SqlClient;

namespace Melody.Service
{
  class Program
  {
    public static void Main(string[] args)
    {
      var sqlExecute = new SqlExecute();
      var pom = new AccessParms("admin ", "  admin");
      var code = new Coder(pom.Password);
      var isCode = code.CodePassword();

      IConfigServices cfg = new ConfigServices();

      //IDboConnect dboConnect = new DboConnect(cfg);
      //var asd = new AppAccess(dboConnect, sqlExecute.LogIn.ToString());
      //var qwe = asd.Access(pom);

      const string queryTransaction = "SELECT COUNT(UserID) FROM Transaction WHERE TransactionTypeID = 6 AND UserID = @UserID";

      var constr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

      using (var con = new SqlConnection(constr))
      {
        using (var cmd = new SqlCommand(queryTransaction, con))
        {
          //cmd.Parameters.AddWithValue("@UserID", userId);
          con.Open();

          var result = (int)cmd.ExecuteScalar();

          //returning a boolean comparator works like this :
          //will return true if the result is greater than zero, but false if it is not.
          // result > 0;
        }
      }

      Console.ReadKey();


      //  using (SqlConnection connection = new SqlConnection(
      //           "Data Source=SEBASTIAN;Initial Catalog=MelodyDb;Integrated Security=True;Pooling=False"))
      //  {
      //    SqlCommand command = new SqlCommand("SELECT TOP (1000) [id],[name],[surname],[login],[password]FROM[EFirmaDB].[dbo].[User]", connection);
      //    command.Connection.Open();
      //    var a = command.ExecuteNonQuery();
      //    using (SqlDataReader reader = command.ExecuteReader())
      //    {
      //      while (reader.Read())
      //      {
      //        Console.WriteLine(String.Format("{0}, {1},{2},{3}",
      //            reader[0], reader[1], reader[2], reader[3]));
      //      }
      //    }
      //  }
    }
  }
}
