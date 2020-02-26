using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement_CRUDoperator.Models
{
    public class EmployeeDetais
    {
        public int emp_no { get; set; } 
        [Required]
        public DateTime birth_date { get; set;}
        [Required]
        public String first_name { get; set; }
        [Required]
        public String last_name { get; set; }
        [Required]
        public String gender { get; set; }
        [Required]

        public DateTime hire_date { get; set; }
    }
}
