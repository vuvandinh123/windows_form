using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.DAL
{
    public class EmployeeDAL : DBConnection
    {
        public List<EmployeeBEL> ReadEmployeeList()
        {
            return employee.ToList();
        }
        public EmployeeBEL ReadEmployeeID(string id)
        {
            EmployeeBEL employee = this.employee.Where(m => m.Id == id).FirstOrDefault();

            return employee;
        }
        public void NewEmployee(EmployeeBEL em)
        {
            var bank = this.Bank.Where(m => m.Id == em.Bank.Id).FirstOrDefault();
            var degree = this.Degree.Where(m => m.Id == em.Degree.Id).FirstOrDefault();
            var dep = this.Department.Where(m => m.Id == em.Department.Id).FirstOrDefault();
            var edu = this.Education.Where(m => m.Id == em.Education.Id).FirstOrDefault();
            var info = this.Informatics.Where(m => m.Id == em.Informatics.Id).FirstOrDefault();
            var job = this.Job.Where(m => m.Id == em.Job.Id).FirstOrDefault();
            var lan = this.Language.Where(m => m.Id == em.Language.Id).FirstOrDefault();
            var nation = this.Nation.Where(m => m.Id == em.Nation.Id).FirstOrDefault();
            var nationali = this.Nationality.Where(m => m.Id == em.Nationality.Id).FirstOrDefault();
            var pos = this.Position.Where(m => m.Id == em.Position.Id).FirstOrDefault();
            var religion = this.Religion.Where(m => m.Id == em.Religion.Id).FirstOrDefault();
            var type = this.TypeEmployee.Where(m => m.Id == em.TypeEmployee.Id).FirstOrDefault();
            em.Bank = bank;
            em.Degree = degree;
            em.Department = dep;
            em.Education = edu;
            em.Informatics = info;
            em.Job = job;
            em.Language = lan;
            em.Nation = nation;
            em.Nationality = nationali;
            em.Position = pos;
            em.Religion = religion;
            em.TypeEmployee = type;
            this.employee.Add(em);
            this.SaveChanges();
        }
        public void DeleteEmployee(string id)
        {
            EmployeeBEL employeeToDelete = this.employee.Where(m => m.Id == id).FirstOrDefault();
            this.employee.Remove(employeeToDelete);
            this.SaveChanges();
        }
        public void EditEmployee(EmployeeBEL em)
        {

            var edit = this.employee.Where(c => c.Id == em.Id).FirstOrDefault();

            var bank = this.Bank.Where(m => m.Id == em.Bank.Id).FirstOrDefault();
            em.Bank = bank;
            var deg = this.Degree.Where(m => m.Id == em.Degree.Id).FirstOrDefault();
            em.Degree = deg;

            var dep = this.Department.Where(m => m.Id == em.Department.Id).FirstOrDefault();
            em.Department = dep;

            var edu = this.Education.Where(m => m.Id == em.Education.Id).FirstOrDefault();
            em.Education = edu;

            var info = this.Informatics.Where(m => m.Id == em.Informatics.Id).FirstOrDefault();
            em.Informatics = info;

            var job = this.Job.Where(m => m.Id == em.Job.Id).FirstOrDefault();
            em.Job = job;

            var lan = this.Language.Where(m => m.Id == em.Language.Id).FirstOrDefault();
            em.Language = lan;

            var na = this.Nationality.Where(m => m.Id == em.Nationality.Id).FirstOrDefault();
            em.Nationality = na;

            var nation = this.Nation.Where(m => m.Id == em.Nation.Id).FirstOrDefault();
            em.Nation = nation;

            var po = this.Position.Where(m => m.Id == em.Position.Id).FirstOrDefault();
            em.Position = po;

            var re = this.Religion.Where(m => m.Id == em.Religion.Id).FirstOrDefault();
            em.Religion = re;

            var type = this.TypeEmployee.Where(m => m.Id == em.TypeEmployee.Id).FirstOrDefault();
            em.TypeEmployee = type;


            this.Entry(edit).CurrentValues.SetValues(em);
            this.SaveChanges();
        }
    }
}
