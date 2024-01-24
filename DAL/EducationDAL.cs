using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.DAL
{
    public class EducationDAL : DBConnection
    {
        public List<EducationBEL> ReadList()
        {
            return Education.ToList();
        }
        public EducationBEL ReadID(string id)
        {
            EducationBEL employee = this.Education.Where(m => m.Id == id).FirstOrDefault();

            return employee;
        }

    }
}
