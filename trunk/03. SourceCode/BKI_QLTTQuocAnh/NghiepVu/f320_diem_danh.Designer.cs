namespace BKI_QLTTQuocAnh.NghiepVu
{
    partial class f320_diem_danh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f320_diem_danh));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_dat_tai_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_tu_ngay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.m_cbo_lop_mon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_cbo_ca_hoc = new System.Windows.Forms.ComboBox();
            this.m_cbo_nguoi_diem_danh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_diem_danh = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel1.SuspendLayout();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.SuspendLayout();
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
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(552, 44);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "ĐIỂM DANH HỌC SINH";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_dat_tai_ngay
            // 
            this.m_dat_tai_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dat_tai_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_tai_ngay.Location = new System.Drawing.Point(106, 3);
            this.m_dat_tai_ngay.Name = "m_dat_tai_ngay";
            this.m_dat_tai_ngay.Size = new System.Drawing.Size(86, 20);
            this.m_dat_tai_ngay.TabIndex = 1;
            // 
            // m_lbl_tu_ngay
            // 
            this.m_lbl_tu_ngay.AutoSize = true;
            this.m_lbl_tu_ngay.Location = new System.Drawing.Point(8, 7);
            this.m_lbl_tu_ngay.Name = "m_lbl_tu_ngay";
            this.m_lbl_tu_ngay.Size = new System.Drawing.Size(48, 13);
            this.m_lbl_tu_ngay.TabIndex = 0;
            this.m_lbl_tu_ngay.Text = "Tại ngày";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.m_cbo_lop_mon);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.m_cbo_ca_hoc);
            this.panel1.Controls.Add(this.m_cbo_nguoi_diem_danh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_dat_tai_ngay);
            this.panel1.Controls.Add(this.m_lbl_tu_ngay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 101);
            this.panel1.TabIndex = 1;
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.imageList1;
            this.m_cmd_search.Location = new System.Drawing.Point(253, 60);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 8;
            this.m_cmd_search.Text = "Lọc dữ liệu";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
            // 
            // m_cbo_lop_mon
            // 
            this.m_cbo_lop_mon.FormattingEnabled = true;
            this.m_cbo_lop_mon.Location = new System.Drawing.Point(106, 33);
            this.m_cbo_lop_mon.Name = "m_cbo_lop_mon";
            this.m_cbo_lop_mon.Size = new System.Drawing.Size(121, 21);
            this.m_cbo_lop_mon.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ca học";
            // 
            // m_cbo_ca_hoc
            // 
            this.m_cbo_ca_hoc.FormattingEnabled = true;
            this.m_cbo_ca_hoc.Location = new System.Drawing.Point(299, 33);
            this.m_cbo_ca_hoc.Name = "m_cbo_ca_hoc";
            this.m_cbo_ca_hoc.Size = new System.Drawing.Size(121, 21);
            this.m_cbo_ca_hoc.TabIndex = 5;
            // 
            // m_cbo_nguoi_diem_danh
            // 
            this.m_cbo_nguoi_diem_danh.FormattingEnabled = true;
            this.m_cbo_nguoi_diem_danh.Location = new System.Drawing.Point(106, 64);
            this.m_cbo_nguoi_diem_danh.Name = "m_cbo_nguoi_diem_danh";
            this.m_cbo_nguoi_diem_danh.Size = new System.Drawing.Size(121, 21);
            this.m_cbo_nguoi_diem_danh.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Người điểm danh";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn lớp môn";
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_diem_danh);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 337);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(552, 36);
            this.m_pnl_out_place_dm.TabIndex = 3;
            // 
            // m_cmd_diem_danh
            // 
            this.m_cmd_diem_danh.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_diem_danh.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_diem_danh.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_diem_danh.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_diem_danh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_diem_danh.ImageIndex = 13;
            this.m_cmd_diem_danh.ImageList = this.ImageList;
            this.m_cmd_diem_danh.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_diem_danh.Name = "m_cmd_diem_danh";
            this.m_cmd_diem_danh.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_diem_danh.TabIndex = 0;
            this.m_cmd_diem_danh.Text = "&Điểm danh";
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
            this.m_cmd_exit.Location = new System.Drawing.Point(460, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 1;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 145);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(552, 192);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 2;
            // 
            // f320_diem_danh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 373);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_lbl_header);
            this.Name = "f320_diem_danh";
            this.Text = "F320 - Điểm danh";
            this.Load += new System.EventHandler(this.f230_danh_muc_hs_theo_lop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Label m_lbl_header;
        private System.Windows.Forms.DateTimePicker m_dat_tai_ngay;
        private System.Windows.Forms.Label m_lbl_tu_ngay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox m_cbo_nguoi_diem_danh;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_diem_danh;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox m_cbo_ca_hoc;
        private System.Windows.Forms.ComboBox m_cbo_lop_mon;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        internal System.Windows.Forms.ImageList imageList1;
    }
}