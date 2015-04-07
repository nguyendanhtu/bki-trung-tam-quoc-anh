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
using IP.Core.IPExcelReport;

namespace BKI_QLTTQuocAnh.BaoCao
{
    public partial class f470_bao_cao_tinh_hinh_tai_chinh_theo_hoc_sinh : Form
    {
        public f470_bao_cao_tinh_hinh_tai_chinh_theo_hoc_sinh()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            EMAIL_PH = 7
,
            HO_TEN_PH = 3
                ,
            TONG_GIAM_TRU = 9
                ,
            MA_DOI_TUONG = 1
                ,
            TONG_THUC_THU = 10
                ,
            SDT_PH = 5
                ,
            TONG_CON_NO = 11
                ,
            TONG_PHAI_THU = 8
                ,
            HO_TEN = 2
                ,
            SDT_HS = 4
                , EMAIL_HS = 6

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH m_ds = new DS_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH();
        US_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH m_us = new US_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            m_fg.Tree.Column = (int)e_col_Number.MA_DOI_TUONG;
            m_fg.Tree.Style = TreeStyleFlags.SimpleLeaf;

            //m_cmd_xuat_excel.Visible = false;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            set_define_events();
            this.KeyPreview = true;
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            m_dat_tu_ngay.Value = DateTime.Now.AddDays(-DateTime.Now.Day + 1);
            m_cmd_insert.Visible = false;
            m_cmd_update.Visible = false;
            m_cmd_delete.Visible = false;
            load_data_2_grid();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH.EMAIL_PH, e_col_Number.EMAIL_PH);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH.HO_TEN_PH, e_col_Number.HO_TEN_PH);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH.TONG_GIAM_TRU, e_col_Number.TONG_GIAM_TRU);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH.MA_DOI_TUONG, e_col_Number.MA_DOI_TUONG);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH.TONG_THUC_THU, e_col_Number.TONG_THUC_THU);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH.SDT_PH, e_col_Number.SDT_PH);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH.TONG_CON_NO, e_col_Number.TONG_CON_NO);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH.TONG_PHAI_THU, e_col_Number.TONG_PHAI_THU);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH.HO_TEN, e_col_Number.HO_TEN);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH.SDT_HS, e_col_Number.SDT_HS);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH.EMAIL_HS, e_col_Number.EMAIL_HS);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH.NewRow());
            return v_obj_trans;
        }
        private void wrap_text_cell()
        {
            m_fg.Styles[CellStyleEnum.Normal].WordWrap = true;
            m_fg.AllowResizing = AllowResizingEnum.Rows;
            m_fg.AutoSizeRows();
        }
        private void load_data_2_grid()
        {
            m_ds.Clear();
            m_ds.EnforceConstraints = false;
            m_us.FillDataset(
                m_ds
                , m_dat_tu_ngay.Value.Date
                , m_dat_den_ngay.Value.Date
                , m_txt_search.Text.Trim()
            );
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Subtotal(AggregateEnum.Sum
                , 0
                , -1
                , (int)e_col_Number.TONG_PHAI_THU
                , "Tổng cộng");
            m_fg.Subtotal(AggregateEnum.Sum
                , 0
                , -1
                , (int)e_col_Number.TONG_THUC_THU
                , "Tổng cộng");
            m_fg.Subtotal(AggregateEnum.Sum
                , 0
                , -1
                , (int)e_col_Number.TONG_GIAM_TRU
                , "Tổng cộng");
            m_fg.Subtotal(AggregateEnum.Sum
             , 0
             , -1
             , (int)e_col_Number.TONG_CON_NO
             , "Tổng cộng");

            wrap_text_cell();
            CGridUtils.MakeSoTTofRowNotIsNode(0, m_fg, false);
            m_fg.Rows.Frozen = 1;
            m_fg.Redraw = true;
        }
        private void grid2us_object(US_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_rpt_bao_cao_tinh_hinh_tai_chinh()
        {
            //	frm_DM_HOC_SINH_DE v_fDE = new  frm_DM_HOC_SINH_DE();								
            //	v_fDE.display();
            load_data_2_grid();
        }

        private void update_v_rpt_bao_cao_tinh_hinh_tai_chinh()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	frm_DM_HOC_SINH_DE v_fDE = new frm_DM_HOC_SINH_DE();
            //	v_fDE.display(m_us);
            load_data_2_grid();
        }

        private void delete_v_rpt_bao_cao_tinh_hinh_tai_chinh()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH v_us = new US_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH();
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

        private void view_v_rpt_bao_cao_tinh_hinh_tai_chinh()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	frm_DM_HOC_SINH_DE v_fDE = new frm_DM_HOC_SINH_DE();			
            //	v_fDE.display(m_us);
        }

        private void xuat_excel() {
            var v_start_row = 8;
            var v_start_col = 2;
            var v_obj_excel_rpt = new CExcelReport("f470_bao_cao_tinh_hinh_tai_chinh_theo_hoc_sinh.xlsx", v_start_row, v_start_col);
            v_obj_excel_rpt.AddFindAndReplaceItem("<tu_ngay>", string.Format("{0}/{1}/{2}", m_dat_tu_ngay.Value.Date.Day, m_dat_tu_ngay.Value.Month, m_dat_tu_ngay.Value.Year));
            v_obj_excel_rpt.AddFindAndReplaceItem("<den_ngay>", string.Format("{0}/{1}/{2}", m_dat_den_ngay.Value.Day, m_dat_den_ngay.Value.Month, m_dat_den_ngay.Value.Year));
            v_obj_excel_rpt.FindAndReplace(false);
            v_obj_excel_rpt.Export2ExcelWithoutFixedRows(m_fg, 0, m_fg.Cols.Count - 1, false);
        }
        #endregion
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_cmd_search.Click += m_cmd_search_Click;
            this.Load += f470_bao_cao_tinh_hinh_tai_chinh_theo_hoc_sinh_Load;
            m_fg.DoubleClick += m_fg_DoubleClick;
            this.KeyDown += f470_bao_cao_tinh_hinh_tai_chinh_theo_hoc_sinh_KeyDown;
            m_cmd_xuat_excel.Click += m_cmd_xuat_excel_Click;
        }

        void m_cmd_xuat_excel_Click(object sender, EventArgs e) {
            try {
                xuat_excel();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            } 
        }

        void f470_bao_cao_tinh_hinh_tai_chinh_theo_hoc_sinh_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    load_data_2_grid();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            } 
        }

        void m_fg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                US_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH v_us = new US_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH();
                if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
                if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
                grid2us_object(v_us, m_fg.Row);

                f480_bao_cao_tinh_hinh_tai_chinh_theo_hs_lm v_frm = new f480_bao_cao_tinh_hinh_tai_chinh_theo_hs_lm();
                v_frm.display_chi_tiet_lm_hs(m_dat_tu_ngay.Value.Date
                                            , m_dat_den_ngay.Value.Date
                                            , v_us.dcID
                                            , v_us.strHO_TEN);
                //f430_bao_cao_danh_sach_phai_thu_thuc_thu v_frm = new f430_bao_cao_danh_sach_phai_thu_thuc_thu();
                //v_frm.display_from_f470(v_us, m_dat_tu_ngay.Value.Date, m_dat_den_ngay.Value.Date);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_search_Click(object sender, EventArgs e)
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

        void f470_bao_cao_tinh_hinh_tai_chinh_theo_hoc_sinh_Load(object sender, EventArgs e)
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
                insert_v_rpt_bao_cao_tinh_hinh_tai_chinh();
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
                update_v_rpt_bao_cao_tinh_hinh_tai_chinh();
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
                delete_v_rpt_bao_cao_tinh_hinh_tai_chinh();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


    }
}
