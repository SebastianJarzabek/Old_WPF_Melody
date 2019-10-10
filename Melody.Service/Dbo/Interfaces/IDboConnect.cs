using System.Data.SqlClient;

namespace Melody.Service.Dbo.Interfaces
{
  public interface IDboConnect
  {
    SqlConnection Connect();
  }
}