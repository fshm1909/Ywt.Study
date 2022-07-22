using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Ywt.Study.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        [Route("Index")]
        [HttpGet]
        public IActionResult Index()
        {
            List<string> list = new List<string>();
            DateTime d = new DateTime(2022, 1, 1);
            for (int i = 1; i < 53; i++)
            {
                list.Add(d.AddDays(7 * i).ToString("M月dd日") + "," + d.AddDays(7 * i + 1).ToString("M月dd日"));

            }

            return Content(string.Join("\n", list));
        }
    }
}
