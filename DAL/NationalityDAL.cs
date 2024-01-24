using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.DAL
{
    public class NationalityDAL : DBConnection
    {
        public List<NationalityBEL> ReadList()
        {
            return Nationality.ToList();
        }
        public NationalityBEL ReadID(string id)
        {
            NationalityBEL employee = this.Nationality.Where(m => m.Id == id).FirstOrDefault();

            return employee;
        }

    }
}
