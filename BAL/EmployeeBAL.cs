using Exercise01.DAL;
using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.BAL
{
    public class EmployeeBAL
    {
        EmployeeDAL dal = new EmployeeDAL();
        public List<EmployeeBEL> ReadEmployeeList()
        {
            List<EmployeeBEL> lstCus = dal.ReadEmployeeList(); 
            return lstCus;
        }
        public EmployeeBEL ReadEmployeeID(string id)
        {
            dal.ReadEmployeeID(id);
            return dal.ReadEmployeeID(id);
        }
        public void NewEmployee(EmployeeBEL em)
        {
            dal.NewEmployee(em);
        }
        public void EditEmployee(EmployeeBEL em)
        {
            dal.EditEmployee(em);
        }
        public void DeleteEmployee(string id)
        {
            dal.DeleteEmployee(id);
        }
    }
   
}
