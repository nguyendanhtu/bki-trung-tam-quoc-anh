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
    public partial class F420_bao_cao_tien_phai_thu_theo_lop_mon_hoc_sinh : Form
    {
        public F420_bao_cao_tien_phai_thu_theo_lop_mon_hoc_sinh()
        {
            InitializeComponent();
        }

        private void format_controls()
        {
            throw new NotImplementedException();
        }
        #region Public Properties
        public void display()
        {
            this.ShowDialog();
        }
        #endregion
    }

    public class frm_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON : System.Windows.Forms.Form
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

        public frm_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON()
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frm_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON));
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
            this.m_fg.ColumnInfo = @"8,1,0,0,0,85,Columns:0{Width:13;}	 4{Caption:""Phải thu (VNĐ)"";Visible:True;DataType:System.Decimal;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}1{Caption:""Lớp môn"";Visible:True;DataType:System.String;TextAlign:LeftCenter;TextAlignFixed:CenterCenter;}3{Caption:""Họ tên"";Visible:True;DataType:System.String;TextAlign:LeftCenter;TextAlignFixed:CenterCenter;}6{Caption:""Giảm trừ (VNĐ)"";Visible:True;DataType:System.Decimal;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}5{Caption:""Thực thu (VNĐ)"";Visible:True;DataType:System.Decimal;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}7{Caption:""Còn phải thu (VNĐ)"";Visible:True;DataType:System.Decimal;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}2{Caption:""Mã học sinh"";Visible:True;DataType:System.String;TextAlign:LeftCenter;TextAlignFixed:CenterCenter;}	";
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 0);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(686, 373);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Microsoft Sans Serif, 8.25pt;}	Alternate{BackColor:Info;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
            this.m_fg.TabIndex = 20;
            // 
            // frm_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(686, 409);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "frm_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON";
            this.Text = "frm_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON";
            this.Load += new System.EventHandler(this.frm_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            PHAI_THU = 4
,
            MA_LOP_MON = 1
                ,
            HO_TEN = 3
                ,
            GIAM_TRU = 6
                ,
            THUC_THU = 5
                ,
            CON_PHAI_THU = 7
                , MA_DOI_TUONG = 2

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS m_ds = new DS_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS();
        US_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS m_us = new US_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            set_define_events();
            this.KeyPreview = true;
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS.PHAI_THU, e_col_Number.PHAI_THU);
            v_htb.Add(V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS.MA_LOP_MON, e_col_Number.MA_LOP_MON);
            v_htb.Add(V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS.HO_TEN, e_col_Number.HO_TEN);
            v_htb.Add(V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS.GIAM_TRU, e_col_Number.GIAM_TRU);
            v_htb.Add(V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS.THUC_THU, e_col_Number.THUC_THU);
            v_htb.Add(V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS.CON_PHAI_THU, e_col_Number.CON_PHAI_THU);
            v_htb.Add(V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS.MA_DOI_TUONG, e_col_Number.MA_DOI_TUONG);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds.V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS.Clear();
            m_ds = new DS_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS();
            m_us.FillDataset(
                m_ds
                
                );
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }
        private void grid2us_object(US_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_rpt_bao_cao_tien_phai_thu_theo_lop_mon_hs()
        {
            //	frm_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_DE v_fDE = new  frm_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_DE();								
            //	v_fDE.display();
            load_data_2_grid();
        }

        private void update_v_rpt_bao_cao_tien_phai_thu_theo_lop_mon_hs()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	frm_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_DE v_fDE = new frm_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_DE();
            //	v_fDE.display(m_us);
            load_data_2_grid();
        }

        private void delete_v_rpt_bao_cao_tien_phai_thu_theo_lop_mon_hs()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS v_us = new US_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_HS();
            grid2us_object(v_us, m_fg.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_fg.Rows.Remove(m_fg.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_v_rpt_bao_cao_tien_phai_thu_theo_lop_mon_hs()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	frm_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_DE v_fDE = new frm_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_DE();			
            //	v_fDE.display(m_us);
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            this.Load += frm_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_Load;
        }
        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //
        private void frm_V_RPT_BAO_CAO_TIEN_PHAI_THU_THEO_LOP_MON_Load(object sender, System.EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                insert_v_rpt_bao_cao_tien_phai_thu_theo_lop_mon_hs();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                update_v_rpt_bao_cao_tien_phai_thu_theo_lop_mon_hs();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                delete_v_rpt_bao_cao_tien_phai_thu_theo_lop_mon_hs();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_view_Click(object sender, EventArgs e)
        {
            try
            {
                view_v_rpt_bao_cao_tien_phai_thu_theo_lop_mon_hs();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
