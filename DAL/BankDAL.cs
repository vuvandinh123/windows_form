using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.DAL
{
    public class BankDAL : DBConnection
    {
        public List<BankBEL> ReadList()
        {
            return Bank.ToList();
        }
        public BankBEL ReadID(string id)
        {
            BankBEL employee = this.Bank.Where(m => m.Id == id).FirstOrDefault();

            return employee;
        }
       
    }
}
