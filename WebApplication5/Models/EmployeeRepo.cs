using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.Models
{
    public class EmployeeRepo : IEmployeeRepo
    {

        EmployeeDbContext _context;

        public EmployeeRepo(EmployeeDbContext context)
        {
            _context = context;
        }

        public void AddEmployee(Employee obj)
        {
            _context.Employees.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            Employee obj = _context.Employees.Find(id);
            _context.Employees.Remove(obj);
            _context.SaveChanges();
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> stList = _context.Employees.ToList();
            return stList;
        }

        public Employee GetEmployeeById(int id)
        {
            Employee obj = _context.Employees.Find(id);
            return obj;
        }

        public void UpdateEmployee(Employee obj)
        {
            _context.Employees.Update(obj);
            _context.SaveChanges();
        }
    }
}
