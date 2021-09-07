using System.Collections.Generic;
using IoC2.Models;

namespace IoC2.Repositories
{
    public interface IEmployeeRepository
    {
        public IEnumerable<Employee> Get();
        public Employee GetById(int id);
    }
}

