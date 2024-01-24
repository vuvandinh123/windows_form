using Exercise01.BAL;
using Exercise01.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;

namespace Exercise01.GUI
{
    public partial class EmployeeList : Form
    {
        EmployeeBAL emBAL = new EmployeeBAL();
        WageBAL Wage = new WageBAL();
        private BindingList<EmployeeBAL> employeeList = new BindingList<EmployeeBAL>();
        public EmployeeList()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            var result =  emp.ShowDialog();
            if (result == DialogResult.OK)
            {
                Loadf();
            }
        }
        private void Loadf()
        {
            EmployeeBAL emp = new EmployeeBAL();
            List<EmployeeBEL> lstEm = emp.ReadEmployeeList();

            dgvCustomer.Rows.Clear();
            foreach (EmployeeBEL em in lstEm)
            {
                WageBAL wageBAL = new WageBAL();
                WageBEL wageBEL = new WageBEL();
                wageBEL = wageBAL.ReadID(em.Id);
                int rowIndex = dgvCustomer.Rows.Add();
                dgvCustomer.Rows[rowIndex].Cells["id"].Value = em.Id;
                dgvCustomer.Rows[rowIndex].Cells["name"].Value = em.Name;
                dgvCustomer.Rows[rowIndex].Cells["bidanh"].Value = em.Alias;
                dgvCustomer.Rows[rowIndex].Cells["gioitinh"].Value = em.Gender;
                dgvCustomer.Rows[rowIndex].Cells["giadinh"].Value = em.Married;
                dgvCustomer.Rows[rowIndex].Cells["phone"].Value = em.Phone;
                dgvCustomer.Rows[rowIndex].Cells["email"].Value = em.Email;
                dgvCustomer.Rows[rowIndex].Cells["birthday"].Value = em.Birthday;
                dgvCustomer.Rows[rowIndex].Cells["CCCD"].Value = em.CIDNumber;
                dgvCustomer.Rows[rowIndex].Cells["noisinh"].Value = em.BirthPlace;
                dgvCustomer.Rows[rowIndex].Cells["ngaycap"].Value = em.CIDDate;
                dgvCustomer.Rows[rowIndex].Cells["noicap"].Value = em.CIDPlaceOfIssue;
                dgvCustomer.Rows[rowIndex].Cells["quequan"].Value = em.Hometown;
                dgvCustomer.Rows[rowIndex].Cells["diachi"].Value = em.PermanentAddress;
                dgvCustomer.Rows[rowIndex].Cells["tamchu"].Value = em.TemporaryAddress;
                dgvCustomer.Rows[rowIndex].Cells["loainv"].Value = em.TypeEmployee.Name;

                dgvCustomer.Rows[rowIndex].Cells["ngayvaolam"].Value = em.Workday;
                dgvCustomer.Rows[rowIndex].Cells["phongban"].Value = em.Department.Name;
                dgvCustomer.Rows[rowIndex].Cells["congviec"].Value = em.Job.Name;
                dgvCustomer.Rows[rowIndex].Cells["chucvu"].Value = em.Position.Name;

                dgvCustomer.Rows[rowIndex].Cells["mucluongcb"].Value = wageBEL.BasicSalary;
                dgvCustomer.Rows[rowIndex].Cells["heso"].Value = wageBEL.Coefficients;
                dgvCustomer.Rows[rowIndex].Cells["mucluong"].Value =wageBEL.WageDf;
                dgvCustomer.Rows[rowIndex].Cells["phucap"].Value = wageBEL.Allowance;

                dgvCustomer.Rows[rowIndex].Cells["sslaodong"].Value = em.WorkbookNumber;
                dgvCustomer.Rows[rowIndex].Cells["ngaycap2"].Value = em.WorkbookTime;
                dgvCustomer.Rows[rowIndex].Cells["noicap2"].Value = em.WorkbookAddress;

                dgvCustomer.Rows[rowIndex].Cells["banknumber"].Value = em.BankNumber;
                dgvCustomer.Rows[rowIndex].Cells["bank"].Value = em.Bank.Name;
                dgvCustomer.Rows[rowIndex].Cells["hocvan"].Value = em.Education.Name;
                dgvCustomer.Rows[rowIndex].Cells["bangcap"].Value = em.Degree.Name;
                dgvCustomer.Rows[rowIndex].Cells["ngoaingu"].Value = em.Language.Name;
                dgvCustomer.Rows[rowIndex].Cells["tinhoc"].Value = em.Informatics.Name;
                dgvCustomer.Rows[rowIndex].Cells["dantoc"].Value = em.Nation.Name;
                dgvCustomer.Rows[rowIndex].Cells["tongiao"].Value = em.Religion.Name;

            }
            dgvCustomer.Refresh();
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            EmployeeBAL emBAL2 = new EmployeeBAL();

            DataGridViewRow selectedRow = dgvCustomer.CurrentRow;
            Employee emp = new Employee();
            emp.id = Convert.ToString(selectedRow.Cells[0].Value);
            var result2 = emp.ShowDialog();
            if (result2 == DialogResult.OK)
            {
                Loadf();
            }



        }

        private void EmployeeList_Load_1(object sender, EventArgs e)
        {
            Loadf();

        }
        private void bt_delete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvCustomer.CurrentRow;
            
            if (selectedRow != null)
            {
                string index = Convert.ToString(selectedRow.Cells[0].Value);
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thoát",
                 MessageBoxButtons.OKCancel);

                if (result == DialogResult.Cancel)
                {
                    
                }
                else
                {
                    emBAL.DeleteEmployee(index);
                    Wage.Delete(index);
                    Loadf();
                }
                
            }
        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            List<EmployeeBEL> lstEm = emBAL.ReadEmployeeList();
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("WageData");

                worksheet.Cell(1, 1).Value = "Mã";
                worksheet.Cell(1, 2).Value = "Tên";
                worksheet.Cell(1, 3).Value = "Giới tính";
                worksheet.Cell(1, 4).Value = "Đã kết hôn";
                worksheet.Cell(1, 5).Value = "Điện thoại";
                worksheet.Cell(1, 6).Value = "Tên gọi khác";
                worksheet.Cell(1, 7).Value = "Email";
                worksheet.Cell(1, 8).Value = "Ngày sinh";
                worksheet.Cell(1, 9).Value = "Nơi sinh";
                worksheet.Cell(1, 10).Value = "Số CMND";
                worksheet.Cell(1, 11).Value = "Ngày cấp CMND";
                worksheet.Cell(1, 12).Value = "Nơi cấp CMND";
                worksheet.Cell(1, 13).Value = "Quê quán";
                worksheet.Cell(1, 14).Value = "Địa chỉ thường trú";
                worksheet.Cell(1, 15).Value = "Địa chỉ tạm trú";
                worksheet.Cell(1, 16).Value = "Ảnh đại diện";
                worksheet.Cell(1, 17).Value = "Mã ngân hàng";
                worksheet.Cell(1, 18).Value = "Mã bằng cấp";
                worksheet.Cell(1, 19).Value = "Mã phòng ban";
                worksheet.Cell(1, 20).Value = "Mã trình độ học vấn";
                worksheet.Cell(1, 21).Value = "Mã khóa học";
                worksheet.Cell(1, 22).Value = "Mã công việc";
                worksheet.Cell(1, 23).Value = "Mã ngôn ngữ";
                worksheet.Cell(1, 24).Value = "Mã quốc tịch";
                worksheet.Cell(1, 25).Value = "Mã dân tộc";
                worksheet.Cell(1, 26).Value = "Mã chức vụ";
                worksheet.Cell(1, 27).Value = "Mã tôn giáo";
                worksheet.Cell(1, 28).Value = "Mã loại nhân viên";
                worksheet.Cell(1, 29).Value = "Ngày bắt đầu công tác";
                worksheet.Cell(1, 30).Value = "Số sổ bảo hiểm xã hội";
                worksheet.Cell(1, 31).Value = "Ngày cấp sổ bảo hiểm xã hội";
                worksheet.Cell(1, 32).Value = "Nơi cấp sổ bảo hiểm xã hội";
                worksheet.Cell(1, 33).Value = "Số tài khoản ngân hàng";

                // Điền dữ liệu vào tệp tin Excel
                for (int i = 0; i < lstEm.Count; i++)
                {
                    var nhanVien = lstEm[i];
                    worksheet.Cell(i + 2, 1).Value = nhanVien.Id;
                    worksheet.Cell(i + 2, 2).Value = nhanVien.Name;
                    worksheet.Cell(i + 2, 3).Value = nhanVien.Gender.ToString();
                    worksheet.Cell(i + 2, 4).Value = nhanVien.Married.ToString();
                    worksheet.Cell(i + 2, 5).Value = nhanVien.Phone;
                    worksheet.Cell(i + 2, 6).Value = nhanVien.Alias;
                    worksheet.Cell(i + 2, 7).Value = nhanVien.Email;
                    worksheet.Cell(i + 2, 8).Value = nhanVien.Birthday;
                    worksheet.Cell(i + 2, 9).Value = nhanVien.BirthPlace;
                    worksheet.Cell(i + 2, 10).Value = nhanVien.CIDNumber;
                    worksheet.Cell(i + 2, 11).Value = nhanVien.CIDDate;
                    worksheet.Cell(i + 2, 12).Value = nhanVien.CIDPlaceOfIssue;
                    worksheet.Cell(i + 2, 13).Value = nhanVien.Hometown;
                    worksheet.Cell(i + 2, 14).Value = nhanVien.PermanentAddress;
                    worksheet.Cell(i + 2, 15).Value = nhanVien.TemporaryAddress;
                    worksheet.Cell(i + 2, 17).Value = nhanVien.Bank.Name;
                    worksheet.Cell(i + 2, 18).Value = nhanVien.Degree.Name;
                    worksheet.Cell(i + 2, 19).Value = nhanVien.Department.Name;
                    worksheet.Cell(i + 2, 20).Value = nhanVien.Education.Name;
                    worksheet.Cell(i + 2, 21).Value = nhanVien.Informatics.Name;
                    worksheet.Cell(i + 2, 22).Value = nhanVien.Job.Name;
                    worksheet.Cell(i + 2, 23).Value = nhanVien.Language.Name;
                    worksheet.Cell(i + 2, 24).Value = nhanVien.Nationality.Name;
                    worksheet.Cell(i + 2, 25).Value = nhanVien.Nation.Name;
                    worksheet.Cell(i + 2, 26).Value = nhanVien.Position.Name;
                    worksheet.Cell(i + 2, 27).Value = nhanVien.Religion.Name;
                    worksheet.Cell(i + 2, 28).Value = nhanVien.TypeEmployee.Name;
                    worksheet.Cell(i + 2, 29).Value = nhanVien.Workday;
                    worksheet.Cell(i + 2, 30).Value = nhanVien.WorkbookNumber;
                    worksheet.Cell(i + 2, 31).Value = nhanVien.WorkbookTime;
                    worksheet.Cell(i + 2, 32).Value = nhanVien.WorkbookAddress;
                    worksheet.Cell(i + 2, 33).Value = nhanVien.BankNumber;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Chọn nơi lưu tệp tin Excel";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string duongDanLuu = saveFileDialog.FileName;
                    if (File.Exists(duongDanLuu))
                    {
                        File.Delete(duongDanLuu);
                    }
                    workbook.SaveAs(duongDanLuu);
                }
            }
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
