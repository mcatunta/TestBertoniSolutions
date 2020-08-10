using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBertoniSolutionsWeb.Utils;

namespace TestBertoniSolutionsWeb.Controllers
{
    public class BaseController : Controller
    {
        private const string _BaseUrl = "https://jsonplaceholder.typicode.com/";
        public ClientApi _cliente;
        public BaseController()
        {
            _cliente = new ClientApi(_BaseUrl);
        }

        public T Ejecutar<T>(Func<T> funcion)
        {
            try
            {
                return funcion();
            }
            catch
            {
                return default;
                //return BadRequest("Problemas con el servicio Web.");
            }
        }

    }
}
