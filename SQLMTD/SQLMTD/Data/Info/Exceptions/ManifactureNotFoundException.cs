using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLMTD.Data.Info.Exceptions
{
    public class ManifactureNotFoundException : Exception
    {
        public ManifactureNotFoundException()
            : base()
        {
        }

        public ManifactureNotFoundException(string message)
            : base(message)
        {
        }
    }
}
