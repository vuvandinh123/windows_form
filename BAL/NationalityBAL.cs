using Exercise01.DAL;
using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.BAL
{
    public class NationalityBAL
    {
        NationalityDAL dal = new NationalityDAL();
        public List<NationalityBEL> ReadList()
        {
            List<NationalityBEL> lstCus = dal.ReadList(); 
            return lstCus;
        }
        public NationalityBEL ReadID(string id)
        {
            return dal.ReadID(id);
        }
       
    }
   
}
