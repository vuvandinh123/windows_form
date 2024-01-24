using Exercise01.BAL;
using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise01
{
    public partial class Employee : Form
    {

        public string id { get; set; }
        EmployeeBAL emBAL = new EmployeeBAL();
        BankBAL bankBAL = new BankBAL();
        DegreeBAL degreeBAL = new DegreeBAL();
        DepartmentBAL departmentBAL = new DepartmentBAL();
        EducationBAL educationBAL = new EducationBAL();
        InformaticsBAL informaticsBAL = new InformaticsBAL();
        JobBAL jobBAL = new JobBAL();
        LanguageBAL languageBAL = new LanguageBAL();
        NationalityBAL nationalityBAL = new NationalityBAL();
        NationBAL nationBAL = new NationBAL();
        PositionBAL positionBAL = new PositionBAL();
        ReligionBAL religionBAL = new ReligionBAL();
        TypeEmployeeBAL typeEmployeeBAL = new TypeEmployeeBAL();
        WageBAL wageBAL = new WageBAL();
        public Employee()
        {
            InitializeComponent();
        }
        private void LoadForm()
        {
            List<BankBEL> lstBank = bankBAL.ReadList();
            List<DegreeBEL> lstDeg = degreeBAL.ReadList();
            List<DepartmentBEL> lstDep = departmentBAL.ReadList();
            List<EducationBEL> lstEdu = educationBAL.ReadList();
            List<InformaticsBEL> lstInfo = informaticsBAL.ReadList();
            List<JobBEL> lstJob = jobBAL.ReadList();
            List<LanguageBEL> lstLan = languageBAL.ReadList();
            List<NationalityBEL> lstNationality = nationalityBAL.ReadList();
            List<NationBEL> lstNation = nationBAL.ReadList();
            List<PositionBEL> lstPosition = positionBAL.ReadList();
            List<ReligionBEL> lstReli = religionBAL.ReadList();
            List<TypeEmployeeBEL> lastType = typeEmployeeBAL.ReadAreaList();
            foreach (TypeEmployeeBEL item in lastType)
            {
                cb_loainv.Items.Add(item);
            }
            cb_loainv.DisplayMember = "Name";
            foreach (ReligionBEL item in lstReli)
            {
                cb_tongiao.Items.Add(item);
            }
            cb_tongiao.DisplayMember = "Name";
            foreach (PositionBEL item in lstPosition)
            {
                cb_chucvu.Items.Add(item);
            }
            cb_chucvu.DisplayMember = "Name";
            foreach (NationBEL item in lstNation)
            {
                cb_dantoc.Items.Add(item);
            }
            cb_dantoc.DisplayMember = "Name";
            foreach (NationalityBEL item in lstNationality)
            {
                cb_quoctich.Items.Add(item);
            }
            cb_quoctich.DisplayMember = "Name";
            foreach (LanguageBEL item in lstLan)
            {
                cb_ngoaingu.Items.Add(item);
            }
            cb_ngoaingu.DisplayMember = "Name";
            foreach (JobBEL item in lstJob)
            {
                cb_congviec.Items.Add(item);
            }
            cb_congviec.DisplayMember = "Name";
            foreach (InformaticsBEL item in lstInfo)
            {
                cb_tinhoc.Items.Add(item);
            }
            cb_tinhoc.DisplayMember = "Name";
            foreach (EducationBEL item in lstEdu)
            {
                cb_hocvan.Items.Add(item);
            }
            cb_hocvan.DisplayMember = "Name";
            
            foreach (BankBEL bank in lstBank)
            {
                cb_bank.Items.Add(bank);
            }
            cb_bank.DisplayMember = "Name";
            foreach (DegreeBEL deg in lstDeg)
            {
                cb_bangcap.Items.Add(deg);
            }
            cb_bangcap.DisplayMember = "Name";
            foreach (DepartmentBEL item in lstDep)
            {
                cb_phongban.Items.Add(item);
            }
            cb_phongban.DisplayMember = "Name";
            foreach (DepartmentBEL item in lstDep)
            {
                cb_phongban.Items.Add(item);
            }
            cb_phongban.DisplayMember = "Name";

            if (id != null)
            {
                id_nv.ReadOnly = true;
                TypeEmployeeBAL typeEmployeeBAL = new TypeEmployeeBAL();
                EmployeeBEL em = emBAL.ReadEmployeeID(id);
                WageBAL wageBAL = new WageBAL();
                WageBEL wage = new WageBEL();
                wage = wageBAL.ReadID(em.Id);
                id_nv.Text = em.Id;
                tb_name.Text = em.Name;
                tb_email.Text = em.Email;
                dt_ngaysinh.Value = em.Birthday;
                tb_phone.Text = em.Phone;
                dt_ngaycap.Value = em.CIDDate;
                tb_noisinh.Text = em.BirthPlace;
                tb_cccd.Text = em.CIDNumber;
                tb_bidanh.Text = em.Alias;
                checkBox2.Checked = (bool)em.Married;
                checkBox1.Checked = (bool)em.Gender;
                tb_noicap.Text = em.CIDPlaceOfIssue;
                tb_quequan.Text = em.Hometown;
                tb_diachi.Text = em.PermanentAddress;
                tb_tamtru.Text = em.TemporaryAddress;
                tb_sslaodong.Text = em.WorkbookNumber;
                date_ngayvaolam.Value = em.Workday;
                dateTimePicker3.Value = em.WorkbookTime;
                tb_noicapcv.Text = em.WorkbookAddress;
                tb_luongCB.Text = wage.BasicSalary.ToString();
                tb_heso.Text = wage.Coefficients.ToString();
                tb_mucluong.Text = wage.WageDf.ToString();
                tb_phucapluong.Text=wage.Allowance.ToString();
                tb_nganhang.Text = em.BankNumber;
                cb_bank.Text = em.Bank.Name;
                cb_bangcap.Text = em.Degree.Name;
                cb_phongban.Text = em.Department.Name;
                cb_hocvan.Text = em.Education.Name;
                cb_tinhoc.Text = em.Informatics.Name;
                cb_congviec.Text = em.Job.Name;
                cb_ngoaingu.Text = em.Language.Name;
                cb_quoctich.Text = em.Nationality.Name;
                cb_dantoc.Text = em.Nation.Name;
                cb_chucvu.Text = em.Position.Name;
                cb_loainv.Text = em.TypeEmployee.Name;
                cb_tongiao.Text = em.Religion.Name;
                
                if (em.Avatar != null)
                {
                    using (MemoryStream ms = new MemoryStream(em.Avatar))
                    {
                        Image image = Image.FromStream(ms);
                        pictureBox1.Image = image;
                    }
                }


            }
        }
        private void bt_ghi_Click(object sender, EventArgs e)
        {

            EmployeeBEL em = new EmployeeBEL();
            WageBEL wageBEL = new WageBEL();
            if (id_nv.Text == "")
            {
                MessageBox.Show("vui lòng nhập id");
                return;

            }
            else
            {
                em.Id = id_nv.Text;
            }
             EmployeeBEL em2 = emBAL.ReadEmployeeID(id_nv.Text);
            if (tb_name.Text == "")
            {
                MessageBox.Show("vui lòng nhập tên");
                return;
            }
            else
            {
                em.Name = tb_name.Text;

            }
           

            em.Email = tb_email.Text;
            em.Birthday = DateTime.Parse(dt_ngaysinh.Text);
            em.Phone = tb_phone.Text;
            em.CIDDate = DateTime.Parse(dt_ngaycap.Text);
            em.BirthPlace = tb_noisinh.Text;
            em.CIDNumber = tb_cccd.Text;
            em.Alias = tb_bidanh.Text;
            em.Married = checkBox2.Checked;
            em.CIDPlaceOfIssue = tb_noicap.Text;
            em.Gender = checkBox1.Checked;
            em.Hometown = tb_quequan.Text;
            em.PermanentAddress = tb_diachi.Text;
            em.TemporaryAddress = tb_tamtru.Text;
            if(cb_bank.SelectedItem != null)
            {
                em.Bank = (BankBEL)cb_bank.SelectedItem;
            }
            
            if (cb_bangcap.SelectedItem != null)
            {
                em.Degree = (DegreeBEL)cb_bangcap.SelectedItem;
            }
            if (cb_phongban.SelectedItem != null)
            {
                em.Department = (DepartmentBEL)cb_phongban.SelectedItem;
            }
            else
            {
                MessageBox.Show("vui lòng nhập phòng ban");
                return;
            }
            if (cb_hocvan.SelectedItem != null)
            {
                em.Education = (EducationBEL)cb_hocvan.SelectedItem;
            }
            if (cb_tinhoc.SelectedItem != null)
            {
                em.Informatics = (InformaticsBEL)cb_tinhoc.SelectedItem;

            }
            if (cb_congviec.SelectedItem != null)
            {
                em.Job = (JobBEL)cb_congviec.SelectedItem;

            }
            if (cb_congviec.SelectedItem != null)
            {
                em.Job = (JobBEL)cb_congviec.SelectedItem;

            }
            if (cb_ngoaingu.SelectedItem != null)
            {
                em.Language = (LanguageBEL)cb_ngoaingu.SelectedItem;


            }
            if (cb_quoctich.SelectedItem != null)
            {
                em.Nationality = (NationalityBEL)cb_quoctich.SelectedItem;

            }
            if (cb_dantoc.SelectedItem != null)
            {
                em.Nation = (NationBEL)cb_dantoc.SelectedItem;

            }
            if (cb_chucvu.SelectedItem != null)
            {
                em.Position = (PositionBEL)cb_chucvu.SelectedItem;
            }
            else
            {
                MessageBox.Show("vui lòng nhập chức vụ");
                return;
            }
            if (cb_tongiao.SelectedItem != null)
            {
                em.Religion = (ReligionBEL)cb_tongiao.SelectedItem;


            }
            if (cb_loainv.SelectedItem != null)
            {
                em.TypeEmployee = (TypeEmployeeBEL)cb_loainv.SelectedItem;
            }
            else
            {
                MessageBox.Show("vui lòng nhập loại nhân viên");
                return;
            }
            em.Workday = DateTime.Parse(date_ngayvaolam.Text);

            em.WorkbookTime = DateTime.Parse(dateTimePicker3.Text);
            em.WorkbookNumber = tb_sslaodong.Text;
            em.WorkbookAddress = tb_noicapcv.Text;
            em.BankNumber = tb_nganhang.Text;
            if (tb_luongCB.Text != "")
            {
                wageBEL.BasicSalary = float.Parse(tb_luongCB.Text);
            }
            else
            {
                MessageBox.Show("vui lòng nhập luong co ban");
                return;
            }
            if (tb_heso.Text != "")
            {
                wageBEL.Coefficients = int.Parse(tb_heso.Text);
            }
            else
            {
                MessageBox.Show("vui lòng nhập luong hệ số");
                return;
            }
            if (tb_mucluong.Text != "")
            {
                wageBEL.WageDf = float.Parse(tb_mucluong.Text);
            }
            if (tb_phucapluong.Text != "")
            {
                wageBEL.Allowance = float.Parse(tb_phucapluong.Text);
            }
            wageBEL.EmployeeID = id_nv.Text;
            Image image = pictureBox1.Image;
            byte[] imageBytes;
            if (image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imageBytes = ms.ToArray();
                }
                em.Avatar = imageBytes;
            }

            if (em2 == null)
            {
                WageBAL wageBAL = new WageBAL();

                wageBAL.New(wageBEL);
                emBAL.NewEmployee(em);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                emBAL.EditEmployee(em);
                wageBAL = new WageBAL();
                wageBAL.Edit(wageBEL);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.png;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image image = new Bitmap(openFileDialog.FileName);
                int targetWidth = 3 * pictureBox1.Height / 4;
                Image resizedImage = new Bitmap(image, new Size(targetWidth, pictureBox1.Height));

                pictureBox1.Image = resizedImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }
        private void validate_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
