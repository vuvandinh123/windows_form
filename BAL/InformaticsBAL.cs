using Exercise01.DAL;
using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.BAL
{
    public class InformaticsBAL
    {
        InformaticsDAL dal = new InformaticsDAL();
        public List<InformaticsBEL> ReadList()
        {
            List<InformaticsBEL> lstCus = dal.ReadList(); 
            return lstCus;
        }
        public InformaticsBEL ReadID(string id)
        {
            return dal.ReadID(id);
        }
       
    }
   
}
