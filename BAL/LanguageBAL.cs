using Exercise01.DAL;
using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.BAL
{
    public class LanguageBAL
    {
        LanguageDAL dal = new LanguageDAL();
        public List<LanguageBEL> ReadList()
        {
            List<LanguageBEL> lstCus = dal.ReadList(); 
            return lstCus;
        }
        public LanguageBEL ReadID(string id)
        {
            return dal.ReadID(id);
        }
       
    }
   
}
