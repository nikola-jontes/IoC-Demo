using System.Collections.Generic;
using IoC2.Factory;
using IoC2.Models;
using IoC2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IoC2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        
        [HttpGet("Get")]
        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeRepository.Get();
        }

        [HttpGet("Get/{id}")]
        public Employee GetEmployeeById(int id)
        {
            return _employeeRepository.GetById(id);
        }


    }
}