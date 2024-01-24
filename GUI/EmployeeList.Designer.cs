namespace Exercise01.GUI
{
    partial class EmployeeList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.giadinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noisinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaycap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noicap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamchu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loainv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayvaolam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.congviec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucluongcb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phucap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sslaodong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaycap2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noicap2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banknumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bangcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngoaingu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dantoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_in = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.birthday,
            this.bidanh,
            this.gioitinh,
            this.giadinh,
            this.phone,
            this.email,
            this.CCCD,
            this.noisinh,
            this.ngaycap,
            this.noicap,
            this.quequan,
            this.diachi,
            this.tamchu,
            this.loainv,
            this.ngayvaolam,
            this.phongban,
            this.congviec,
            this.chucvu,
            this.mucluongcb,
            this.heso,
            this.mucluong,
            this.phucap,
            this.sslaodong,
            this.ngaycap2,
            this.noicap2,
            this.banknumber,
            this.bank,
            this.hocvan,
            this.bangcap,
            this.ngoaingu,
            this.tinhoc,
            this.dantoc,
            this.tongiao});
            this.dgvCustomer.Location = new System.Drawing.Point(13, 12);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(1405, 324);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Mã nhân viên";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Họ tên";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 200;
            // 
            // birthday
            // 
            this.birthday.HeaderText = "Ngày sinh";
            this.birthday.MinimumWidth = 6;
            this.birthday.Name = "birthday";
            this.birthday.Width = 125;
            // 
            // bidanh
            // 
            this.bidanh.HeaderText = "Bí danh";
            this.bidanh.MinimumWidth = 6;
            this.bidanh.Name = "bidanh";
            this.bidanh.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.HeaderText = "Nữ";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gioitinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gioitinh.Width = 70;
            // 
            // giadinh
            // 
            this.giadinh.HeaderText = "Có gia đình";
            this.giadinh.MinimumWidth = 6;
            this.giadinh.Name = "giadinh";
            this.giadinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.giadinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.giadinh.Width = 125;
            // 
            // phone
            // 
            this.phone.HeaderText = "Di động";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.Width = 150;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 150;
            // 
            // CCCD
            // 
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.MinimumWidth = 6;
            this.CCCD.Name = "CCCD";
            this.CCCD.Width = 150;
            // 
            // noisinh
            // 
            this.noisinh.HeaderText = "Nơi Sinh";
            this.noisinh.MinimumWidth = 6;
            this.noisinh.Name = "noisinh";
            this.noisinh.Width = 200;
            // 
            // ngaycap
            // 
            this.ngaycap.HeaderText = "Ngày cấp";
            this.ngaycap.MinimumWidth = 6;
            this.ngaycap.Name = "ngaycap";
            this.ngaycap.Width = 150;
            // 
            // noicap
            // 
            this.noicap.HeaderText = "Nơi cấp";
            this.noicap.MinimumWidth = 6;
            this.noicap.Name = "noicap";
            this.noicap.Width = 150;
            // 
            // quequan
            // 
            this.quequan.HeaderText = "Quê quán";
            this.quequan.MinimumWidth = 6;
            this.quequan.Name = "quequan";
            this.quequan.Width = 200;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 250;
            // 
            // tamchu
            // 
            this.tamchu.HeaderText = "Tạm chú";
            this.tamchu.MinimumWidth = 6;
            this.tamchu.Name = "tamchu";
            this.tamchu.Width = 250;
            // 
            // loainv
            // 
            this.loainv.HeaderText = "Loại nhân viên";
            this.loainv.MinimumWidth = 6;
            this.loainv.Name = "loainv";
            this.loainv.Width = 150;
            // 
            // ngayvaolam
            // 
            this.ngayvaolam.HeaderText = "Ngày vào làm";
            this.ngayvaolam.MinimumWidth = 6;
            this.ngayvaolam.Name = "ngayvaolam";
            this.ngayvaolam.Width = 150;
            // 
            // phongban
            // 
            this.phongban.HeaderText = "Phòng ban";
            this.phongban.MinimumWidth = 6;
            this.phongban.Name = "phongban";
            this.phongban.Width = 150;
            // 
            // congviec
            // 
            this.congviec.HeaderText = "Công việc";
            this.congviec.MinimumWidth = 6;
            this.congviec.Name = "congviec";
            this.congviec.Width = 150;
            // 
            // chucvu
            // 
            this.chucvu.HeaderText = "Chức vụ";
            this.chucvu.MinimumWidth = 6;
            this.chucvu.Name = "chucvu";
            this.chucvu.Width = 125;
            // 
            // mucluongcb
            // 
            this.mucluongcb.HeaderText = "Mức lương cơ bản";
            this.mucluongcb.MinimumWidth = 6;
            this.mucluongcb.Name = "mucluongcb";
            this.mucluongcb.Width = 125;
            // 
            // heso
            // 
            this.heso.HeaderText = "Hệ số";
            this.heso.MinimumWidth = 6;
            this.heso.Name = "heso";
            this.heso.Width = 125;
            // 
            // mucluong
            // 
            this.mucluong.HeaderText = "Mức lương";
            this.mucluong.MinimumWidth = 6;
            this.mucluong.Name = "mucluong";
            this.mucluong.Width = 125;
            // 
            // phucap
            // 
            this.phucap.HeaderText = "Phụ cấp lương";
            this.phucap.MinimumWidth = 6;
            this.phucap.Name = "phucap";
            this.phucap.Width = 125;
            // 
            // sslaodong
            // 
            this.sslaodong.HeaderText = "Số sổ lao động";
            this.sslaodong.MinimumWidth = 6;
            this.sslaodong.Name = "sslaodong";
            this.sslaodong.Width = 125;
            // 
            // ngaycap2
            // 
            this.ngaycap2.HeaderText = "Ngày cấp";
            this.ngaycap2.MinimumWidth = 6;
            this.ngaycap2.Name = "ngaycap2";
            this.ngaycap2.Width = 125;
            // 
            // noicap2
            // 
            this.noicap2.HeaderText = "Lơi cấp";
            this.noicap2.MinimumWidth = 6;
            this.noicap2.Name = "noicap2";
            this.noicap2.Width = 150;
            // 
            // banknumber
            // 
            this.banknumber.HeaderText = "TK. Ngân hàng";
            this.banknumber.MinimumWidth = 6;
            this.banknumber.Name = "banknumber";
            this.banknumber.Width = 125;
            // 
            // bank
            // 
            this.bank.HeaderText = "Ngân hàng";
            this.bank.MinimumWidth = 6;
            this.bank.Name = "bank";
            this.bank.Width = 125;
            // 
            // hocvan
            // 
            this.hocvan.HeaderText = "Học vấn ";
            this.hocvan.MinimumWidth = 6;
            this.hocvan.Name = "hocvan";
            this.hocvan.Width = 125;
            // 
            // bangcap
            // 
            this.bangcap.HeaderText = "Bằng cấp";
            this.bangcap.MinimumWidth = 6;
            this.bangcap.Name = "bangcap";
            this.bangcap.Width = 125;
            // 
            // ngoaingu
            // 
            this.ngoaingu.HeaderText = "Ngoại ngữ";
            this.ngoaingu.MinimumWidth = 6;
            this.ngoaingu.Name = "ngoaingu";
            this.ngoaingu.Width = 125;
            // 
            // tinhoc
            // 
            this.tinhoc.HeaderText = "Tin học";
            this.tinhoc.MinimumWidth = 6;
            this.tinhoc.Name = "tinhoc";
            this.tinhoc.Width = 125;
            // 
            // dantoc
            // 
            this.dantoc.HeaderText = "Dân tộc";
            this.dantoc.MinimumWidth = 6;
            this.dantoc.Name = "dantoc";
            this.dantoc.Width = 125;
            // 
            // tongiao
            // 
            this.tongiao.HeaderText = "Tôn giáo";
            this.tongiao.MinimumWidth = 6;
            this.tongiao.Name = "tongiao";
            this.tongiao.Width = 125;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1342, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btNew
            // 
            this.btNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btNew.Location = new System.Drawing.Point(1099, 342);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(75, 35);
            this.btNew.TabIndex = 2;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_edit.Location = new System.Drawing.Point(1180, 342);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(75, 35);
            this.bt_edit.TabIndex = 3;
            this.bt_edit.Text = "Sửa";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_delete.Location = new System.Drawing.Point(1261, 342);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 35);
            this.bt_delete.TabIndex = 4;
            this.bt_delete.Text = "Xóa";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_in
            // 
            this.bt_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_in.Location = new System.Drawing.Point(13, 342);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(75, 35);
            this.bt_in.TabIndex = 5;
            this.bt_in.Text = "In";
            this.bt_in.UseVisualStyleBackColor = true;
            this.bt_in.Click += new System.EventHandler(this.bt_in_Click);
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 389);
            this.Controls.Add(this.bt_in);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCustomer);
            this.Name = "EmployeeList";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.EmployeeList_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidanh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn giadinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn noisinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaycap;
        private System.Windows.Forms.DataGridViewTextBoxColumn noicap;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamchu;
        private System.Windows.Forms.DataGridViewTextBoxColumn loainv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayvaolam;
        private System.Windows.Forms.DataGridViewTextBoxColumn phongban;
        private System.Windows.Forms.DataGridViewTextBoxColumn congviec;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn mucluongcb;
        private System.Windows.Forms.DataGridViewTextBoxColumn heso;
        private System.Windows.Forms.DataGridViewTextBoxColumn mucluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn phucap;
        private System.Windows.Forms.DataGridViewTextBoxColumn sslaodong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaycap2;
        private System.Windows.Forms.DataGridViewTextBoxColumn noicap2;
        private System.Windows.Forms.DataGridViewTextBoxColumn banknumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn bangcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngoaingu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dantoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongiao;
    }
}