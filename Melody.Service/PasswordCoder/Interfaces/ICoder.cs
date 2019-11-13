namespace Melody.Service.PasswordCoder.Interfaces
{
  public interface ICoder
  {
    string CodePassword();

    string uncodePassword();
  }
}