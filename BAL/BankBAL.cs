using Exercise01.DAL;
using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.BAL
{
    public class BankBAL
    {
        BankDAL dal = new BankDAL();
        public List<BankBEL> ReadList()
        {
            List<BankBEL> lstCus = dal.ReadList(); 
            return lstCus;
        }
        public BankBEL ReadID(string id)
        {
            return dal.ReadID(id);
        }
       
    }
   
}
