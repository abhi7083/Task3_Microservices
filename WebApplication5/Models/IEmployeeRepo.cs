using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public interface IEmployeeRepo
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        void AddEmployee(Employee obj);
        void UpdateEmployee(Employee obj);
        void DeleteEmployee(int id);
    }
}
