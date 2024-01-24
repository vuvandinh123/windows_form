using Exercise01.DAL;
using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.BAL
{
    public class PositionBAL
    {
        PositionDAL dal = new PositionDAL();
        public List<PositionBEL> ReadList()
        {
            List<PositionBEL> lstCus = dal.ReadList(); 
            return lstCus;
        }
        public PositionBEL ReadID(string id)
        {
            return dal.ReadID(id);
        }
       
    }
   
}
