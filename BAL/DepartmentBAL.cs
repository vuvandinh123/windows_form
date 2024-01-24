using Exercise01.DAL;
using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.BAL
{
    public class DepartmentBAL
    {
        DepartmentDAL dal = new DepartmentDAL();
        public List<DepartmentBEL> ReadList()
        {
            List<DepartmentBEL> lstCus = dal.ReadList(); 
            return lstCus;
        }
        public DepartmentBEL ReadID(string id)
        {
            return dal.ReadID(id);
        }
       
    }
   
}
