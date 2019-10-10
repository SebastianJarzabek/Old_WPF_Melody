namespace Melody.Service.Logic
{
  public class AccessParms
  {
    public AccessParms(string login, string password)
    {
      this.Login = TrimParms(login);
      this.Password = TrimParms(password);
    }

    public string Login { get; set; }

    public string Password { get; set; }

    private string TrimParms(string parm)
    {
      return parm.Trim();
    }
  }
}