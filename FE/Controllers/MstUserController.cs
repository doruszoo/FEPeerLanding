using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using FE.Dto.Res;

namespace FE.Controllers
{
    public class MstUserController : Controller
    {
        private readonly HttpClient _httpClient;

        public MstUserController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
