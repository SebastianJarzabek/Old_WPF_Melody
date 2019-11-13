using Melody.Service.PasswordCoder.Interfaces;

namespace Melody.Service.PasswordCoder
{
  class Coder : ICoder
  {
    private readonly string _passwordToCode;
    private readonly string _passwordToUncode;

    public Coder(string password)
    {
      this._passwordToCode = password;
      this._passwordToUncode = password;
    }

    public string CodePassword()
    {
      var password = System.Text.Encoding.UTF8.GetBytes(_passwordToCode);
      return System.Convert.ToBase64String(password);
    }

    public string uncodePassword()
    {
      var password = System.Text.Encoding.UTF8.GetBytes(_passwordToUncode);
      return System.Convert.ToBase64String(password);

    }
  }
}
