using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class ResponseFactory
    {
        private static ResponseFactory _factory;

        public static ResponseFactory CreateInstance()
        {
            if (_factory == null)
            {
                _factory = new ResponseFactory();
            }
            return _factory;
        }

        private ResponseFactory() { }
        public Response CreateSuccessResponse()
        {
            return new Response("Sucesso na operação.", true);
        }
        public SingleResponse<T> CreateSuccessSingleResponse<T>(T item)
        {
            return new SingleResponse<T>("O dado de " + typeof(T).Name + " foi obtido com sucesso.", true, item);
        }
        public DataResponse<T> CreateSuccessDataResponse<T>(List<T> itens)
        {
            return new DataResponse<T>("Os dados de " + typeof(T).Name + " foram obtidos com sucesso.", true, itens);
        }
        public Response CreateFailResponse(string exception)
        {
            return new Response(exception, false);
        }

        public SingleResponse<T> CreateFailSingleResponse<T>(string exception, T item)
        {
            return new SingleResponse<T>(exception, false, item);
        }

        public DataResponse<T> CreateFailDataResponse<T>(string exception, List<T> itens)
        {
            return new DataResponse<T>(exception, false, itens);
        }
    }
}
