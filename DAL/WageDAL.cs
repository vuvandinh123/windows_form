using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.DAL
{
    public class WageDAL : DBConnection
    {
        public List<WageBEL> ReadList()
        {
            return Wage.ToList();
        }
        public WageBEL ReadID(string id)
        {
            WageBEL employee = this.Wage.Where(m => m.EmployeeID == id).FirstOrDefault();
            return employee;
        }
        public void New(WageBEL em)
        {
            this.Wage.Add(em);
            this.SaveChanges();
        }
        public void Delete(string id)
        {
            WageBEL Delete = this.Wage.Where(m => m.EmployeeID == id).FirstOrDefault();
            this.Wage.Remove(Delete);
            this.SaveChanges();
        }
        public void Edit(WageBEL wa)
        {
            var existing = this.Wage.Where(c => c.EmployeeID == wa.EmployeeID).FirstOrDefault();
            if (existing != null)
            {
                existing.BasicSalary = wa.BasicSalary;
                existing.Allowance = wa.Allowance;
                existing.WageDf = wa.WageDf;
                existing.Coefficients = wa.Coefficients;
                this.Entry(existing).State = EntityState.Modified;
                this.SaveChanges();
            }
            else
            {
                Console.WriteLine("Không tìm thấy khách hàng để cập nhật!");
            }
        }

    }
}
