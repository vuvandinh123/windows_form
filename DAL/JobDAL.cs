using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.DAL
{
    public class JobDAL : DBConnection
    {
        public List<JobBEL> ReadList()
        {
            return Job.ToList();
        }
        public JobBEL ReadID(string id)
        {
            JobBEL employee = this.Job.Where(m => m.Id == id).FirstOrDefault();

            return employee;
        }

    }
}
