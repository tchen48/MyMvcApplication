using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyMvcApplication.Models
{
    [Table("dbo.Department")]
    public class Department
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}