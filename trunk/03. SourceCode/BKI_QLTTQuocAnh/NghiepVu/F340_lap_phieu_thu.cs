///************************************************
/// Generated by: Haihd
/// Date: 23/01/2015 12:23:23
/// Goal: Create Form for V_RPT_NGHIEP_VU_LAP_PHIEU_THU
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

namespace BKI_QLTTQuocAnh.NghiepVu
{



	public class f340_lap_phieu_thu : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal SIS.Controls.Button.SiSButton m_cmd_view;
		private System.ComponentModel.IContainer components;

		public f340_lap_phieu_thu()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(f340_lap_phieu_thu));
			this.ImageList = new System.Windows.Forms.ImageList(this.components);
			this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
			this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
			this.m_cmd_update = new SIS.Controls.Button.SiSButton();
			this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
			this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
			this.m_cmd_view = new SIS.Controls.Button.SiSButton();
			this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.m_pnl_out_place_dm.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
			this.SuspendLayout();
			// 
			// ImageList
			// 
			this.ImageList.ImageSize = new System.Drawing.Size(16, 16);
			this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
			this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// m_pnl_out_place_dm
			// 
			this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
			this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
			this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_view);
			this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
			this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
			this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.m_pnl_out_place_dm.DockPadding.All = 4;
			this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 373);
			this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
			this.m_pnl_out_place_dm.Size = new System.Drawing.Size(686, 36);
			this.m_pnl_out_place_dm.TabIndex = 19;
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
			this.m_cmd_delete.Location = new System.Drawing.Point(506, 4);
			this.m_cmd_delete.Name = "m_cmd_delete";
			this.m_cmd_delete.Size = new System.Drawing.Size(88, 28);
			this.m_cmd_delete.TabIndex = 14;
			this.m_cmd_delete.Text = "&Xoá";
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
			this.m_cmd_update.Location = new System.Drawing.Point(418, 4);
			this.m_cmd_update.Name = "m_cmd_update";
			this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
			this.m_cmd_update.TabIndex = 13;
			this.m_cmd_update.Text = "&Sửa";
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
			this.m_cmd_insert.Location = new System.Drawing.Point(330, 4);
			this.m_cmd_insert.Name = "m_cmd_insert";
			this.m_cmd_insert.Size = new System.Drawing.Size(88, 28);
			this.m_cmd_insert.TabIndex = 12;
			this.m_cmd_insert.Text = "&Thêm";
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
			this.m_cmd_exit.Location = new System.Drawing.Point(594, 4);
			this.m_cmd_exit.Name = "m_cmd_exit";
			this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
			this.m_cmd_exit.TabIndex = 11;
			this.m_cmd_exit.Text = "Thoát (Esc)";
			// 
			// m_cmd_view
			// 
			this.m_cmd_view.AdjustImageLocation = new System.Drawing.Point(0, 0);
			this.m_cmd_view.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
			this.m_cmd_view.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
			this.m_cmd_view.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.m_cmd_view.ImageIndex = 18;
			this.m_cmd_view.ImageList = this.ImageList;
			this.m_cmd_view.Location = new System.Drawing.Point(4, 4);
			this.m_cmd_view.Name = "m_cmd_view";
			this.m_cmd_view.Size = new System.Drawing.Size(88, 28);
			this.m_cmd_view.TabIndex = 21;
			this.m_cmd_view.Text = "Xem";
			// 
			// m_fg
			// 
			this.m_fg.ColumnInfo = @"10,1,0,0,0,85,Columns:0{Width:13;}	 6{Caption:""Người thu"";Visible:True;DataType:System.String;TextAlign:LeftCenter;TextAlignFixed:CenterCenter;}2{Caption:""Học sinh"";Visible:True;DataType:System.String;TextAlign:LeftCenter;TextAlignFixed:CenterCenter;}1{Caption:""Số phiếu"";Visible:True;DataType:System.String;TextAlign:LeftCenter;TextAlignFixed:CenterCenter;}8{Caption:""Ngày thu"";Visible:True;DataType:System.Decimal;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}7{Caption:""Người nhập"";Visible:True;DataType:System.String;TextAlign:LeftCenter;TextAlignFixed:CenterCenter;}5{Caption:""Số tiền"";Visible:True;DataType:System.Decimal;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}4{Caption:""Nội dung"";Visible:True;DataType:System.String;TextAlign:LeftCenter;TextAlignFixed:CenterCenter;}3{Caption:""Người nộp tiền"";Visible:True;DataType:System.String;TextAlign:LeftCenter;TextAlignFixed:CenterCenter;}9{Caption:""Ngày nhập"";Visible:True;DataType:System.Decimal;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}	";
			this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_fg.Location = new System.Drawing.Point(0, 0);
			this.m_fg.Name = "m_fg";
			this.m_fg.Size = new System.Drawing.Size(686, 373);
			this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Microsoft Sans Serif, 8.25pt;}	Alternate{BackColor:Info;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.m_fg.TabIndex = 20;
			// 
			// f340_lap_phieu_thu
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(686, 409);
			this.Controls.Add(this.m_fg);
			this.Controls.Add(this.m_pnl_out_place_dm);
			this.Name = "f340_lap_phieu_thu";
			this.Text = "f340_lap_phieu_thu";
			this.Load += new System.EventHandler(this.f340_lap_phieu_thu_Load);
			this.m_pnl_out_place_dm.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region Public Interface
		public void display(){			
			this.ShowDialog();
		}
		#endregion

		#region Data Structure
		private enum e_col_Number{
			NGUOI_THU = 6
,HO_TEN_HOC_SINH = 2
,SO_PHIEU = 1
,NGAY_THU = 8
,NGUOI_NHAP = 7
,SO_TIEN = 5
,NOI_DUNG = 4
,TEN_NGUOI_NOP_TIEN = 3
,NGAY_NHAP = 9

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_RPT_NGHIEP_VU_LAP_PHIEU_THU m_ds = new DS_V_RPT_NGHIEP_VU_LAP_PHIEU_THU();
		US_V_RPT_NGHIEP_VU_LAP_PHIEU_THU m_us = new US_V_RPT_NGHIEP_VU_LAP_PHIEU_THU();
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201());
			CControlFormat.setC1FlexFormat(m_fg);
			CGridUtils.AddSave_Excel_Handlers(m_fg);
            			CGridUtils.AddSearch_Handlers(m_fg);
			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_RPT_NGHIEP_VU_LAP_PHIEU_THU.NGUOI_THU, e_col_Number.NGUOI_THU);
			v_htb.Add(V_RPT_NGHIEP_VU_LAP_PHIEU_THU.HO_TEN_HOC_SINH, e_col_Number.HO_TEN_HOC_SINH);
			v_htb.Add(V_RPT_NGHIEP_VU_LAP_PHIEU_THU.SO_PHIEU, e_col_Number.SO_PHIEU);
			v_htb.Add(V_RPT_NGHIEP_VU_LAP_PHIEU_THU.NGAY_THU, e_col_Number.NGAY_THU);
			v_htb.Add(V_RPT_NGHIEP_VU_LAP_PHIEU_THU.NGUOI_NHAP, e_col_Number.NGUOI_NHAP);
			v_htb.Add(V_RPT_NGHIEP_VU_LAP_PHIEU_THU.SO_TIEN, e_col_Number.SO_TIEN);
			v_htb.Add(V_RPT_NGHIEP_VU_LAP_PHIEU_THU.NOI_DUNG, e_col_Number.NOI_DUNG);
			v_htb.Add(V_RPT_NGHIEP_VU_LAP_PHIEU_THU.TEN_NGUOI_NOP_TIEN, e_col_Number.TEN_NGUOI_NOP_TIEN);
			v_htb.Add(V_RPT_NGHIEP_VU_LAP_PHIEU_THU.NGAY_NHAP, e_col_Number.NGAY_NHAP);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_RPT_NGHIEP_VU_LAP_PHIEU_THU.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_V_RPT_NGHIEP_VU_LAP_PHIEU_THU();			
			m_us.FillDataset(m_ds);
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
			m_fg.Redraw = true;
		}
		private void grid2us_object(US_V_RPT_NGHIEP_VU_LAP_PHIEU_THU i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_RPT_NGHIEP_VU_LAP_PHIEU_THU i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_v_rpt_nghiep_vu_lap_phieu_thu(){			
		//	f340_lap_phieu_thu_DE v_fDE = new  f340_lap_phieu_thu_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_v_rpt_nghiep_vu_lap_phieu_thu(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;			
			grid2us_object(m_us, m_fg.Row);
		//	f340_lap_phieu_thu_DE v_fDE = new f340_lap_phieu_thu_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void delete_v_rpt_nghiep_vu_lap_phieu_thu(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_RPT_NGHIEP_VU_LAP_PHIEU_THU v_us = new US_V_RPT_NGHIEP_VU_LAP_PHIEU_THU();
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

		private void view_v_rpt_nghiep_vu_lap_phieu_thu(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
		//	f340_lap_phieu_thu_DE v_fDE = new f340_lap_phieu_thu_DE();			
		//	v_fDE.display(m_us);
		}
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
			m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
		}
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f340_lap_phieu_thu_Load(object sender, System.EventArgs e) {
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
				insert_v_rpt_nghiep_vu_lap_phieu_thu();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_v_rpt_nghiep_vu_lap_phieu_thu();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_v_rpt_nghiep_vu_lap_phieu_thu();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
				view_v_rpt_nghiep_vu_lap_phieu_thu();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

	}
}

