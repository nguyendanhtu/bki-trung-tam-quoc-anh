


using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.DS.CDBNames;
using BKI_QLTTQuocAnh.BaoCao;
using BKI_QLTTQuocAnh.DanhMuc;
using C1.Win.C1FlexGrid;

namespace BKI_QLTTQuocAnh.NghiepVu {



    public class f340_lap_phieu_thu : System.Windows.Forms.Form {
        #region Design_Form
        internal System.Windows.Forms.ImageList ImageList;
        private Panel panel1;
        private Label m_lbl_header;
        internal ImageList imageList1;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal Panel m_pnl_out_place_dm;
        private Panel panel2;
        private Panel panel3;
        internal SIS.Controls.Button.SiSButton m_cmd_chon_hs;
        private ComboBox m_cbo_nhan_vien_thu;
        private ComboBox m_cbo_nhan_vien_nhap;
        private Label m_lbl_ngay_thu;
        private DateTimePicker m_dat_ngay_nhap;
        private DateTimePicker m_dat_ngay_thu;
        private TextBox m_txt_noi_dung;
        private Label m_lbl_hoc_sinh;
        private Label m_lbl_den_ngay;
        private Label m_lbl_noi_dung;
        private TextBox m_txt_ten_nguoi_nop_tien;
        private Label m_lbl_nhan_vien_nhap;
        private TextBox m_txt_ho_ten_hs;
        private Label m_lbl_ten_nguoi_nop_tien;
        private Label m_lbl_nhan_vien_thu;
        private Label m_lbl_so_phieu;
        private TextBox m_txt_so_phieu;
        internal SIS.Controls.Button.SiSButton m_cmd_ds_phieu;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private Label m_lbl_so_tien;
        private TextBox m_txt_so_tien;
        private Label m_lbl_vnd;
        private C1FlexGrid m_fg;
        private System.ComponentModel.IContainer components;
        #endregion

        public f340_lap_phieu_thu() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            format_controls();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f340_lap_phieu_thu));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_ds_phieu = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_lbl_vnd = new System.Windows.Forms.Label();
            this.m_txt_so_tien = new System.Windows.Forms.TextBox();
            this.m_lbl_so_tien = new System.Windows.Forms.Label();
            this.m_cmd_chon_hs = new SIS.Controls.Button.SiSButton();
            this.m_cbo_nhan_vien_thu = new System.Windows.Forms.ComboBox();
            this.m_cbo_nhan_vien_nhap = new System.Windows.Forms.ComboBox();
            this.m_lbl_ngay_thu = new System.Windows.Forms.Label();
            this.m_dat_ngay_nhap = new System.Windows.Forms.DateTimePicker();
            this.m_dat_ngay_thu = new System.Windows.Forms.DateTimePicker();
            this.m_txt_noi_dung = new System.Windows.Forms.TextBox();
            this.m_lbl_hoc_sinh = new System.Windows.Forms.Label();
            this.m_lbl_den_ngay = new System.Windows.Forms.Label();
            this.m_lbl_noi_dung = new System.Windows.Forms.Label();
            this.m_txt_ten_nguoi_nop_tien = new System.Windows.Forms.TextBox();
            this.m_lbl_nhan_vien_nhap = new System.Windows.Forms.Label();
            this.m_txt_ho_ten_hs = new System.Windows.Forms.TextBox();
            this.m_lbl_ten_nguoi_nop_tien = new System.Windows.Forms.Label();
            this.m_lbl_nhan_vien_thu = new System.Windows.Forms.Label();
            this.m_lbl_so_phieu = new System.Windows.Forms.Label();
            this.m_txt_so_phieu = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.panel3.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.m_lbl_header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 42);
            this.panel1.TabIndex = 21;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(897, 41);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "LẬP PHIẾU THU";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 13;
            this.m_cmd_insert.ImageList = this.ImageList;
            this.m_cmd_insert.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(115, 28);
            this.m_cmd_insert.TabIndex = 1;
            this.m_cmd_insert.Text = "&Lập phiếu";
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_ds_phieu);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 422);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(897, 36);
            this.m_pnl_out_place_dm.TabIndex = 3;
            this.m_pnl_out_place_dm.TabStop = true;
            // 
            // m_cmd_ds_phieu
            // 
            this.m_cmd_ds_phieu.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_ds_phieu.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_ds_phieu.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_ds_phieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_ds_phieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_ds_phieu.ImageIndex = 18;
            this.m_cmd_ds_phieu.ImageList = this.ImageList;
            this.m_cmd_ds_phieu.Location = new System.Drawing.Point(236, 4);
            this.m_cmd_ds_phieu.Name = "m_cmd_ds_phieu";
            this.m_cmd_ds_phieu.Size = new System.Drawing.Size(132, 28);
            this.m_cmd_ds_phieu.TabIndex = 2;
            this.m_cmd_ds_phieu.Text = "Danh sách phiếu";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(119, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(117, 28);
            this.m_cmd_exit.TabIndex = 2;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            this.m_cmd_exit.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_fg);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 380);
            this.panel2.TabIndex = 23;
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_fg.Location = new System.Drawing.Point(0, 238);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(897, 142);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_lbl_vnd);
            this.panel3.Controls.Add(this.m_txt_so_tien);
            this.panel3.Controls.Add(this.m_lbl_so_tien);
            this.panel3.Controls.Add(this.m_cmd_chon_hs);
            this.panel3.Controls.Add(this.m_cbo_nhan_vien_thu);
            this.panel3.Controls.Add(this.m_cbo_nhan_vien_nhap);
            this.panel3.Controls.Add(this.m_lbl_ngay_thu);
            this.panel3.Controls.Add(this.m_dat_ngay_nhap);
            this.panel3.Controls.Add(this.m_dat_ngay_thu);
            this.panel3.Controls.Add(this.m_txt_noi_dung);
            this.panel3.Controls.Add(this.m_lbl_hoc_sinh);
            this.panel3.Controls.Add(this.m_lbl_den_ngay);
            this.panel3.Controls.Add(this.m_lbl_noi_dung);
            this.panel3.Controls.Add(this.m_txt_ten_nguoi_nop_tien);
            this.panel3.Controls.Add(this.m_lbl_nhan_vien_nhap);
            this.panel3.Controls.Add(this.m_txt_ho_ten_hs);
            this.panel3.Controls.Add(this.m_lbl_ten_nguoi_nop_tien);
            this.panel3.Controls.Add(this.m_lbl_nhan_vien_thu);
            this.panel3.Controls.Add(this.m_lbl_so_phieu);
            this.panel3.Controls.Add(this.m_txt_so_phieu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(897, 238);
            this.panel3.TabIndex = 1;
            // 
            // m_lbl_vnd
            // 
            this.m_lbl_vnd.AutoSize = true;
            this.m_lbl_vnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_vnd.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_vnd.Location = new System.Drawing.Point(366, 200);
            this.m_lbl_vnd.Name = "m_lbl_vnd";
            this.m_lbl_vnd.Size = new System.Drawing.Size(62, 24);
            this.m_lbl_vnd.TabIndex = 83;
            this.m_lbl_vnd.Text = "(VNĐ)";
            // 
            // m_txt_so_tien
            // 
            this.m_txt_so_tien.BackColor = System.Drawing.SystemColors.Info;
            this.m_txt_so_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txt_so_tien.ForeColor = System.Drawing.Color.Maroon;
            this.m_txt_so_tien.Location = new System.Drawing.Point(133, 197);
            this.m_txt_so_tien.Name = "m_txt_so_tien";
            this.m_txt_so_tien.Size = new System.Drawing.Size(219, 29);
            this.m_txt_so_tien.TabIndex = 11;
            this.m_txt_so_tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_lbl_so_tien
            // 
            this.m_lbl_so_tien.AutoSize = true;
            this.m_lbl_so_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_so_tien.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_so_tien.Location = new System.Drawing.Point(12, 200);
            this.m_lbl_so_tien.Name = "m_lbl_so_tien";
            this.m_lbl_so_tien.Size = new System.Drawing.Size(85, 24);
            this.m_lbl_so_tien.TabIndex = 10;
            this.m_lbl_so_tien.Text = "SỐ TIỀN";
            // 
            // m_cmd_chon_hs
            // 
            this.m_cmd_chon_hs.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_chon_hs.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_chon_hs.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_chon_hs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_chon_hs.ImageIndex = 7;
            this.m_cmd_chon_hs.ImageList = this.ImageList;
            this.m_cmd_chon_hs.Location = new System.Drawing.Point(358, 60);
            this.m_cmd_chon_hs.Name = "m_cmd_chon_hs";
            this.m_cmd_chon_hs.Size = new System.Drawing.Size(81, 28);
            this.m_cmd_chon_hs.TabIndex = 6;
            this.m_cmd_chon_hs.Text = "&Chọn HS";
            // 
            // m_cbo_nhan_vien_thu
            // 
            this.m_cbo_nhan_vien_thu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_nhan_vien_thu.FormattingEnabled = true;
            this.m_cbo_nhan_vien_thu.Location = new System.Drawing.Point(591, 9);
            this.m_cbo_nhan_vien_thu.Name = "m_cbo_nhan_vien_thu";
            this.m_cbo_nhan_vien_thu.Size = new System.Drawing.Size(190, 21);
            this.m_cbo_nhan_vien_thu.TabIndex = 12;
            // 
            // m_cbo_nhan_vien_nhap
            // 
            this.m_cbo_nhan_vien_nhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_nhan_vien_nhap.FormattingEnabled = true;
            this.m_cbo_nhan_vien_nhap.Location = new System.Drawing.Point(591, 45);
            this.m_cbo_nhan_vien_nhap.Name = "m_cbo_nhan_vien_nhap";
            this.m_cbo_nhan_vien_nhap.Size = new System.Drawing.Size(190, 21);
            this.m_cbo_nhan_vien_nhap.TabIndex = 14;
            // 
            // m_lbl_ngay_thu
            // 
            this.m_lbl_ngay_thu.AutoSize = true;
            this.m_lbl_ngay_thu.Location = new System.Drawing.Point(11, 38);
            this.m_lbl_ngay_thu.Name = "m_lbl_ngay_thu";
            this.m_lbl_ngay_thu.Size = new System.Drawing.Size(50, 13);
            this.m_lbl_ngay_thu.TabIndex = 2;
            this.m_lbl_ngay_thu.Text = "Ngày thu";
            // 
            // m_dat_ngay_nhap
            // 
            this.m_dat_ngay_nhap.CustomFormat = "dd/MM/yyyy";
            this.m_dat_ngay_nhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_ngay_nhap.Location = new System.Drawing.Point(591, 79);
            this.m_dat_ngay_nhap.Name = "m_dat_ngay_nhap";
            this.m_dat_ngay_nhap.Size = new System.Drawing.Size(127, 20);
            this.m_dat_ngay_nhap.TabIndex = 16;
            // 
            // m_dat_ngay_thu
            // 
            this.m_dat_ngay_thu.CustomFormat = "dd/MM/yyyy";
            this.m_dat_ngay_thu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_ngay_thu.Location = new System.Drawing.Point(133, 36);
            this.m_dat_ngay_thu.Name = "m_dat_ngay_thu";
            this.m_dat_ngay_thu.Size = new System.Drawing.Size(137, 20);
            this.m_dat_ngay_thu.TabIndex = 3;
            // 
            // m_txt_noi_dung
            // 
            this.m_txt_noi_dung.Location = new System.Drawing.Point(133, 127);
            this.m_txt_noi_dung.Multiline = true;
            this.m_txt_noi_dung.Name = "m_txt_noi_dung";
            this.m_txt_noi_dung.Size = new System.Drawing.Size(219, 46);
            this.m_txt_noi_dung.TabIndex = 10;
            // 
            // m_lbl_hoc_sinh
            // 
            this.m_lbl_hoc_sinh.AutoSize = true;
            this.m_lbl_hoc_sinh.Location = new System.Drawing.Point(11, 68);
            this.m_lbl_hoc_sinh.Name = "m_lbl_hoc_sinh";
            this.m_lbl_hoc_sinh.Size = new System.Drawing.Size(92, 13);
            this.m_lbl_hoc_sinh.TabIndex = 4;
            this.m_lbl_hoc_sinh.Text = "Họ tên học sinh(*)";
            // 
            // m_lbl_den_ngay
            // 
            this.m_lbl_den_ngay.AutoSize = true;
            this.m_lbl_den_ngay.Location = new System.Drawing.Point(485, 80);
            this.m_lbl_den_ngay.Name = "m_lbl_den_ngay";
            this.m_lbl_den_ngay.Size = new System.Drawing.Size(59, 13);
            this.m_lbl_den_ngay.TabIndex = 15;
            this.m_lbl_den_ngay.Text = "Ngày nhập";
            // 
            // m_lbl_noi_dung
            // 
            this.m_lbl_noi_dung.AutoSize = true;
            this.m_lbl_noi_dung.Location = new System.Drawing.Point(11, 130);
            this.m_lbl_noi_dung.Name = "m_lbl_noi_dung";
            this.m_lbl_noi_dung.Size = new System.Drawing.Size(60, 13);
            this.m_lbl_noi_dung.TabIndex = 9;
            this.m_lbl_noi_dung.Text = "Nội dung(*)";
            // 
            // m_txt_ten_nguoi_nop_tien
            // 
            this.m_txt_ten_nguoi_nop_tien.Location = new System.Drawing.Point(133, 97);
            this.m_txt_ten_nguoi_nop_tien.Name = "m_txt_ten_nguoi_nop_tien";
            this.m_txt_ten_nguoi_nop_tien.Size = new System.Drawing.Size(219, 20);
            this.m_txt_ten_nguoi_nop_tien.TabIndex = 8;
            // 
            // m_lbl_nhan_vien_nhap
            // 
            this.m_lbl_nhan_vien_nhap.AutoSize = true;
            this.m_lbl_nhan_vien_nhap.Location = new System.Drawing.Point(485, 48);
            this.m_lbl_nhan_vien_nhap.Name = "m_lbl_nhan_vien_nhap";
            this.m_lbl_nhan_vien_nhap.Size = new System.Drawing.Size(93, 13);
            this.m_lbl_nhan_vien_nhap.TabIndex = 13;
            this.m_lbl_nhan_vien_nhap.Text = "Nhân viên nhập(*)";
            // 
            // m_txt_ho_ten_hs
            // 
            this.m_txt_ho_ten_hs.BackColor = System.Drawing.SystemColors.Info;
            this.m_txt_ho_ten_hs.Location = new System.Drawing.Point(133, 65);
            this.m_txt_ho_ten_hs.Name = "m_txt_ho_ten_hs";
            this.m_txt_ho_ten_hs.ReadOnly = true;
            this.m_txt_ho_ten_hs.Size = new System.Drawing.Size(219, 20);
            this.m_txt_ho_ten_hs.TabIndex = 5;
            // 
            // m_lbl_ten_nguoi_nop_tien
            // 
            this.m_lbl_ten_nguoi_nop_tien.AutoSize = true;
            this.m_lbl_ten_nguoi_nop_tien.Location = new System.Drawing.Point(11, 100);
            this.m_lbl_ten_nguoi_nop_tien.Name = "m_lbl_ten_nguoi_nop_tien";
            this.m_lbl_ten_nguoi_nop_tien.Size = new System.Drawing.Size(106, 13);
            this.m_lbl_ten_nguoi_nop_tien.TabIndex = 7;
            this.m_lbl_ten_nguoi_nop_tien.Text = "Tên người nộp tiền(*)";
            // 
            // m_lbl_nhan_vien_thu
            // 
            this.m_lbl_nhan_vien_thu.AutoSize = true;
            this.m_lbl_nhan_vien_thu.Location = new System.Drawing.Point(485, 12);
            this.m_lbl_nhan_vien_thu.Name = "m_lbl_nhan_vien_thu";
            this.m_lbl_nhan_vien_thu.Size = new System.Drawing.Size(84, 13);
            this.m_lbl_nhan_vien_thu.TabIndex = 11;
            this.m_lbl_nhan_vien_thu.Text = "Nhân viên thu(*)";
            // 
            // m_lbl_so_phieu
            // 
            this.m_lbl_so_phieu.AutoSize = true;
            this.m_lbl_so_phieu.Location = new System.Drawing.Point(11, 9);
            this.m_lbl_so_phieu.Name = "m_lbl_so_phieu";
            this.m_lbl_so_phieu.Size = new System.Drawing.Size(59, 13);
            this.m_lbl_so_phieu.TabIndex = 9;
            this.m_lbl_so_phieu.Text = "Số phiếu(*)";
            // 
            // m_txt_so_phieu
            // 
            this.m_txt_so_phieu.Location = new System.Drawing.Point(133, 6);
            this.m_txt_so_phieu.Name = "m_txt_so_phieu";
            this.m_txt_so_phieu.Size = new System.Drawing.Size(137, 20);
            this.m_txt_so_phieu.TabIndex = 1;
            // 
            // f340_lap_phieu_thu
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(897, 458);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.panel1);
            this.Name = "f340_lap_phieu_thu";
            this.Text = "F340 - Lập phiếu ";
            this.Load += new System.EventHandler(this.f340_lap_phieu_thu_Load);
            this.panel1.ResumeLayout(false);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Public Interface
        public void set_phieu_thuc_thu() {
            m_str_loai_form = "THUC_THU";
            m_lbl_header.Text = "LẬP PHIẾU THỰC THU";
            m_fg.Cols[(int)e_col_Number.SO_TIEN].Caption = "Số tiền thực thu theo lớp";
        }
        public void set_phieu_phai_thu() {
            m_str_loai_form = "PHAI_THU";
            m_lbl_header.Text = "LẬP PHIẾU PHẢI THU";
            m_fg.Cols[(int)e_col_Number.SO_TIEN].Caption = "Số tiền phải thu theo lớp";
        }
        public void display(US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU ip_us, decimal ip_dc_id_loai_phieu_thu, decimal ip_dc_id_nguoi_nhap) {
            US_V_GD_PHIEU_THU v_us_v_pt = new US_V_GD_PHIEU_THU(ip_us.dcID);

            m_us_v_hoc_sinh.dcID = ip_us.dcID_HOC_SINH;
            m_us_gd_phieu_thu.dcID = v_us_v_pt.dcID;
            m_txt_so_phieu.Text = ip_us.strSO_PHIEU.Trim();
            m_txt_ho_ten_hs.Text = ip_us.strHO_TEN_HS.Trim();
            m_txt_ten_nguoi_nop_tien.Text = v_us_v_pt.strTEN_NGUOI_NOP_TIEN.Trim();
            m_txt_noi_dung.Text = ip_us.strNOI_DUNG.Trim();
            if (ip_dc_id_loai_phieu_thu == ID_LOAI_PHIEU_THU.ID_PHIEU_PHAI_THU) {
                m_txt_so_tien.Text = ip_us.dcTIEN_PHAI_THU.ToString("#,###");
                //m_txt_so_tien_bang_chu.Text = CTienNo2Text.So_chu((double)ip_us.dcTIEN_PHAI_THU);
                m_lbl_header.Text = "CHI TIẾT PHIẾU PHẢI THU";
            }
            else if (ip_dc_id_loai_phieu_thu == ID_LOAI_PHIEU_THU.ID_PHIEU_GIAM_TRU) {
                m_txt_so_tien.Text = ip_us.dcTIEN_GIAM_TRU.ToString("#,###");
                //m_txt_so_tien_bang_chu.Text = CTienNo2Text.So_chu((double)ip_us.dcTIEN_GIAM_TRU);
                m_lbl_header.Text = "CHI TIẾT PHIẾU GIẢM TRỪ";
            }
            else if (ip_dc_id_loai_phieu_thu == ID_LOAI_PHIEU_THU.ID_PHIEU_THUC_THU) {
                m_txt_so_tien.Text = ip_us.dcTIEN_THUC_THU.ToString("#,###");
                //m_txt_so_tien_bang_chu.Text = CTienNo2Text.So_chu((double)ip_us.dcTIEN_THUC_THU);
                m_lbl_header.Text = "CHI TIẾT PHIẾU THỰC THU";
            }
            //lap ham xu ly tien bang so qua bang chu
            m_cbo_nhan_vien_thu.SelectedValue = ip_us.dcID_NGUOI_THU;

            //m_lbl_header.Text = "LẬP " + v_us_v_pt.strTEN_NGAN;

            m_dat_ngay_thu.Value = ip_us.datNGAY_THU;
            m_dat_ngay_nhap.Value = v_us_v_pt.datNGAY_NHAP;

            load_data_2_cbo();
            m_cbo_nhan_vien_nhap.SelectedValue = ip_dc_id_nguoi_nhap;
            m_cbo_nhan_vien_thu.SelectedValue = ip_us.dcID_NGUOI_THU;

            m_cmd_ds_phieu.Visible = false;
            m_str_trang_thai_phieu = "F430";
            m_id_gd_phieu_thu = ip_us.dcID;
            m_cmd_insert.Text = "Lưu sửa phiếu";
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_cmd_chon_hs.Visible = false;
            m_txt_ho_ten_hs.BackColor = Color.AliceBlue;
            m_txt_ho_ten_hs.ReadOnly = true;
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number {
            TRANG_THAI_YN = 6
,
            SO_TIEN = 4
                ,
            NGAY_BAT_DAU = 7
                ,
            NGAY_KET_THUC = 8
                ,
            MO_TA = 3
                ,
            HO_TEN = 2
                ,
            MA_HOC_SINH = 1
                , DON_GIA_BUOI_HOC = 5

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        US_GD_PHIEU_THU m_us_gd_phieu_thu = new US_GD_PHIEU_THU();
        US_GD_CHI_TIET_PHIEU_THU m_us_gd_ct_phieu_thu = new US_GD_CHI_TIET_PHIEU_THU();
        //US_V_HOC_SINH m_us_v_dm_hoc_sinh = new US_V_HOC_SINH();
        US_V_HOC_SINH m_us_v_hoc_sinh = new US_V_HOC_SINH();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        string m_str_loai_form = "";// = "PHAI_THU" or "THUC_THU"
        string m_str_trang_thai_phieu = "";//CLICK tu f430 thi gan = "F430"
        decimal m_id_gd_phieu_thu = 0;//Dung de lay id_gd_phieu_thu khi click tu 430
        #endregion

        #region Private Methods
        private void format_controls() {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_so_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txt_so_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_vnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            set_define_events();

            m_fg.AllowEditing = true;
            m_fg.Cols[(int)e_col_Number.MA_HOC_SINH].AllowEditing = false;
            m_fg.Cols[(int)e_col_Number.HO_TEN].AllowEditing = false;
            m_fg.Cols[(int)e_col_Number.MO_TA].AllowEditing = false;
            m_fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            m_fg.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.None;
            m_fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
            m_fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;

            this.KeyPreview = true;
        }

        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg) {
            DS_V_F340_LOP_MON_CUA_HS v_ds = new DS_V_F340_LOP_MON_CUA_HS();
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_F340_LOP_MON_CUA_HS.TRANG_THAI_YN, e_col_Number.TRANG_THAI_YN);
            v_htb.Add(V_F340_LOP_MON_CUA_HS.SO_TIEN, e_col_Number.SO_TIEN);
            v_htb.Add(V_F340_LOP_MON_CUA_HS.NGAY_BAT_DAU, e_col_Number.NGAY_BAT_DAU);
            v_htb.Add(V_F340_LOP_MON_CUA_HS.NGAY_KET_THUC, e_col_Number.NGAY_KET_THUC);
            v_htb.Add(V_F340_LOP_MON_CUA_HS.MO_TA, e_col_Number.MO_TA);
            v_htb.Add(V_F340_LOP_MON_CUA_HS.HO_TEN, e_col_Number.HO_TEN);
            v_htb.Add(V_F340_LOP_MON_CUA_HS.MA_HOC_SINH, e_col_Number.MA_HOC_SINH);
            v_htb.Add(V_F340_LOP_MON_CUA_HS.DON_GIA_BUOI_HOC, e_col_Number.DON_GIA_BUOI_HOC);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, v_ds.V_F340_LOP_MON_CUA_HS.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_cbo() {
            CCommon.load_data_2_cbo_nhan_vien(CAppContext_201.getCurrentUserID(), m_cbo_nhan_vien_thu);
            CCommon.load_data_2_cbo_nhan_vien(CAppContext_201.getCurrentUserID(), m_cbo_nhan_vien_nhap);
        }
        private void load_data_2_grid() {
            m_obj_trans = get_trans_object(m_fg);
            DS_V_F340_LOP_MON_CUA_HS v_ds = new DS_V_F340_LOP_MON_CUA_HS();
            US_V_F340_LOP_MON_CUA_HS v_us = new US_V_F340_LOP_MON_CUA_HS();
            v_ds.Clear();
            v_ds.EnforceConstraints = false;
            if (m_str_trang_thai_phieu != "F430") {
                v_us.FillDatasetByIdHS(v_ds, m_us_v_hoc_sinh.dcID);
            }
            else {
                v_us.FillDatasetDuLieuDaCo(v_ds, m_id_gd_phieu_thu);
            }
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_fg);
            m_fg.Redraw = true;
        }
        private void set_initial_form_load() {
            m_obj_trans = get_trans_object(m_fg);
            //m_dat_ngay_thu.Value = DateTime.Now.AddDays(-DateTime.Now.Date.Day + 1);
            m_txt_so_phieu.Focus();
            if (m_str_trang_thai_phieu != "F430") {
                load_data_2_cbo();
            }
            load_data_2_grid();
        }

        private bool check_validate_data() {
            if (!CValidateTextBox.IsValid(m_txt_so_phieu, DataType.StringType, allowNull.NO, false)) {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập SỐ PHIẾU!");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ho_ten_hs, DataType.StringType, allowNull.NO, false)) {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập HỌ TÊN học sinh!");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ten_nguoi_nop_tien, DataType.StringType, allowNull.NO, false)) {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập TÊN NGƯỜI NỘP TIỀN!");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_so_tien, DataType.StringType, allowNull.NO, false)) {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập SỐ TIỀN!");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_noi_dung, DataType.StringType, allowNull.NO, false)) {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập NỘI DUNG phiếu!");
                return false;
            }

            //if (m_cbo_nhan_vien_nhap.SelectedIndex == 0) {
            //    BaseMessages.MsgBox_Infor("Bạn chưa chọn NHÂN VIÊN NHẬP!");
            //    return false;
            //}
            //if (m_cbo_nhan_vien_thu.SelectedIndex == 0) {
            //    BaseMessages.MsgBox_Infor("Bạn chưa chọn NHÂN VIÊN THU!");
            //    return false;
            //}

            return true;
        }
        private bool is_exist_so_phieu(ref decimal ip_dc_id_phieu) {
            US_GD_PHIEU_THU v_us = new US_GD_PHIEU_THU();
            if (!v_us.FindSoPhieuYN(m_txt_so_phieu.Text.Trim(), ref ip_dc_id_phieu)) {
                return false;
            }
            return true;
        }
        private void form_2_us_gd_phieu_thu() {
            //form to us GD_PHIEU_THU
            m_us_gd_phieu_thu.strSO_PHIEU = m_txt_so_phieu.Text.Trim();
            m_us_gd_phieu_thu.datNGAY_THU = m_dat_ngay_thu.Value.Date;
            m_us_gd_phieu_thu.datNGAY_NHAP = m_dat_ngay_nhap.Value.Date;
            m_us_gd_phieu_thu.strTEN_NGUOI_NOP_TIEN = m_txt_ten_nguoi_nop_tien.Text.Trim();
            m_us_gd_phieu_thu.dcID_HOC_SINH = m_us_v_hoc_sinh.dcID;
            m_us_gd_phieu_thu.dcID_NGUOI_THU = CIPConvert.ToDecimal(m_cbo_nhan_vien_thu.SelectedValue);
            m_us_gd_phieu_thu.dcID_NGUOI_NHAP = CIPConvert.ToDecimal(m_cbo_nhan_vien_nhap.SelectedValue);
            m_us_gd_phieu_thu.strNOI_DUNG = m_txt_noi_dung.Text.Trim();
            m_us_gd_phieu_thu.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_BAN_GIAO.DA_THU;
            if (m_str_loai_form == "PHAI_THU") {
                m_us_gd_phieu_thu.dcID_LOAI_PHIEU_THU = CONST_ID_LOAI_PHIEU_THU.PHIEU_PHAI_THU;
            }
            else {
                m_us_gd_phieu_thu.dcID_LOAI_PHIEU_THU = CONST_ID_LOAI_PHIEU_THU.PHIEU_THUC_THU;
            }
        }
        private bool check_tong_tien_grid_textbox() {
            decimal v_dc_tong_tien_grid = 0;
            for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count; v_i_cur_row++) {
                if (m_fg.Rows[v_i_cur_row][(int)e_col_Number.SO_TIEN] != null && m_fg.Rows[v_i_cur_row][(int)e_col_Number.SO_TIEN].ToString() != "") {
                    v_dc_tong_tien_grid = v_dc_tong_tien_grid + CIPConvert.ToDecimal(m_fg.Rows[v_i_cur_row][(int)e_col_Number.SO_TIEN].ToString().Trim());
                }
            }
            if (v_dc_tong_tien_grid != CIPConvert.ToDecimal(m_txt_so_tien.Text.Trim())) {
                return false;
            }
            return true;
        }
        private void insert_chi_tiet_phieu_thu(decimal ip_id_phieu_thu) {
            try {
                m_us_gd_ct_phieu_thu.BeginTransaction();
                for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count; v_i_cur_row++) {
                    US_V_F340_LOP_MON_CUA_HS v_us_lm_hs = new US_V_F340_LOP_MON_CUA_HS();
                    grid2us_object(v_us_lm_hs, v_i_cur_row);
                    m_us_gd_ct_phieu_thu.dcID_LOP_MON = v_us_lm_hs.dcID_LOP_MON;
                    m_us_gd_ct_phieu_thu.dcSO_TIEN = CIPConvert.ToDecimal(m_fg.Rows[v_i_cur_row][(int)e_col_Number.SO_TIEN].ToString().Trim());////Cho nay de chet, can sua sau
                    m_us_gd_ct_phieu_thu.Insert();
                }
                m_us_gd_ct_phieu_thu.CommitTransaction();
            }
            catch (Exception v_e) {
                if (m_us_gd_phieu_thu.is_having_transaction()) {
                    m_us_gd_phieu_thu.Rollback();
                }
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }
        private void insert_phieu_thu_ct_phieu_thu() {
            try {
                form_2_us_gd_phieu_thu();
                m_us_gd_phieu_thu.BeginTransaction();
                m_us_gd_phieu_thu.Insert();
                m_us_gd_ct_phieu_thu.UseTransOfUSObject(m_us_gd_phieu_thu);

                m_us_gd_ct_phieu_thu.dcID_GD_PHIEU_THU = m_us_gd_phieu_thu.dcID;
                for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count; v_i_cur_row++) {
                    US_V_F340_LOP_MON_CUA_HS v_us_lm_hs = new US_V_F340_LOP_MON_CUA_HS();
                    grid2us_object(v_us_lm_hs, v_i_cur_row);
                    m_us_gd_ct_phieu_thu.dcID_LOP_MON = v_us_lm_hs.dcID_LOP_MON;
                    m_us_gd_ct_phieu_thu.dcSO_TIEN = CIPConvert.ToDecimal(m_fg.Rows[v_i_cur_row][(int)e_col_Number.SO_TIEN].ToString().Trim());////Cho nay de chet, can sua sau
                    m_us_gd_ct_phieu_thu.Insert();
                }
                //Day du lieu vao us_chi_tiet_phieu_thu
                m_us_gd_phieu_thu.CommitTransaction();
            }
            catch (Exception v_e) {
                if (m_us_gd_phieu_thu.is_having_transaction()) {
                    m_us_gd_phieu_thu.Rollback();
                }
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }
        private void save_data() {
            if (!check_validate_data()) {
                return;
            }
            if (!check_tong_tien_grid_textbox()) {
                return;
            }

            decimal v_dc_id_phieu_thu = 0;
            switch (m_e_form_mode) {
                case DataEntryFormMode.InsertDataState:
                    if (!is_exist_so_phieu(ref v_dc_id_phieu_thu)) {
                        insert_phieu_thu_ct_phieu_thu();
                    }
                    else {
                        insert_chi_tiet_phieu_thu(v_dc_id_phieu_thu);
                    }
                    break;
                case DataEntryFormMode.UpdateDataState:
                    form_2_us_gd_phieu_thu();
                    m_us_gd_phieu_thu.BeginTransaction();
                    m_us_gd_ct_phieu_thu.UseTransOfUSObject(m_us_gd_phieu_thu);
                    m_us_gd_phieu_thu.Update();

                    //Delete het chi tiet phieu thu tu id_phieu_thu
                    US_GD_CHI_TIET_PHIEU_THU v_us_gd_ct_pt = new US_GD_CHI_TIET_PHIEU_THU();
                    v_us_gd_ct_pt.deleteAllFromIDPhieuThu(m_us_gd_phieu_thu.dcID);
                    //Insert lai chi tiet phieu thu
                    for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count; v_i_cur_row++) {
                        US_V_F340_LOP_MON_CUA_HS v_us_lm_hs = new US_V_F340_LOP_MON_CUA_HS();
                        grid2us_object(v_us_lm_hs, v_i_cur_row);
                        m_us_gd_ct_phieu_thu.dcID_LOP_MON = v_us_lm_hs.dcID_LOP_MON;
                        m_us_gd_ct_phieu_thu.dcID_GD_PHIEU_THU = m_us_gd_phieu_thu.dcID;
                        m_us_gd_ct_phieu_thu.dcSO_TIEN = CIPConvert.ToDecimal(m_fg.Rows[v_i_cur_row][(int)e_col_Number.SO_TIEN].ToString().Trim());////Cho nay de chet, can sua sau
                        m_us_gd_ct_phieu_thu.Insert();
                    }

                    m_us_gd_phieu_thu.CommitTransaction();
                    break;
                default:
                    break;
            }
            //decimal v_dc_id_phieu_thu = 0;
            //if (!is_exist_so_phieu(ref v_dc_id_phieu_thu)) {
            //    insert_phieu_thu_ct_phieu_thu();
            //}
            //else {
            //    insert_chi_tiet_phieu_thu(v_dc_id_phieu_thu);
            //}
            BaseMessages.MsgBox_Infor("Đã cập nhật thành công");
        }
        private void insert_v_rpt_nghiep_vu_lap_phieu_thu() {
            save_data();
        }

        private void grid2us_object(US_V_F340_LOP_MON_CUA_HS i_us
            , int i_grid_row) {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }
        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //

        private void set_define_events() {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_ds_phieu.Click += new EventHandler(m_cmd_ds_phieu_Click);
            m_cmd_chon_hs.Click += m_cmd_chon_hs_Click;
            m_txt_ho_ten_hs.TextChanged += m_txt_ho_ten_hs_TextChanged;
            m_fg.AfterEdit += m_fg_AfterEdit;
        }

        private void m_fg_AfterEdit(object sender, RowColEventArgs e) {
            try {
                decimal v_dc_tong_tien = 0;
                for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count; v_i_cur_row++) {
                    if (m_fg.Rows[v_i_cur_row][(int)e_col_Number.SO_TIEN] != null && m_fg.Rows[v_i_cur_row][(int)e_col_Number.SO_TIEN].ToString() != "") {
                        v_dc_tong_tien = v_dc_tong_tien + CIPConvert.ToDecimal(m_fg.Rows[v_i_cur_row][(int)e_col_Number.SO_TIEN].ToString().Trim());
                    }
                }
                m_txt_so_tien.Text = string.Format("{0:#,##0}", v_dc_tong_tien);
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_ho_ten_hs_TextChanged(object sender, EventArgs e) {
            try {
                load_data_2_grid();
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_ds_phieu_Click(object sender, EventArgs e) {
            try {
                f430_bao_cao_danh_sach_phai_thu_thuc_thu v_frm = new f430_bao_cao_danh_sach_phai_thu_thuc_thu();
                switch (m_str_loai_form) {
                    case "PHAI_THU":
                        v_frm.display_phieu_phai_thu();
                        break;
                    case "THUC_THU":
                        v_frm.display_phieu_thuc_thu();
                        break;
                    default:
                        break;
                }

            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_chon_hs_Click(object sender, EventArgs e) {
            try {
                f220_cap_nhat_thong_tin_hoc_sinh v_frm = new f220_cap_nhat_thong_tin_hoc_sinh();
                v_frm.select_hoc_sinh(ref m_us_v_hoc_sinh);//co sưa lay us_v_hoc_sinh

                m_txt_ho_ten_hs.Text = m_us_v_hoc_sinh.strHO_TEN;//lay ho ten tu view us_v_hoc_sinh ban dau la us_v_dm_hoc_sinh
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void f340_lap_phieu_thu_Load(object sender, System.EventArgs e) {
            try {
                set_initial_form_load();
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_exit_Click(object sender, EventArgs e) {
            try {
                this.Close();
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_insert_Click(object sender, EventArgs e) {
            try {
                insert_v_rpt_nghiep_vu_lap_phieu_thu();
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}