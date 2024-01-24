using Exercise01.DAL;
using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.BAL
{
    public class NationBAL
    {
        NationDAL dal = new NationDAL();
        public List<NationBEL> ReadList()
        {
            List<NationBEL> lstCus = dal.ReadList(); 
            return lstCus;
        }
        public NationBEL ReadID(string id)
        {
            return dal.ReadID(id);
        }
       
    }
   
}
