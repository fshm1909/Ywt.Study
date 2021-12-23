using Microsoft.AspNetCore.Mvc;

namespace Ywt.Study.WebApi.Controllers.EFCore
{
    [ApiController]
    [Route("[controller]")]
    public class EFCoreSelectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
