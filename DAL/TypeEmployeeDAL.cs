using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.DAL
{
    public class TypeEmployeeDAL :DBConnection
    {
        public List<TypeEmployeeBEL> ReadList()
        {
            return TypeEmployee.ToList();
        }
        public TypeEmployeeBEL ReadTypeEmployeeID(string id)
        {
            TypeEmployeeBEL employee = this.TypeEmployee.Where(m => m.Id == id).FirstOrDefault();

            return employee;
        }
        public void NewTypeEmployee(TypeEmployeeBEL em)
        {
            this.TypeEmployee.Add(em);
            this.SaveChanges();
        }
        public void DeleteTypeEmployee(string id)
        {
            TypeEmployeeBEL employeeToDelete = this.TypeEmployee.Where(m => m.Id == id).FirstOrDefault();
            this.TypeEmployee.Remove(employeeToDelete);
            this.SaveChanges();
        }
        public void EditTypeEmployee(TypeEmployeeBEL em)
        {
            var editArea = this.TypeEmployee.Where(c => c.Id == em.Id).FirstOrDefault();
            this.Entry(editArea).CurrentValues.SetValues(em);
            this.SaveChanges();
        }
    }
}
