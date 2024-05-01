using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Response
    {
        public Response(string message, bool hasSuccess)
        {
            this.Message = message;
            this.HasSuccess = hasSuccess;
        }

        public string Message { get; set; }
        public bool HasSuccess { get; set; }
    }
}
