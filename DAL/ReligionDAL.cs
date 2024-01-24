using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.DAL
{
    public class ReligionDAL : DBConnection
    {
        public List<ReligionBEL> ReadList()
        {
            return Religion.ToList();
        }
        public ReligionBEL ReadID(string id)
        {
            ReligionBEL employee = this.Religion.Where(m => m.Id == id).FirstOrDefault();

            return employee;
        }

    }
}
