using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Model
{
    public class WageBEL
    {
        [Key]
        public int ID { get; set; }
        public float BasicSalary { get; set; }
        public int Coefficients { get; set; }
        public float WageDf { get; set; }
        public float Allowance { get; set; }
        public string EmployeeID { get; set; }

    }
}
