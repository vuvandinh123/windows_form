 using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.DAL
{
    public class DepartmentDAL : DBConnection
    {
        public List<DepartmentBEL> ReadList()
        {
            return Department.ToList();
        }
        public DepartmentBEL ReadID(string id)
        {
            DepartmentBEL employee = this.Department.Where(m => m.Id == id).FirstOrDefault();

            return employee;
        }

    }
}
