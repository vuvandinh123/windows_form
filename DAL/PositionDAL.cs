using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.DAL
{
    public class PositionDAL : DBConnection
    {
        public List<PositionBEL> ReadList()
        {
            return Position.ToList();
        }
        public PositionBEL ReadID(string id)
        {
            PositionBEL employee = this.Position.Where(m => m.Id == id).FirstOrDefault();

            return employee;
        }

    }
}
