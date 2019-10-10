using Melody.Service.PasswordCoder.Interfaces;

namespace Melody.Service.PasswordCoder
{
  class Coder : ICoder
  {
    private readonly string _passwordToCode;

    public Coder(string password)
    {
      this._passwordToCode = password;
    }

    public string CodePassword(string password)
    {
      var _passwordToCode = System.Text.Encoding.UTF8.GetBytes(password);
      return System.Convert.ToBase64String(_passwordToCode);
    }
  }
}
