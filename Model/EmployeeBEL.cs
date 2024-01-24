using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Exercise01.Model
{
    public class EmployeeBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(50)]
        public string Id { get; set; }
        public string Name { get; set; }
        public bool? Gender { get; set; }
        public bool? Married { get; set; }
        public string Phone { get; set; }
        public string Alias { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string BirthPlace { get; set; }
        public string CIDNumber { get; set; }
        public DateTime CIDDate { get; set; }
        public string CIDPlaceOfIssue { get; set; }
        public string Hometown { get; set; }
        public string PermanentAddress { get; set; }
        public string TemporaryAddress { get; set; }
        public byte[] Avatar { get; set; }
        //public string BankID { get; set; }
        //public string DegreeID { get; set; }
        //public string DepartmentID { get; set; }
        //public string EducationID { get; set; }
        //public string InformaticsID { get; set; }
        //public string JobID { get; set; }
        //public string LanguageID { get; set; }
        //public string NationalityID { get; set; }
        //public string NationID { get; set; }
        //public string PositionID { get; set; }
        //public string ReligionID { get; set; }
        //public string TypeEmployeeID { get; set; }
        public DateTime Workday { get; set; }
        public string WorkbookNumber { get; set; }
        public DateTime WorkbookTime { get; set; }
        public string WorkbookAddress { get; set; }
        public string BankNumber { get; set; }

        public virtual BankBEL Bank { get; set; }
        public virtual DegreeBEL Degree { get; set; }
        public virtual DepartmentBEL Department { get; set; }
        public virtual EducationBEL Education { get; set; }
        public virtual InformaticsBEL Informatics { get; set; }
        public virtual JobBEL Job { get; set; }
        public virtual LanguageBEL Language { get; set; }
        public virtual NationBEL Nation { get; set; }
        public virtual NationalityBEL Nationality { get; set; }
        public virtual PositionBEL Position { get; set; }
        public virtual ReligionBEL Religion { get; set; }
        public virtual TypeEmployeeBEL TypeEmployee { get; set; }


    }
}
