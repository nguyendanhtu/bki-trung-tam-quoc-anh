


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
        private Label label1;
        private ComboBox m_cbo_lop_mon;
        internal SIS.Controls.Button.SiSButton m_cmd_ds_phieu;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private Label label2;
        private TextBox m_txt_so_tien;
        private Label label3;
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txt_so_tien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_cbo_lop_mon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(901, 42);
            this.panel1.TabIndex = 21;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(901, 41);
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
            this.m_cmd_insert.TabIndex = 0;
            this.m_cmd_insert.Text = "&Cập nhật phiếu";
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_ds_phieu);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 395);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(901, 36);
            this.m_pnl_out_place_dm.TabIndex = 22;
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
            this.m_cmd_ds_phieu.TabIndex = 1;
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
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 353);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.m_txt_so_tien);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.m_cbo_lop_mon);
            this.panel3.Controls.Add(this.label1);
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
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(901, 353);
            this.panel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "(VNĐ)";
            // 
            // m_txt_so_tien
            // 
            this.m_txt_so_tien.Location = new System.Drawing.Point(131, 177);
            this.m_txt_so_tien.Name = "m_txt_so_tien";
            this.m_txt_so_tien.Size = new System.Drawing.Size(129, 20);
            this.m_txt_so_tien.TabIndex = 11;
            this.m_txt_so_tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "SỐ TIỀN(*)";
            // 
            // m_cbo_lop_mon
            // 
            this.m_cbo_lop_mon.FormattingEnabled = true;
            this.m_cbo_lop_mon.Location = new System.Drawing.Point(133, 136);
            this.m_cbo_lop_mon.Name = "m_cbo_lop_mon";
            this.m_cbo_lop_mon.Size = new System.Drawing.Size(127, 21);
            this.m_cbo_lop_mon.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chọn lớp môn(*)";
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
            this.m_cmd_chon_hs.TabIndex = 5;
            this.m_cmd_chon_hs.Text = "&Chọn HS";
            // 
            // m_cbo_nhan_vien_thu
            // 
            this.m_cbo_nhan_vien_thu.FormattingEnabled = true;
            this.m_cbo_nhan_vien_thu.Location = new System.Drawing.Point(591, 9);
            this.m_cbo_nhan_vien_thu.Name = "m_cbo_nhan_vien_thu";
            this.m_cbo_nhan_vien_thu.Size = new System.Drawing.Size(190, 21);
            this.m_cbo_nhan_vien_thu.TabIndex = 15;
            // 
            // m_cbo_nhan_vien_nhap
            // 
            this.m_cbo_nhan_vien_nhap.FormattingEnabled = true;
            this.m_cbo_nhan_vien_nhap.Location = new System.Drawing.Point(591, 45);
            this.m_cbo_nhan_vien_nhap.Name = "m_cbo_nhan_vien_nhap";
            this.m_cbo_nhan_vien_nhap.Size = new System.Drawing.Size(127, 21);
            this.m_cbo_nhan_vien_nhap.TabIndex = 17;
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
            this.m_dat_ngay_nhap.Size = new System.Drawing.Size(84, 20);
            this.m_dat_ngay_nhap.TabIndex = 19;
            // 
            // m_dat_ngay_thu
            // 
            this.m_dat_ngay_thu.CustomFormat = "dd/MM/yyyy";
            this.m_dat_ngay_thu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_ngay_thu.Location = new System.Drawing.Point(133, 36);
            this.m_dat_ngay_thu.Name = "m_dat_ngay_thu";
            this.m_dat_ngay_thu.Size = new System.Drawing.Size(103, 20);
            this.m_dat_ngay_thu.TabIndex = 3;
            // 
            // m_txt_noi_dung
            // 
            this.m_txt_noi_dung.Location = new System.Drawing.Point(133, 215);
            this.m_txt_noi_dung.Multiline = true;
            this.m_txt_noi_dung.Name = "m_txt_noi_dung";
            this.m_txt_noi_dung.Size = new System.Drawing.Size(219, 46);
            this.m_txt_noi_dung.TabIndex = 13;
            // 
            // m_lbl_hoc_sinh
            // 
            this.m_lbl_hoc_sinh.AutoSize = true;
            this.m_lbl_hoc_sinh.Location = new System.Drawing.Point(11, 68);
            this.m_lbl_hoc_sinh.Name = "m_lbl_hoc_sinh";
            this.m_lbl_hoc_sinh.Size = new System.Drawing.Size(92, 13);
            this.m_lbl_hoc_sinh.TabIndex = 74;
            this.m_lbl_hoc_sinh.Text = "Họ tên học sinh(*)";
            // 
            // m_lbl_den_ngay
            // 
            this.m_lbl_den_ngay.AutoSize = true;
            this.m_lbl_den_ngay.Location = new System.Drawing.Point(485, 80);
            this.m_lbl_den_ngay.Name = "m_lbl_den_ngay";
            this.m_lbl_den_ngay.Size = new System.Drawing.Size(59, 13);
            this.m_lbl_den_ngay.TabIndex = 18;
            this.m_lbl_den_ngay.Text = "Ngày nhập";
            // 
            // m_lbl_noi_dung
            // 
            this.m_lbl_noi_dung.AutoSize = true;
            this.m_lbl_noi_dung.Location = new System.Drawing.Point(11, 218);
            this.m_lbl_noi_dung.Name = "m_lbl_noi_dung";
            this.m_lbl_noi_dung.Size = new System.Drawing.Size(60, 13);
            this.m_lbl_noi_dung.TabIndex = 12;
            this.m_lbl_noi_dung.Text = "Nội dung(*)";
            // 
            // m_txt_ten_nguoi_nop_tien
            // 
            this.m_txt_ten_nguoi_nop_tien.Location = new System.Drawing.Point(133, 101);
            this.m_txt_ten_nguoi_nop_tien.Name = "m_txt_ten_nguoi_nop_tien";
            this.m_txt_ten_nguoi_nop_tien.Size = new System.Drawing.Size(219, 20);
            this.m_txt_ten_nguoi_nop_tien.TabIndex = 7;
            // 
            // m_lbl_nhan_vien_nhap
            // 
            this.m_lbl_nhan_vien_nhap.AutoSize = true;
            this.m_lbl_nhan_vien_nhap.Location = new System.Drawing.Point(485, 48);
            this.m_lbl_nhan_vien_nhap.Name = "m_lbl_nhan_vien_nhap";
            this.m_lbl_nhan_vien_nhap.Size = new System.Drawing.Size(93, 13);
            this.m_lbl_nhan_vien_nhap.TabIndex = 16;
            this.m_lbl_nhan_vien_nhap.Text = "Nhân viên nhập(*)";
            // 
            // m_txt_ho_ten_hs
            // 
            this.m_txt_ho_ten_hs.Location = new System.Drawing.Point(133, 65);
            this.m_txt_ho_ten_hs.Name = "m_txt_ho_ten_hs";
            this.m_txt_ho_ten_hs.Size = new System.Drawing.Size(219, 20);
            this.m_txt_ho_ten_hs.TabIndex = 4;
            // 
            // m_lbl_ten_nguoi_nop_tien
            // 
            this.m_lbl_ten_nguoi_nop_tien.AutoSize = true;
            this.m_lbl_ten_nguoi_nop_tien.Location = new System.Drawing.Point(11, 104);
            this.m_lbl_ten_nguoi_nop_tien.Name = "m_lbl_ten_nguoi_nop_tien";
            this.m_lbl_ten_nguoi_nop_tien.Size = new System.Drawing.Size(106, 13);
            this.m_lbl_ten_nguoi_nop_tien.TabIndex = 6;
            this.m_lbl_ten_nguoi_nop_tien.Text = "Tên người nộp tiền(*)";
            // 
            // m_lbl_nhan_vien_thu
            // 
            this.m_lbl_nhan_vien_thu.AutoSize = true;
            this.m_lbl_nhan_vien_thu.Location = new System.Drawing.Point(485, 12);
            this.m_lbl_nhan_vien_thu.Name = "m_lbl_nhan_vien_thu";
            this.m_lbl_nhan_vien_thu.Size = new System.Drawing.Size(84, 13);
            this.m_lbl_nhan_vien_thu.TabIndex = 14;
            this.m_lbl_nhan_vien_thu.Text = "Nhân viên thu(*)";
            // 
            // m_lbl_so_phieu
            // 
            this.m_lbl_so_phieu.AutoSize = true;
            this.m_lbl_so_phieu.Location = new System.Drawing.Point(11, 9);
            this.m_lbl_so_phieu.Name = "m_lbl_so_phieu";
            this.m_lbl_so_phieu.Size = new System.Drawing.Size(59, 13);
            this.m_lbl_so_phieu.TabIndex = 0;
            this.m_lbl_so_phieu.Text = "Số phiếu(*)";
            // 
            // m_txt_so_phieu
            // 
            this.m_txt_so_phieu.Location = new System.Drawing.Point(133, 6);
            this.m_txt_so_phieu.Name = "m_txt_so_phieu";
            this.m_txt_so_phieu.Size = new System.Drawing.Size(103, 20);
            this.m_txt_so_phieu.TabIndex = 1;
            // 
            // f340_lap_phieu_thu
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(901, 431);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.panel1);
            this.Name = "f340_lap_phieu_thu";
            this.Text = "F340 - Lập phiếu ";
            this.Load += new System.EventHandler(this.f340_lap_phieu_thu_Load);
            this.panel1.ResumeLayout(false);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Public Interface
        public void set_phieu_thuc_thu() {
            m_str_loai_form = "THUC_THU";
            m_lbl_header.Text = "LẬP PHIẾU THỰC THU";
        }
        public void set_phieu_phai_thu() {
            m_str_loai_form = "PHAI_THU";
            m_lbl_header.Text = "LẬP PHIẾU PHẢI THU";
        }
        public void display(US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU ip_us, decimal ip_dc_id_loai_phieu_thu, decimal ip_dc_id_nguoi_nhap) {
            m_txt_so_phieu.Text = ip_us.strSO_PHIEU.Trim();
            m_txt_ho_ten_hs.Text = ip_us.strHO_TEN_HS.Trim();
            m_txt_ten_nguoi_nop_tien.Text = ip_us.strHO_TEN_PH.Trim();
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
            US_V_GD_PHIEU_THU v_us_v_pt = new US_V_GD_PHIEU_THU(ip_us.dcID);
            //m_lbl_header.Text = "LẬP " + v_us_v_pt.strTEN_NGAN;

            m_dat_ngay_thu.Value = ip_us.datNGAY_THU;
            m_dat_ngay_nhap.Value = DateTime.Now;

            load_data_2_cbo();
            m_cbo_nhan_vien_nhap.SelectedValue = ip_dc_id_nguoi_nhap;
            m_cbo_nhan_vien_thu.SelectedValue = ip_us.dcID_NGUOI_THU;

            m_cmd_ds_phieu.Visible = false;
            this.ShowDialog();
        }

        #endregion

        #region Members
        US_GD_PHIEU_THU m_us_gd_phieu_thu = new US_GD_PHIEU_THU();
        US_GD_CHI_TIET_PHIEU_THU m_us_gd_ct_phieu_thu = new US_GD_CHI_TIET_PHIEU_THU();
        US_V_DM_HOC_SINH m_us_v_dm_hoc_sinh = new US_V_DM_HOC_SINH();
        US_V_HOC_SINH m_us_v_hoc_sinh = new US_V_HOC_SINH();
        DataEntryFormMode m_e_form_mode;
        string m_str_loai_form = "";// = "PHAI_THU" or "THUC_THU"
        #endregion

        #region Private Methods
        private void load_data_2_cbo() {
            load_data_2_cbo_nguoi_nhap();
            load_data_2_cbo_nguoi_thu();
            load_data_2_cbo_lop_mon();
        }
        private void format_controls() {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            set_define_events();

            this.KeyPreview = true;
        }
        private void set_initial_form_load() {
            load_data_2_cbo();
        }


        private void load_data_2_cbo_nguoi_thu() {
            DS_V_HT_NGUOI_SU_DUNG v_ds = new DS_V_HT_NGUOI_SU_DUNG();
            US_V_HT_NGUOI_SU_DUNG v_us = new US_V_HT_NGUOI_SU_DUNG();

            v_us.FillDataset(v_ds);

            //DataRow v_dr = v_ds.V_HT_NGUOI_SU_DUNG.NewRow();
            //v_dr[V_HT_NGUOI_SU_DUNG.ID] = -1;
            //v_dr[V_HT_NGUOI_SU_DUNG.TEN_TRUY_CAP] = "All";
            //v_dr[V_HT_NGUOI_SU_DUNG.TEN] = "--Chưa chọn---";
            //v_dr[V_HT_NGUOI_SU_DUNG.MAT_KHAU] = 123;
            //v_dr[V_HT_NGUOI_SU_DUNG.NGAY_TAO] = "2015-01-20";
            //v_dr[V_HT_NGUOI_SU_DUNG.NGUOI_TAO] = "ADMIN";
            //v_dr[V_HT_NGUOI_SU_DUNG.TRANG_THAI] = "0";
            //v_dr[V_HT_NGUOI_SU_DUNG.BUILT_IN_YN] = "Y";
            //v_dr[V_HT_NGUOI_SU_DUNG.ID_USER_GROUP] = 3;


            //v_ds.V_HT_NGUOI_SU_DUNG.Rows.InsertAt(v_dr, 0);

            m_cbo_nhan_vien_thu.DataSource = v_ds.V_HT_NGUOI_SU_DUNG;
            m_cbo_nhan_vien_thu.DisplayMember = V_HT_NGUOI_SU_DUNG.TEN;
            m_cbo_nhan_vien_thu.ValueMember = V_HT_NGUOI_SU_DUNG.ID;

            //m_cbo_nhan_vien_thu.SelectedIndex = 0;
            m_cbo_nhan_vien_thu.SelectedValue = CAppContext_201.getCurrentUserID();
        }

        private void load_data_2_cbo_nguoi_nhap() {
            DS_V_HT_NGUOI_SU_DUNG v_ds = new DS_V_HT_NGUOI_SU_DUNG();
            US_V_HT_NGUOI_SU_DUNG v_us = new US_V_HT_NGUOI_SU_DUNG();

            v_us.FillDataset(v_ds);

            //DataRow v_dr = v_ds.V_HT_NGUOI_SU_DUNG.NewRow();
            //v_dr[V_HT_NGUOI_SU_DUNG.ID] = -1;
            //v_dr[V_HT_NGUOI_SU_DUNG.TEN_TRUY_CAP] = "All";
            //v_dr[V_HT_NGUOI_SU_DUNG.TEN] = "--Chưa chọn---";
            //v_dr[V_HT_NGUOI_SU_DUNG.MAT_KHAU] = 123;
            //v_dr[V_HT_NGUOI_SU_DUNG.NGAY_TAO] = "2015-01-20";
            //v_dr[V_HT_NGUOI_SU_DUNG.NGUOI_TAO] = "ADMIN";
            //v_dr[V_HT_NGUOI_SU_DUNG.TRANG_THAI] = "0";
            //v_dr[V_HT_NGUOI_SU_DUNG.BUILT_IN_YN] = "Y";
            //v_dr[V_HT_NGUOI_SU_DUNG.ID_USER_GROUP] = 3;


            //v_ds.V_HT_NGUOI_SU_DUNG.Rows.InsertAt(v_dr, 0);

            m_cbo_nhan_vien_nhap.DataSource = v_ds.V_HT_NGUOI_SU_DUNG;
            m_cbo_nhan_vien_nhap.DisplayMember = V_HT_NGUOI_SU_DUNG.TEN;
            m_cbo_nhan_vien_nhap.ValueMember = V_HT_NGUOI_SU_DUNG.ID;

            //m_cbo_nhan_vien_nhap.SelectedIndex = 0;
            m_cbo_nhan_vien_nhap.SelectedValue = CAppContext_201.getCurrentUserID();
        }
        private void load_data_2_cbo_lop_mon() {
            DS_DM_LOP_MON v_ds = new DS_DM_LOP_MON();
            US_DM_LOP_MON v_us = new US_DM_LOP_MON();

            v_us.FillDataset(v_ds);

            DataRow v_dr = v_ds.DM_LOP_MON.NewRow();
            v_dr[DM_LOP_MON.ID] = -1;
            v_dr[DM_LOP_MON.MA_LOP_MON] = "CHUA_CHON";
            v_dr[DM_LOP_MON.MO_TA] = "--Chưa chọn--";
            v_dr[DM_LOP_MON.DON_GIA_BUOI_HOC] = 1;


            v_ds.DM_LOP_MON.Rows.InsertAt(v_dr, 0);

            m_cbo_lop_mon.DataSource = v_ds.DM_LOP_MON;
            m_cbo_lop_mon.DisplayMember = DM_LOP_MON.MO_TA;
            m_cbo_lop_mon.ValueMember = DM_LOP_MON.ID;

            m_cbo_lop_mon.SelectedIndex = 0;
        }
        private void insert_v_rpt_nghiep_vu_lap_phieu_thu() {
            save_data();
        }
        private bool check_validate_data() {
            if (!CValidateTextBox.IsValid(m_txt_so_phieu, DataType.StringType, allowNull.NO,false)) {
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
            if (m_cbo_lop_mon.SelectedIndex == 0) {
                BaseMessages.MsgBox_Infor("Bạn chưa chọn LỚP MÔN!");
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

            if (m_cbo_nhan_vien_nhap.SelectedIndex == 0) {
                BaseMessages.MsgBox_Infor("Bạn chưa chọn NHÂN VIÊN NHẬP!");
                return false;
            }
            if (m_cbo_nhan_vien_thu.SelectedIndex == 0) {
                BaseMessages.MsgBox_Infor("Bạn chưa chọn NHÂN VIÊN THU!");
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
        private void save_data() {
            if (!check_validate_data()) {
                return;
            } 
            decimal v_dc_id_phieu_thu = 0;
            if (!is_exist_so_phieu(ref v_dc_id_phieu_thu)) {
                insert_phieu_thu_ct_phieu_thu();
            }
            else {
                insert_chi_tiet_phieu_thu(v_dc_id_phieu_thu);
            }
            BaseMessages.MsgBox_Infor("Đã cập nhật thành công");
        }

        private void insert_chi_tiet_phieu_thu(decimal ip_id_phieu_thu) {
            //Day du lieu vao us_chi_tiet_phieu_thu
            m_us_gd_ct_phieu_thu.dcID_GD_PHIEU_THU = ip_id_phieu_thu;
            m_us_gd_ct_phieu_thu.dcID_LOP_MON = CIPConvert.ToDecimal(m_cbo_lop_mon.SelectedValue);
            m_us_gd_ct_phieu_thu.dcSO_TIEN = CIPConvert.ToDecimal(m_txt_so_tien.Text.Trim());////Cho nay de chet, can sua sau

            m_us_gd_ct_phieu_thu.Insert();
        }

        private void insert_phieu_thu_ct_phieu_thu() {
            try {
                form_2_us_gd_phieu_thu();
                m_us_gd_phieu_thu.BeginTransaction();
                m_us_gd_phieu_thu.Insert();
                m_us_gd_ct_phieu_thu.UseTransOfUSObject(m_us_gd_phieu_thu);

                //Day du lieu vao us_chi_tiet_phieu_thu
                m_us_gd_ct_phieu_thu.dcID_GD_PHIEU_THU = m_us_gd_phieu_thu.dcID;
                m_us_gd_ct_phieu_thu.dcID_LOP_MON = CIPConvert.ToDecimal(m_cbo_lop_mon.SelectedValue);
                m_us_gd_ct_phieu_thu.dcSO_TIEN = CIPConvert.ToDecimal(m_txt_so_tien.Text.Trim());////Cho nay de chet, can sua sau
                m_us_gd_ct_phieu_thu.Insert();

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

        private bool is_exist_so_phieu(ref decimal ip_dc_id_phieu) {
            US_GD_PHIEU_THU v_us = new US_GD_PHIEU_THU();
            if (!v_us.FindSoPhieuYN(m_txt_so_phieu.Text.Trim(), ref ip_dc_id_phieu)) {
                return false;
            } 
            return true;
        }

        private void insert() {
            
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