using Exercise01.DAL;
using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.BAL
{
    public class TypeEmployeeBAL
    {
        TypeEmployeeDAL dal = new TypeEmployeeDAL();
        public List<TypeEmployeeBEL> ReadAreaList()
        {
            List<TypeEmployeeBEL> lstCus = dal.ReadList();
            return lstCus;
        }
        public TypeEmployeeBEL ReadTypeEmployeeID(string id)
        {
            return dal.ReadTypeEmployeeID(id);
        }
        public void NewTypeEmployee(TypeEmployeeBEL em)
        {
            dal.NewTypeEmployee(em);
        }
        public void EditTypeEmployee(TypeEmployeeBEL em)
        {
            dal.EditTypeEmployee(em);
        }
        public void DeleteTypeEmployee(string id)
        {
            dal.DeleteTypeEmployee(id);
        }
    }
}
