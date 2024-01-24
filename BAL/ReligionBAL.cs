using Exercise01.DAL;
using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.BAL
{
    public class ReligionBAL
    {
        ReligionDAL dal = new ReligionDAL();
        public List<ReligionBEL> ReadList()
        {
            List<ReligionBEL> lstCus = dal.ReadList(); 
            return lstCus;
        }
        public ReligionBEL ReadID(string id)
        {
            return dal.ReadID(id);
        }
       
    }
   
}
