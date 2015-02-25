namespace BKI_QLTTQuocAnh.NghiepVu
{
    partial class f316_nghi_hoc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f316_nghi_hoc));
            this.m_dat_tu_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_tu_ngay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.m_lbl_tong_so_hoc_sinh = new System.Windows.Forms.Label();
            this.m_cbo_hs = new System.Windows.Forms.ComboBox();
            this.m_lbl_chon_hoc_sinh = new System.Windows.Forms.Label();
            this.m_cbo_lop_mon = new System.Windows.Forms.ComboBox();
            this.m_lbl_tong_so = new System.Windows.Forms.Label();
            this.m_lbl_lop_mon = new System.Windows.Forms.Label();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_nghi_hoc = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.panel1.SuspendLayout();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_dat_tu_ngay
            // 
            this.m_dat_tu_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dat_tu_ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dat_tu_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_tu_ngay.Location = new System.Drawing.Point(191, 76);
            this.m_dat_tu_ngay.Name = "m_dat_tu_ngay";
            this.m_dat_tu_ngay.Size = new System.Drawing.Size(232, 35);
            this.m_dat_tu_ngay.TabIndex = 2;
            // 
            // m_lbl_tu_ngay
            // 
            this.m_lbl_tu_ngay.AutoSize = true;
            this.m_lbl_tu_ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tu_ngay.Location = new System.Drawing.Point(22, 82);
            this.m_lbl_tu_ngay.Name = "m_lbl_tu_ngay";
            this.m_lbl_tu_ngay.Size = new System.Drawing.Size(105, 29);
            this.m_lbl_tu_ngay.TabIndex = 1;
            this.m_lbl_tu_ngay.Text = "Tại ngày";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_lbl_tong_so_hoc_sinh);
            this.panel1.Controls.Add(this.m_cbo_hs);
            this.panel1.Controls.Add(this.m_lbl_chon_hoc_sinh);
            this.panel1.Controls.Add(this.m_cbo_lop_mon);
            this.panel1.Controls.Add(this.m_lbl_tong_so);
            this.panel1.Controls.Add(this.m_lbl_lop_mon);
            this.panel1.Controls.Add(this.m_lbl_header);
            this.panel1.Controls.Add(this.m_dat_tu_ngay);
            this.panel1.Controls.Add(this.m_lbl_tu_ngay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 318);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(692, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "HS";
            // 
            // m_lbl_tong_so_hoc_sinh
            // 
            this.m_lbl_tong_so_hoc_sinh.AutoSize = true;
            this.m_lbl_tong_so_hoc_sinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tong_so_hoc_sinh.Location = new System.Drawing.Point(645, 143);
            this.m_lbl_tong_so_hoc_sinh.Name = "m_lbl_tong_so_hoc_sinh";
            this.m_lbl_tong_so_hoc_sinh.Size = new System.Drawing.Size(25, 29);
            this.m_lbl_tong_so_hoc_sinh.TabIndex = 6;
            this.m_lbl_tong_so_hoc_sinh.Text = "  ";
            // 
            // m_cbo_hs
            // 
            this.m_cbo_hs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_hs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cbo_hs.FormattingEnabled = true;
            this.m_cbo_hs.Location = new System.Drawing.Point(191, 206);
            this.m_cbo_hs.Name = "m_cbo_hs";
            this.m_cbo_hs.Size = new System.Drawing.Size(358, 37);
            this.m_cbo_hs.TabIndex = 9;
            // 
            // m_lbl_chon_hoc_sinh
            // 
            this.m_lbl_chon_hoc_sinh.AutoSize = true;
            this.m_lbl_chon_hoc_sinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_chon_hoc_sinh.Location = new System.Drawing.Point(22, 214);
            this.m_lbl_chon_hoc_sinh.Name = "m_lbl_chon_hoc_sinh";
            this.m_lbl_chon_hoc_sinh.Size = new System.Drawing.Size(109, 29);
            this.m_lbl_chon_hoc_sinh.TabIndex = 8;
            this.m_lbl_chon_hoc_sinh.Text = "Chọn HS";
            // 
            // m_cbo_lop_mon
            // 
            this.m_cbo_lop_mon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_lop_mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cbo_lop_mon.FormattingEnabled = true;
            this.m_cbo_lop_mon.Location = new System.Drawing.Point(191, 140);
            this.m_cbo_lop_mon.Name = "m_cbo_lop_mon";
            this.m_cbo_lop_mon.Size = new System.Drawing.Size(297, 37);
            this.m_cbo_lop_mon.TabIndex = 4;
            // 
            // m_lbl_tong_so
            // 
            this.m_lbl_tong_so.AutoSize = true;
            this.m_lbl_tong_so.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tong_so.Location = new System.Drawing.Point(499, 143);
            this.m_lbl_tong_so.Name = "m_lbl_tong_so";
            this.m_lbl_tong_so.Size = new System.Drawing.Size(114, 29);
            this.m_lbl_tong_so.TabIndex = 5;
            this.m_lbl_tong_so.Text = "Tổng số :";
            // 
            // m_lbl_lop_mon
            // 
            this.m_lbl_lop_mon.AutoSize = true;
            this.m_lbl_lop_mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_lop_mon.Location = new System.Drawing.Point(22, 148);
            this.m_lbl_lop_mon.Name = "m_lbl_lop_mon";
            this.m_lbl_lop_mon.Size = new System.Drawing.Size(163, 29);
            this.m_lbl_lop_mon.TabIndex = 3;
            this.m_lbl_lop_mon.Text = "Chọn lớp môn";
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(752, 44);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "CHO HỌC SINH NGHỈ HỌC";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_nghi_hoc);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 316);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(752, 78);
            this.m_pnl_out_place_dm.TabIndex = 1;
            // 
            // m_cmd_nghi_hoc
            // 
            this.m_cmd_nghi_hoc.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_nghi_hoc.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_nghi_hoc.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_nghi_hoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_nghi_hoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_cmd_nghi_hoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_nghi_hoc.ImageIndex = 12;
            this.m_cmd_nghi_hoc.ImageList = this.ImageList;
            this.m_cmd_nghi_hoc.Location = new System.Drawing.Point(92, 4);
            this.m_cmd_nghi_hoc.Name = "m_cmd_nghi_hoc";
            this.m_cmd_nghi_hoc.Size = new System.Drawing.Size(167, 70);
            this.m_cmd_nghi_hoc.TabIndex = 1;
            this.m_cmd_nghi_hoc.Text = "&Nghỉ học";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 3;
            this.m_cmd_update.ImageList = this.ImageList;
            this.m_cmd_update.Location = new System.Drawing.Point(484, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 70);
            this.m_cmd_update.TabIndex = 2;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_xuat_excel.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_xuat_excel.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xuat_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_xuat_excel.ImageIndex = 19;
            this.m_cmd_xuat_excel.ImageList = this.ImageList;
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(88, 70);
            this.m_cmd_xuat_excel.TabIndex = 0;
            this.m_cmd_xuat_excel.Text = "Xuất Excel";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.ImageList = this.ImageList;
            this.m_cmd_delete.Location = new System.Drawing.Point(572, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 70);
            this.m_cmd_delete.TabIndex = 3;
            this.m_cmd_delete.Text = "&Xoá";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(660, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 70);
            this.m_cmd_exit.TabIndex = 4;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // f316_nghi_hoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 394);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.panel1);
            this.Name = "f316_nghi_hoc";
            this.Text = "F316 - Học sinh nghỉ học";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker m_dat_tu_ngay;
        private System.Windows.Forms.Label m_lbl_tu_ngay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label m_lbl_header;
        private System.Windows.Forms.Label m_lbl_lop_mon;
        private System.Windows.Forms.ComboBox m_cbo_lop_mon;
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_nghi_hoc;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private System.Windows.Forms.ComboBox m_cbo_hs;
        private System.Windows.Forms.Label m_lbl_chon_hoc_sinh;
        internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
        private System.Windows.Forms.Label m_lbl_tong_so_hoc_sinh;
        private System.Windows.Forms.Label m_lbl_tong_so;
        private System.Windows.Forms.Label label1;
    }
}