using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using my_dotnet_case.Models;
using my_dotnet_case.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
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

        [HttpGet("getlist")] 
        public List<Listentry> GetList() {
            return listService.GetListentries(); 
        }
        // Tested with Postman. Initially thought the issue was with the connection between service and controller when I got a list with no content
        // Then noticed I got a list with a length matching the number of entries it should have. It was just empty inside. Debugging showed values are sent to controller.
        // Issue thus is in how the controller returns the values, which seems to be converted to null before being sent out.

        /*[HttpGet("gettest")] // This code is for quick tests against Postman to make sure the API can be reached and gives a reply.
        public ActionResult<string> GetReply() { String reply = "Hello Postman"; return reply; } //works fine.*/

        [HttpPost("addentry")] //Plan was to lock this so that if no autherized jwt was included in the call it wouldn't work
        public IActionResult AddListEntry(Listentry listentry) 
        {
            listService.AddEntry(listentry);
            return Ok();
        }
    }
}
