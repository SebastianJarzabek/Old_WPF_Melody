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

    public string CodePassword()
    {
      var password = System.Text.Encoding.UTF8.GetBytes(_passwordToCode);
      return System.Convert.ToBase64String(password);
    }
  }
}
