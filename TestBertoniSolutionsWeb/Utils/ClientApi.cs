using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TestBertoniSolutionsWeb.Utils
{
    public class ClientApi
    {
        private static HttpClient _cliente;
        private string _baseUrl;

        public ClientApi(string baseUrl)
        {
            _baseUrl = baseUrl;
            _cliente = new HttpClient();
            _cliente.DefaultRequestHeaders.Accept.Clear();
            _cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public T Invocar<T>(string recurso, int metodo)
        {
            if (metodo == MetodoHttp.Get)
            {
                _cliente.BaseAddress = new Uri(_baseUrl);
                var respuesta = _cliente.GetAsync(recurso).Result;
                if (respuesta.IsSuccessStatusCode)
                {
                    var contenido = respuesta.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<T>(contenido);
                }
            }
            throw new ApplicationException("Problemas invocando el recurso del API.");
        }
    }
    public class MetodoHttp
    {
        public const int Get = 1;
        public const int Post = 2;
    }
}
