using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Exercise01.Model
{
    //quốc tịch
    public class NationalityBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(10)]
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual List<EmployeeBEL> employees { get; set; } = new List<EmployeeBEL>();
    }
}
