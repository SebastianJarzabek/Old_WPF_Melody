namespace Melody.Service.Logic
{
  public class AccessParms
  {
    public string Login { get; set; }

    public string Password { get; set; }

    public AccessParms(string login, string password)
    {
      this.Login = TrimParms(login);
      this.Password = TrimParms(password);
    }

    private string TrimParms(string Parm)
    {
      return Parm.Trim();
    }
  }
}