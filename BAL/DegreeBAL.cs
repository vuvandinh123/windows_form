using Exercise01.DAL;
using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.BAL
{
    public class DegreeBAL
    {
        DegreeDAL dal = new DegreeDAL();
        public List<DegreeBEL> ReadList()
        {
            List<DegreeBEL> lstCus = dal.ReadList(); 
            return lstCus;
        }
        public DegreeBEL ReadID(string id)
        {
            return dal.ReadID(id);
        }
       
    }
   
}
