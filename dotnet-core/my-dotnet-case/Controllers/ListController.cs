using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using my_dotnet_case.Models;
using my_dotnet_case.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_dotnet_case.Controllers
{
    [ApiController]
    [Route("api")]
    public class ListController : ControllerBase
    {
        private readonly ListService listService;

        public ListController(IOptions<ListService> settingsOptions)
        {
            this.listService = settingsOptions.Value;
        }

        //private ListService listService;
        /*public IActionResult Index()
        {
            return View();
        }*/
        [HttpGet("getlist")]
        public ActionResult<List<Listentry>> GetList() { return listService.GetListentries(); }

        [HttpPost("addentry")]
        [Consumes("application/json")]
        public IActionResult AddListEntry(Listentry listentry) 
        {
            //return listService.AddEntry(listentry);
            return null;
        }
    }
}
