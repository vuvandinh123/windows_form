using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.DAL
{
    //bang cap
    public class DegreeDAL : DBConnection
    {
        public List<DegreeBEL> ReadList()
        {
            return Degree.ToList();
        }
        public DegreeBEL ReadID(string id)
        {
            DegreeBEL employee = this.Degree.Where(m => m.Id == id).FirstOrDefault();

            return employee;
        }

    }
}
