using Exercise01.DAL;
using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.BAL
{
    public class WageBAL
    {
        WageDAL dal = new WageDAL();
        public List<WageBEL> ReadList()
        {
            List<WageBEL> lstCus = dal.ReadList(); 
            return lstCus;
        }
        public WageBEL ReadID(string id)
        {
            return dal.ReadID(id);
        }
        public void New(WageBEL wa)
        {
            dal.New(wa);
        }
        public void Edit(WageBEL wa)
        {
            dal.Edit(wa);
        }
        public void Delete(string id)
        {
            dal.Delete(id);
        }
    }
   
}
