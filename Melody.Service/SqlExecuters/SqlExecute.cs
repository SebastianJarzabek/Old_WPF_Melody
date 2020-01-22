namespace Melody.Service.SqlExecuters
{
  public class SqlExecute
  {
    private readonly string _logIn = "Exec logIn";
    private readonly string _addEmployee = "Exec addEmployee";
   

    public string LogIn { get => _logIn; }

    public string AddEmployee { get => _addEmployee; }

  }
}
