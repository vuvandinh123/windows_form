using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.DAL
{
    public class NationDAL : DBConnection
    {
        public List<NationBEL> ReadList()
        {
            return Nation.ToList();
        }
        public NationBEL ReadID(string id)
        {
            NationBEL employee = this.Nation.Where(m => m.Id == id).FirstOrDefault();

            return employee;
        }

    }
}
