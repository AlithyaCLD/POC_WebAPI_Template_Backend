using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handler
{
    public class CnExceptionHandler : System.ServiceModel.Dispatcher.ExceptionHandler
    {
        public override bool HandleException(Exception exception)
        {
            var test = "";
            test += "";
            return true;
        }
    }
}
