using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Ywt.Study.EFCore;

namespace Ywt.Study.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EFCoreSelectController : Controller
    {
        private Select select = new Select();

        [Route("GetList")]
        [HttpGet]
        public IActionResult GetList()
        {
            var list = select.GetList();
            return Content(JsonConvert.SerializeObject(list));
        }

        [Route("Get")]
        [HttpGet]
        public IActionResult Get()
        {
            var list = select.First();
            return Content(JsonConvert.SerializeObject(list));
        }
    }
}
