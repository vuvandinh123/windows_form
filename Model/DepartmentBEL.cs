using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Model
{
    //phòng ban
    public class DepartmentBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(10)]
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual List<EmployeeBEL> employees { get; set; } = new List<EmployeeBEL>();
    }
}
