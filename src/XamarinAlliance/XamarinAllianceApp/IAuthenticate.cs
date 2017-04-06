using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinAllianceApp
{
    public interface IAuthenticate
    {
        Task<bool> Authenticate(String method);
    }
}
