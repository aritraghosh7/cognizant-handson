using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exercise2.Controllers
{
    [Route("api/emp")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [ActionName("GetAllEmployees")]
        public IActionResult GetAll()
        {
            return Ok(new string[] { "Emp1", "Emp2", "Emp3" });
        }
    }
}
