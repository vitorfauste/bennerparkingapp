using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class SingleResponse<T> : Response
    {

        public SingleResponse(string message, bool hasSuccess, T item) : base(message, hasSuccess)
        {
            this.Item = item;
        }
        public T Item { get; private set; }
    }
}
