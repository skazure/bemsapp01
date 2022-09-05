using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE_Microservice1.Controllers
{
    [ApiController]
    [Route("demo")]
    public class BackendApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
