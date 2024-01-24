using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.DAL
{
    public class DBConnection : DbContext
    {
        public DBConnection() : base("name=DB")
        {
        }
        public DbSet<EmployeeBEL> employee { get; set; }
        public DbSet<BankBEL> Bank { get; set; }
        public DbSet<DegreeBEL> Degree { get; set; }
        public DbSet<DepartmentBEL> Department { get; set; }
        public DbSet<EducationBEL> Education { get; set; }
        public DbSet<InformaticsBEL> Informatics { get; set; }
        public DbSet<JobBEL> Job { get; set; }
        public DbSet<LanguageBEL> Language { get; set; }
        public DbSet<NationalityBEL> Nationality { get; set; }
        public DbSet<NationBEL> Nation { get; set; }
        public DbSet<PositionBEL> Position { get; set; }
        public DbSet<ReligionBEL> Religion { get; set; }
        public DbSet<WageBEL> Wage { get; set; }
        public DbSet<TypeEmployeeBEL> TypeEmployee { get; set; }
    }
}
