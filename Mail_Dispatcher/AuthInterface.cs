using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Dispatcher
{

    internal interface AuthInterface
    {
       string userName { get; }
        string email { get; }
        string photoUrl { get; }
    }
}
