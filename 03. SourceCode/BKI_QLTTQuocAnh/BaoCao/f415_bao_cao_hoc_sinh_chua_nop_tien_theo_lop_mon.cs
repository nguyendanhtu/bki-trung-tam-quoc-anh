///************************************************
/// Generated by: Haihd
/// Date: 29/01/2015 04:03:39
/// Goal: Create Form for V_RPT_415_BC_HS_CHUA_NOP_TIEN_THEO_LOP_MON
///************************************************


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

using C1.Win.C1FlexGrid;

namespace BKI_QLTTQuocAnh.BaoCao
{



	public class f415_bao_cao_hoc_sinh_chua_nop_tien_theo_lop_mon : System.Windows.Forms.Form
	{

        #region Design on Form
        internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
        internal ImageList imageList1;
        private Panel panel1;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private TextBox m_txt_tim_kiem;
        private Label m_lbl_header;
        private DateTimePicker m_dat_tu_ngay;
        private Label m_lbl_tu_ngay;
        private ComboBox m_cbo_lop;
        private Label m_lbl_den_ngay;
        private DateTimePicker m_dat_den_ngay;
        private Label m_lbl_tim_kiem;
        private Label m_lbl_lop_mon;
		private System.ComponentModel.IContainer components;
        #endregion

		public f415_bao_cao_hoc_sinh_chua_nop_tien_theo_lop_mon()
		{
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
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f415_bao_cao_hoc_sinh_chua_nop_tien_theo_lop_mon));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_dat_tu_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_tu_ngay = new System.Windows.Forms.Label();
            this.m_cbo_lop = new System.Windows.Forms.ComboBox();
            this.m_lbl_den_ngay = new System.Windows.Forms.Label();
            this.m_dat_den_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_tim_kiem = new System.Windows.Forms.Label();
            this.m_lbl_lop_mon = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.panel1.SuspendLayout();
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
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 343);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(653, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
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
            this.m_cmd_insert.Location = new System.Drawing.Point(297, 4);
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
            this.m_cmd_update.Location = new System.Drawing.Point(385, 4);
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
            this.m_cmd_delete.Location = new System.Drawing.Point(473, 4);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(561, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 131);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(653, 212);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.m_txt_tim_kiem);
            this.panel1.Controls.Add(this.m_lbl_header);
            this.panel1.Controls.Add(this.m_dat_tu_ngay);
            this.panel1.Controls.Add(this.m_lbl_tu_ngay);
            this.panel1.Controls.Add(this.m_cbo_lop);
            this.panel1.Controls.Add(this.m_lbl_den_ngay);
            this.panel1.Controls.Add(this.m_dat_den_ngay);
            this.panel1.Controls.Add(this.m_lbl_tim_kiem);
            this.panel1.Controls.Add(this.m_lbl_lop_mon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 131);
            this.panel1.TabIndex = 31;
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.imageList1;
            this.m_cmd_search.Location = new System.Drawing.Point(328, 96);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 9;
            this.m_cmd_search.Text = "Lọc dữ liệu";
            this.m_cmd_search.Click += new System.EventHandler(this.m_cmd_search_Click);
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(124, 100);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(190, 20);
            this.m_txt_tim_kiem.TabIndex = 8;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(653, 43);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "BÁO CÁO HỌC SINH CHƯA NỘP TIỀN";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_dat_tu_ngay
            // 
            this.m_dat_tu_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dat_tu_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_tu_ngay.Location = new System.Drawing.Point(124, 46);
            this.m_dat_tu_ngay.Name = "m_dat_tu_ngay";
            this.m_dat_tu_ngay.Size = new System.Drawing.Size(86, 20);
            this.m_dat_tu_ngay.TabIndex = 2;
            // 
            // m_lbl_tu_ngay
            // 
            this.m_lbl_tu_ngay.AutoSize = true;
            this.m_lbl_tu_ngay.Location = new System.Drawing.Point(10, 50);
            this.m_lbl_tu_ngay.Name = "m_lbl_tu_ngay";
            this.m_lbl_tu_ngay.Size = new System.Drawing.Size(72, 13);
            this.m_lbl_tu_ngay.TabIndex = 1;
            this.m_lbl_tu_ngay.Text = "Từ đầu tháng";
            // 
            // m_cbo_lop
            // 
            this.m_cbo_lop.FormattingEnabled = true;
            this.m_cbo_lop.Location = new System.Drawing.Point(124, 73);
            this.m_cbo_lop.Name = "m_cbo_lop";
            this.m_cbo_lop.Size = new System.Drawing.Size(190, 21);
            this.m_cbo_lop.TabIndex = 6;
            // 
            // m_lbl_den_ngay
            // 
            this.m_lbl_den_ngay.AutoSize = true;
            this.m_lbl_den_ngay.Location = new System.Drawing.Point(221, 50);
            this.m_lbl_den_ngay.Name = "m_lbl_den_ngay";
            this.m_lbl_den_ngay.Size = new System.Drawing.Size(80, 13);
            this.m_lbl_den_ngay.TabIndex = 3;
            this.m_lbl_den_ngay.Text = "Đến cuối tháng";
            // 
            // m_dat_den_ngay
            // 
            this.m_dat_den_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dat_den_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_den_ngay.Location = new System.Drawing.Point(313, 46);
            this.m_dat_den_ngay.Name = "m_dat_den_ngay";
            this.m_dat_den_ngay.Size = new System.Drawing.Size(87, 20);
            this.m_dat_den_ngay.TabIndex = 4;
            // 
            // m_lbl_tim_kiem
            // 
            this.m_lbl_tim_kiem.AutoSize = true;
            this.m_lbl_tim_kiem.Location = new System.Drawing.Point(10, 104);
            this.m_lbl_tim_kiem.Name = "m_lbl_tim_kiem";
            this.m_lbl_tim_kiem.Size = new System.Drawing.Size(108, 13);
            this.m_lbl_tim_kiem.TabIndex = 7;
            this.m_lbl_tim_kiem.Text = "Tìm kiếm (tên-mã HS)";
            // 
            // m_lbl_lop_mon
            // 
            this.m_lbl_lop_mon.AutoSize = true;
            this.m_lbl_lop_mon.Location = new System.Drawing.Point(10, 77);
            this.m_lbl_lop_mon.Name = "m_lbl_lop_mon";
            this.m_lbl_lop_mon.Size = new System.Drawing.Size(48, 13);
            this.m_lbl_lop_mon.TabIndex = 5;
            this.m_lbl_lop_mon.Text = "Lớp môn";
            // 
            // f415_bao_cao_hoc_sinh_chua_nop_tien_theo_lop_mon
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(653, 379);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f415_bao_cao_hoc_sinh_chua_nop_tien_theo_lop_mon";
            this.Text = "F415 - Báo cáo học sinh chưa nộp tiền theo lớp môn";
            this.Load += new System.EventHandler(this.f415_bao_cao_hoc_sinh_chua_nop_tien_theo_lop_mon_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region Public Interface
		public void display(){
            load_data_2_cbo_lop_mon();
			this.ShowDialog();
		}
		#endregion

		#region Data Structure
		private enum e_col_Number{
			TIEN_CON_PHAI_THU = 4
,MA_LOP_MON = 1
,HO_TEN = 3
,MA_DOI_TUONG = 2

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_RPT_415_BC_HS_CHUA_NOP_TIEN_THEO_LOP_MON m_ds = new DS_V_RPT_415_BC_HS_CHUA_NOP_TIEN_THEO_LOP_MON();
		US_V_RPT_415_BC_HS_CHUA_NOP_TIEN_THEO_LOP_MON m_us = new US_V_RPT_415_BC_HS_CHUA_NOP_TIEN_THEO_LOP_MON();
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			CControlFormat.setC1FlexFormat(m_fg);
			CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);

            m_fg.Tree.Column = (int)e_col_Number.MA_LOP_MON;
            //m_fg.Cols[(int)e_col_Number.MA_LOP_MON].Visible = false;
            //m_fg.Cols[(int)e_col_Number.MA_DOI_TUONG].Visible = false;

			set_define_events();
			this.KeyPreview = true;
            m_cmd_insert.Visible = false;
            m_cmd_delete.Visible = false;
            m_cmd_update.Visible = false;
            m_cmd_exit.Visible = false;
            m_cmd_xuat_excel.Visible = false;
		}
        private void wrap_text_cell()
        {
            m_fg.Styles[CellStyleEnum.Normal].WordWrap = true;
            m_fg.AllowResizing = AllowResizingEnum.Rows;
            m_fg.AutoSizeRows();
        }
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
			load_data_2_grid();
            load_data_2_cbo_lop_mon();
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_RPT_415_BC_HS_CHUA_NOP_TIEN_THEO_LOP_MON.TIEN_CON_PHAI_THU, e_col_Number.TIEN_CON_PHAI_THU);
			v_htb.Add(V_RPT_415_BC_HS_CHUA_NOP_TIEN_THEO_LOP_MON.MA_LOP_MON, e_col_Number.MA_LOP_MON);
			v_htb.Add(V_RPT_415_BC_HS_CHUA_NOP_TIEN_THEO_LOP_MON.HO_TEN, e_col_Number.HO_TEN);
			v_htb.Add(V_RPT_415_BC_HS_CHUA_NOP_TIEN_THEO_LOP_MON.MA_DOI_TUONG, e_col_Number.MA_DOI_TUONG);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_RPT_415_BC_HS_CHUA_NOP_TIEN_THEO_LOP_MON.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){
            DS_V_RPT_415_BC_HS_CHUA_NOP_TIEN_THEO_LOP_MON v_ds = new DS_V_RPT_415_BC_HS_CHUA_NOP_TIEN_THEO_LOP_MON();
            US_V_RPT_415_BC_HS_CHUA_NOP_TIEN_THEO_LOP_MON v_us = new US_V_RPT_415_BC_HS_CHUA_NOP_TIEN_THEO_LOP_MON();
            v_ds.EnforceConstraints = false;
            if (m_cbo_lop.DataSource == null)
            {
                return;
            }
            v_us.FillDatasetSearch(v_ds
                , m_dat_tu_ngay.Value.Date
                , m_dat_den_ngay.Value.Date
                , CIPConvert.ToDecimal(m_cbo_lop.SelectedValue)
                , -1
                ,m_txt_tim_kiem.Text.Trim());
			m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds, m_fg, m_obj_trans);

            //m_fg.Subtotal(AggregateEnum.Sum
            //  , 0
            //    , -1
            //    , (int)e_col_Number.TIEN_CON_PHAI_THU
            //   , "Tổng");

            wrap_text_cell();

			m_fg.Redraw = true;
		}
        private void load_data_2_cbo_lop_mon()
        {
            DS_DM_LOP_MON v_ds = new DS_DM_LOP_MON();
            US_DM_LOP_MON v_us = new US_DM_LOP_MON();
            v_us.FillDataset(v_ds);
            DataRow v_dr = v_ds.DM_LOP_MON.NewRow();
            v_dr[DM_LOP_MON.ID] = -1;
            v_dr[DM_LOP_MON.MO_TA] = "--Tất cả--";
            v_dr[DM_LOP_MON.DON_GIA_BUOI_HOC] = 0;

            v_ds.DM_LOP_MON.Rows.InsertAt(v_dr, 0);

            m_cbo_lop.DataSource = v_ds.DM_LOP_MON;
            m_cbo_lop.DisplayMember = DM_LOP_MON.MO_TA;
            m_cbo_lop.ValueMember = DM_LOP_MON.ID;

            m_cbo_lop.SelectedIndex = 0;
        }
        private void grid2us_object(US_V_RPT_415_BC_HS_CHUA_NOP_TIEN_THEO_LOP_MON i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_RPT_415_BC_HS_CHUA_NOP_TIEN_THEO_LOP_MON i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_v_rpt_415_bc_hs_chua_nop_tien_theo_lop_mon(){			
		//	f415_bao_cao_hoc_sinh_chua_nop_tien_theo_lop_mon_DE v_fDE = new  f415_bao_cao_hoc_sinh_chua_nop_tien_theo_lop_mon_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_v_rpt_415_bc_hs_chua_nop_tien_theo_lop_mon(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;			
			grid2us_object(m_us, m_fg.Row);
		//	f415_bao_cao_hoc_sinh_chua_nop_tien_theo_lop_mon_DE v_fDE = new f415_bao_cao_hoc_sinh_chua_nop_tien_theo_lop_mon_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void delete_v_rpt_415_bc_hs_chua_nop_tien_theo_lop_mon(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_RPT_415_BC_HS_CHUA_NOP_TIEN_THEO_LOP_MON v_us = new US_V_RPT_415_BC_HS_CHUA_NOP_TIEN_THEO_LOP_MON();
			grid2us_object(v_us, m_fg.Row);
			try {			
				v_us.BeginTransaction();    											
				v_us.Delete();                      								
				v_us.CommitTransaction();
				m_fg.Rows.Remove(m_fg.Row);				
			}
			catch (Exception v_e) {
				v_us.Rollback();
				CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
					new CDBClientDBExceptionInterpret());
				v_objErrHandler.showErrorMessage();
			}
		}

		private void view_v_rpt_415_bc_hs_chua_nop_tien_theo_lop_mon(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
		//	f415_bao_cao_hoc_sinh_chua_nop_tien_theo_lop_mon_DE v_fDE = new f415_bao_cao_hoc_sinh_chua_nop_tien_theo_lop_mon_DE();			
		//	v_fDE.display(m_us);
		}
		
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_cmd_xuat_excel.Click += new EventHandler(m_cmd_xuat_excel_Click);
        }

		private void f415_bao_cao_hoc_sinh_chua_nop_tien_theo_lop_mon_Load(object sender, System.EventArgs e) {
			try{
				set_initial_form_load();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		
		}

		private void m_cmd_exit_Click(object sender, EventArgs e) {
			try{
				this.Close();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_insert_Click(object sender, EventArgs e) {
			try{
				insert_v_rpt_415_bc_hs_chua_nop_tien_theo_lop_mon();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_v_rpt_415_bc_hs_chua_nop_tien_theo_lop_mon();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_v_rpt_415_bc_hs_chua_nop_tien_theo_lop_mon();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_xuat_excel_Click(object sender, EventArgs e) {
			try{
				view_v_rpt_415_bc_hs_chua_nop_tien_theo_lop_mon();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

        private void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

	}
}

