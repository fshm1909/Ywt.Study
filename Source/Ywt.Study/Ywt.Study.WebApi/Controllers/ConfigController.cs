using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Ywt.Study.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfigController : Controller
    {
        public IConfiguration _Configuration { get; }

        ConfigController(IConfiguration Configuration)
        {
            _Configuration = Configuration;

        }

        [Route("Index")]
        [HttpGet]
        public IActionResult Index()
        {
            var list = new List<string>();

            foreach (var item in _Configuration.AsEnumerable())
            {
                list.Add("key:{item.Key};value:{item.Value}");
            }

            return Ok(list);
        }
    }
}
