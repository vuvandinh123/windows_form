using Exercise01.DAL;
using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.BAL
{
    public class EducationBAL
    {
        EducationDAL dal = new EducationDAL();
        public List<EducationBEL> ReadList()
        {
            List<EducationBEL> lstCus = dal.ReadList(); 
            return lstCus;
        }
        public EducationBEL ReadID(string id)
        {
            return dal.ReadID(id);
        }
       
    }
   
}
