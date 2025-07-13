using Microsoft.AspNetCore.Mvc;
using Exercise3.Models;

namespace Exercise3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
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
            },
            new Employee
            {
                Id = 2,
                Name = "Jane Smith",
                Salary = 60000,
                Permanent = false,
                DateOfBirth = new DateTime(1985, 5, 5),
                Department = new Department { DeptId = 102, DeptName = "Finance" },
                Skills = new List<Skill> {
                    new Skill { SkillId = 3, SkillName = "Accounting" }
                }
            }
        };

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Employee> Put([FromBody] Employee emp)
        {
            if (emp.Id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            var existingEmployee = employees.FirstOrDefault(e => e.Id == emp.Id);

            if (existingEmployee == null)
            {
                return BadRequest("Invalid employee id");
            }

            // Update fields
            existingEmployee.Name = emp.Name;
            existingEmployee.Salary = emp.Salary;
            existingEmployee.Permanent = emp.Permanent;
            existingEmployee.Department = emp.Department;
            existingEmployee.Skills = emp.Skills;
            existingEmployee.DateOfBirth = emp.DateOfBirth;

            return Ok(existingEmployee);
        }
    }
}
