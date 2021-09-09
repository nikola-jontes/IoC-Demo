using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Runtime.InteropServices;
using IoC2.Models;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using IoC2.Factory;

namespace IoC2.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IDbConnection _dbConnection;

        public EmployeeRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        
        public IEnumerable<Employee> Get()
        {
            return _dbConnection.Query<Employee>("SELECT * FROM Employees");
        }

        public Employee GetById(int id)
        {
            string query = "SELECT * FROM employees WHERE Id = @id";
            return _dbConnection.Query<Employee>(query, new {id}).FirstOrDefault();
        }

        void CorrectUsername()
        {
            
        }
    }
    
}