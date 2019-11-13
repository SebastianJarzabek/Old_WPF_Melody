using Melody.Service.SqlExecuters.Interfaces;

namespace Melody.Service.SqlExecuters
{
  public class SqlExecute : ISqlExecute
  {
    private readonly string _LogIn = "Exec.LogIn";
    private readonly string _Select = "Select * from PassToLogIn";

    public string LogIn { get => _LogIn; }
    public string Select { get => _Select; }
  }
}
