using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace IdentityServerDemo.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "Admin")]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public List<string> Get()
        {
            return new List<string>() {
                "Nancy Davolio",
                "Andrew Fuller",
                "Janet Leverling"
            };
        }
    }
}
