using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class DataResponse<T> : Response
    {
        public DataResponse(string message, bool hasSuccess, List<T> itens) : base(message, hasSuccess)
        {
            this.Itens = itens;
        }
        public List<T> Itens { get; private set; }
    }
}
