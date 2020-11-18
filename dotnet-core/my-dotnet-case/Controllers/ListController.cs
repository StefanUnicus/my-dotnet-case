using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_dotnet_case.Controllers
{
    [ApiController]
    [Route("")]
    public class ListController : ControllerBase
    {
        /*public IActionResult Index()
        {
            return View();
        }*/
        [HttpGet]
        public IActionResult getList() { return null; }

        [HttpPost]
        public IActionResult addListEntry() 
        {
            return null;
        }
    }
}
