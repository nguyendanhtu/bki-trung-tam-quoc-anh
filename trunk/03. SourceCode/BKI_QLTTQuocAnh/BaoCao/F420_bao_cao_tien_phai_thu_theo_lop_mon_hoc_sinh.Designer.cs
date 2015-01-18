namespace BKI_QLTTQuocAnh.BaoCao
{
    partial class F420_bao_cao_tien_phai_thu_theo_lop_mon_hoc_sinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F420_bao_cao_tien_phai_thu_theo_lop_mon_hoc_sinh));
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_search = new System.Windows.Forms.Button();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_cmd_filter = new System.Windows.Forms.Button();
            this.m_dat_tu_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_tong_con_phai_thu = new System.Windows.Forms.Label();
            this.m_lbl_tong_thuc_thu = new System.Windows.Forms.Label();
            this.m_lbl_tong_phai_thu = new System.Windows.Forms.Label();
            this.m_lbl_tong = new System.Windows.Forms.Label();
            this.m_lbl_tu_ngay = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.m_cbo_lop = new System.Windows.Forms.ComboBox();
            this.m_lbl_den_ngay = new System.Windows.Forms.Label();
            this.m_dat_den_ngay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.m_lbl_tim_kiem = new System.Windows.Forms.Label();
            this.m_lbl_lop_mon = new System.Windows.Forms.Label();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.panel1.SuspendLayout();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(725, 27);
            this.m_lbl_header.TabIndex = 26;
            this.m_lbl_header.Text = "BÁO CÁO TIỀN PHẢI THU CỦA HỌC SINH THEO TỪNG LỚP";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 237);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(725, 277);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.m_txt_tim_kiem);
            this.panel1.Controls.Add(this.m_cmd_filter);
            this.panel1.Controls.Add(this.m_lbl_header);
            this.panel1.Controls.Add(this.m_dat_tu_ngay);
            this.panel1.Controls.Add(this.m_lbl_tong_con_phai_thu);
            this.panel1.Controls.Add(this.m_lbl_tong_thuc_thu);
            this.panel1.Controls.Add(this.m_lbl_tong_phai_thu);
            this.panel1.Controls.Add(this.m_lbl_tong);
            this.panel1.Controls.Add(this.m_lbl_tu_ngay);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.m_cbo_lop);
            this.panel1.Controls.Add(this.m_lbl_den_ngay);
            this.panel1.Controls.Add(this.m_dat_den_ngay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_lbl_tim_kiem);
            this.panel1.Controls.Add(this.m_lbl_lop_mon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 237);
            this.panel1.TabIndex = 30;
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.Location = new System.Drawing.Point(425, 137);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_search.TabIndex = 29;
            this.m_cmd_search.Text = "Tìm kiếm";
            this.m_cmd_search.UseVisualStyleBackColor = true;
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(220, 137);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(190, 20);
            this.m_txt_tim_kiem.TabIndex = 28;
            // 
            // m_cmd_filter
            // 
            this.m_cmd_filter.Location = new System.Drawing.Point(269, 172);
            this.m_cmd_filter.Name = "m_cmd_filter";
            this.m_cmd_filter.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_filter.TabIndex = 27;
            this.m_cmd_filter.Text = "LỌC";
            this.m_cmd_filter.UseVisualStyleBackColor = true;
            // 
            // m_dat_tu_ngay
            // 
            this.m_dat_tu_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dat_tu_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_tu_ngay.Location = new System.Drawing.Point(220, 47);
            this.m_dat_tu_ngay.Name = "m_dat_tu_ngay";
            this.m_dat_tu_ngay.Size = new System.Drawing.Size(190, 20);
            this.m_dat_tu_ngay.TabIndex = 24;
            // 
            // m_lbl_tong_con_phai_thu
            // 
            this.m_lbl_tong_con_phai_thu.AutoSize = true;
            this.m_lbl_tong_con_phai_thu.Location = new System.Drawing.Point(478, 205);
            this.m_lbl_tong_con_phai_thu.Name = "m_lbl_tong_con_phai_thu";
            this.m_lbl_tong_con_phai_thu.Size = new System.Drawing.Size(94, 13);
            this.m_lbl_tong_con_phai_thu.TabIndex = 23;
            this.m_lbl_tong_con_phai_thu.Text = "Tổng còn phải thu";
            // 
            // m_lbl_tong_thuc_thu
            // 
            this.m_lbl_tong_thuc_thu.AutoSize = true;
            this.m_lbl_tong_thuc_thu.Location = new System.Drawing.Point(380, 205);
            this.m_lbl_tong_thuc_thu.Name = "m_lbl_tong_thuc_thu";
            this.m_lbl_tong_thuc_thu.Size = new System.Drawing.Size(74, 13);
            this.m_lbl_tong_thuc_thu.TabIndex = 23;
            this.m_lbl_tong_thuc_thu.Text = "Tổng thực thu";
            // 
            // m_lbl_tong_phai_thu
            // 
            this.m_lbl_tong_phai_thu.AutoSize = true;
            this.m_lbl_tong_phai_thu.Location = new System.Drawing.Point(279, 205);
            this.m_lbl_tong_phai_thu.Name = "m_lbl_tong_phai_thu";
            this.m_lbl_tong_phai_thu.Size = new System.Drawing.Size(73, 13);
            this.m_lbl_tong_phai_thu.TabIndex = 23;
            this.m_lbl_tong_phai_thu.Text = "Tổng phải thu";
            // 
            // m_lbl_tong
            // 
            this.m_lbl_tong.AutoSize = true;
            this.m_lbl_tong.Location = new System.Drawing.Point(145, 205);
            this.m_lbl_tong.Name = "m_lbl_tong";
            this.m_lbl_tong.Size = new System.Drawing.Size(35, 13);
            this.m_lbl_tong.TabIndex = 23;
            this.m_lbl_tong.Text = "Tổng:";
            // 
            // m_lbl_tu_ngay
            // 
            this.m_lbl_tu_ngay.AutoSize = true;
            this.m_lbl_tu_ngay.Location = new System.Drawing.Point(145, 50);
            this.m_lbl_tu_ngay.Name = "m_lbl_tu_ngay";
            this.m_lbl_tu_ngay.Size = new System.Drawing.Size(49, 13);
            this.m_lbl_tu_ngay.TabIndex = 23;
            this.m_lbl_tu_ngay.Text = "Từ ngày:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(413, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // m_cbo_lop
            // 
            this.m_cbo_lop.FormattingEnabled = true;
            this.m_cbo_lop.Location = new System.Drawing.Point(220, 107);
            this.m_cbo_lop.Name = "m_cbo_lop";
            this.m_cbo_lop.Size = new System.Drawing.Size(87, 21);
            this.m_cbo_lop.TabIndex = 25;
            // 
            // m_lbl_den_ngay
            // 
            this.m_lbl_den_ngay.AutoSize = true;
            this.m_lbl_den_ngay.Location = new System.Drawing.Point(145, 77);
            this.m_lbl_den_ngay.Name = "m_lbl_den_ngay";
            this.m_lbl_den_ngay.Size = new System.Drawing.Size(56, 13);
            this.m_lbl_den_ngay.TabIndex = 23;
            this.m_lbl_den_ngay.Text = "Đến ngày:";
            // 
            // m_dat_den_ngay
            // 
            this.m_dat_den_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dat_den_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_den_ngay.Location = new System.Drawing.Point(220, 76);
            this.m_dat_den_ngay.Name = "m_dat_den_ngay";
            this.m_dat_den_ngay.Size = new System.Drawing.Size(190, 20);
            this.m_dat_den_ngay.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Môn:";
            // 
            // m_lbl_tim_kiem
            // 
            this.m_lbl_tim_kiem.AutoSize = true;
            this.m_lbl_tim_kiem.Location = new System.Drawing.Point(145, 142);
            this.m_lbl_tim_kiem.Name = "m_lbl_tim_kiem";
            this.m_lbl_tim_kiem.Size = new System.Drawing.Size(55, 13);
            this.m_lbl_tim_kiem.TabIndex = 23;
            this.m_lbl_tim_kiem.Text = "Tìm kiếm: ";
            // 
            // m_lbl_lop_mon
            // 
            this.m_lbl_lop_mon.AutoSize = true;
            this.m_lbl_lop_mon.Location = new System.Drawing.Point(145, 110);
            this.m_lbl_lop_mon.Name = "m_lbl_lop_mon";
            this.m_lbl_lop_mon.Size = new System.Drawing.Size(28, 13);
            this.m_lbl_lop_mon.TabIndex = 23;
            this.m_lbl_lop_mon.Text = "Lớp:";
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 478);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(725, 36);
            this.m_pnl_out_place_dm.TabIndex = 31;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 2;
            this.m_cmd_insert.ImageList = this.ImageList;
            this.m_cmd_insert.Location = new System.Drawing.Point(369, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_insert.TabIndex = 12;
            this.m_cmd_insert.Text = "&Thêm";
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
            this.m_cmd_update.Location = new System.Drawing.Point(457, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 13;
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
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_xuat_excel.TabIndex = 21;
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
            this.m_cmd_delete.Location = new System.Drawing.Point(545, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_delete.TabIndex = 14;
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
            this.m_cmd_exit.Location = new System.Drawing.Point(633, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // F420_bao_cao_tien_phai_thu_theo_lop_mon_hoc_sinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 514);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.panel1);
            this.Name = "F420_bao_cao_tien_phai_thu_theo_lop_mon_hoc_sinh";
            this.Text = "F420 - Báo cáo tiêng phải thu theo lớp môn, học sinh";
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label m_lbl_header;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button m_cmd_filter;
        private System.Windows.Forms.DateTimePicker m_dat_tu_ngay;
        private System.Windows.Forms.Label m_lbl_tu_ngay;
        private System.Windows.Forms.ComboBox m_cbo_lop;
        private System.Windows.Forms.Label m_lbl_den_ngay;
        private System.Windows.Forms.DateTimePicker m_dat_den_ngay;
        private System.Windows.Forms.Label m_lbl_lop_mon;
        private System.Windows.Forms.Button m_cmd_search;
        private System.Windows.Forms.TextBox m_txt_tim_kiem;
        private System.Windows.Forms.Label m_lbl_tim_kiem;
        private System.Windows.Forms.Label m_lbl_tong_con_phai_thu;
        private System.Windows.Forms.Label m_lbl_tong_thuc_thu;
        private System.Windows.Forms.Label m_lbl_tong_phai_thu;
        private System.Windows.Forms.Label m_lbl_tong;
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}