using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.DAL
{
    public class InformaticsDAL : DBConnection
    {
        public List<InformaticsBEL> ReadList()
        {
            return Informatics.ToList();
        }
        public InformaticsBEL ReadID(string id)
        {
            InformaticsBEL employee = this.Informatics.Where(m => m.Id == id).FirstOrDefault();

            return employee;
        }

    }
}
