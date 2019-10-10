using Melody.Service.SqlExecuters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melody.Service.SqlExecuters
{
  public class SqlExecute : ISqlExecute
  {
    private readonly string _LogIn = "Exec.LogIn";

    public string LogIn { get => LogIn; set => LogIn = _LogIn; }
  }
}
