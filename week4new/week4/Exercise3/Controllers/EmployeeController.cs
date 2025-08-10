using Microsoft.AspNetCore.Mvc;
using Exercise3.Models;
using Exercise3.Filters;

namespace Exercise3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [CustomAuthFilter]  // Custom Authorization Filter
    public class EmployeeController : ControllerBase
    {
        private List<Employee> employees;

        public EmployeeController()
        {
            employees = GetStandardEmployeeList();
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "John Doe",
                    Salary = 50000,
                    Permanent = true,
                    DateOfBirth = new DateTime(1990, 1, 1),
                    Department = new Department { DeptId = 101, DeptName = "HR" },
                    Skills = new List<Skill> {
                        new Skill { SkillId = 1, SkillName = "Communication" },
                        new Skill { SkillId = 2, SkillName = "Leadership" }
                    }
                }
            };
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Employee>> Get()
        {
            throw new Exception("Test exception for custom filter");  // Triggers custom exception filter
            // return Ok(employees);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee emp)
        {
            employees.Add(emp);
            return Ok(emp);
        }
    }
}
