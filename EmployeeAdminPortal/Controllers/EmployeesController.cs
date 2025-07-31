using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Models;
using EmployeeAdminPortal.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdminPortal.Controllers
{
    //localhost:xxxx/api/employees
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public EmployeesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext; 
            
        }

        
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var allEmployee = dbContext.Employees.ToList();

            return Ok(allEmployee);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetEmployeeById(Guid id)
        {
            var employee = dbContext.Employees.Find(id);

            if (employee is null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
        {
            var employessEntity = new Employee()
            {
                Name = addEmployeeDto.Name,
                Email = addEmployeeDto.Email,
                Phone = addEmployeeDto.Phone,
                Salary = addEmployeeDto.Salary

            };
            dbContext.Employees.Add(employessEntity);
            dbContext.SaveChanges();

            return Ok(employessEntity);
        }

        [HttpPut]
        [Route ("{id:guid}")]
        public IActionResult UpdateEmployee(Guid id, UpdateEmployeeDto updateEmployeeDto)
        {
            var employee = dbContext.Employees.Find(id);

            if (employee is null)
            {
                return NotFound();
            }
            employee.Name = updateEmployeeDto.Name;
            employee.Email = updateEmployeeDto.Email;
            employee.Phone = updateEmployeeDto.Phone;
            employee.Salary = updateEmployeeDto.Salary;
            dbContext.SaveChanges();
            return Ok(employee);
        }

        [HttpDelete]
        [Route("{id:guid}")]

        public IActionResult DeleteEmployee(Guid id)
        {
            var employee = dbContext.Employees.Find(id);

            if (employee is null)
            {
                return NotFound();
            }
            dbContext.Employees.Remove(employee);
            return Ok(employee);
        }
    }
}
