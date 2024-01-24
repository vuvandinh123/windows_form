using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.DAL
{
    public class LanguageDAL : DBConnection
    {
        public List<LanguageBEL> ReadList()
        {
            return Language.ToList();
        }
        public LanguageBEL ReadID(string id)
        {
            LanguageBEL employee = this.Language.Where(m => m.Id == id).FirstOrDefault();

            return employee;
        }

    }
}
