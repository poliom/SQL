using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLMTD.Data.Info.Exceptions
{
    public class ModelNotFoundException : Exception
    {
        public ModelNotFoundException()
            : base()
        {
        }

        public ModelNotFoundException(string message)
            : base(message)
        {
        }
    }
}
