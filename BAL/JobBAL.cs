using Exercise01.DAL;
using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.BAL
{
    public class JobBAL
    {
        JobDAL dal = new JobDAL();
        public List<JobBEL> ReadList()
        {
            List<JobBEL> lstCus = dal.ReadList(); 
            return lstCus;
        }
        public JobBEL ReadID(string id)
        {
            return dal.ReadID(id);
        }
       
    }
   
}
