using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class Employee
    {
       
        public int Id { get; set; }
        public string EmpName { get; set; }
        public float Salary { get; set; }
    }
}
