using Melody.Service.SqlExecuters.Interfaces;

namespace Melody.Service.SqlExecuters
{
  public class SqlExecute : ISqlExecute
  {
    private readonly string _LogIn = "Exec.LogIn";

    public string LogIn { get => LogIn; set => LogIn = _LogIn; }
  }
}
