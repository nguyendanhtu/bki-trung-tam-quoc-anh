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
    public partial class f460_bc_tinh_hinh_bo_hoc : Form
    {
        public f460_bc_tinh_hinh_bo_hoc()
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
            HO_TEN = 3
,
            MO_TA = 1
                , MA_HOC_SINH = 2

        }
        #endregion
        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_RPT_F460_TINH_HINH_BO_LOP m_ds = new DS_V_RPT_F460_TINH_HINH_BO_LOP();
        US_V_RPT_F460_TINH_HINH_BO_LOP m_us = new US_V_RPT_F460_TINH_HINH_BO_LOP();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            m_fg.Tree.Column = (int)e_col_Number.MA_HOC_SINH;
            m_fg.Cols[(int)e_col_Number.MO_TA].Visible = false;

            set_define_events();
            this.KeyPreview = true;
        }
        private void set_initial_form_load()
        {
            m_dat_tu_ngay.Value = DateTime.Now.Date.AddDays(-DateTime.Now.Date.Day + 1);
            m_dat_den_ngay.Value = DateTime.Now.Date.AddMonths(1).Date.AddDays(-DateTime.Now.Date.Day);
            m_obj_trans = get_trans_object(m_fg);

            decimal v_dc_tong_so_hs_dang_hoc = 0;
            US_V_RPT_F460_TINH_HINH_BO_LOP v_us = new US_V_RPT_F460_TINH_HINH_BO_LOP();
            v_us.load_tong_so_hs_dang_hoc(m_dat_tu_ngay.Value.Date, m_dat_den_ngay.Value.Date, ref v_dc_tong_so_hs_dang_hoc);
            m_txt_sl_dang_hoc.Text = v_dc_tong_so_hs_dang_hoc.ToString();
            load_data_2_grid();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_RPT_F460_TINH_HINH_BO_LOP.HO_TEN, e_col_Number.HO_TEN);
            v_htb.Add(V_RPT_F460_TINH_HINH_BO_LOP.MO_TA, e_col_Number.MO_TA);
            v_htb.Add(V_RPT_F460_TINH_HINH_BO_LOP.MA_HOC_SINH, e_col_Number.MA_HOC_SINH);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_RPT_F460_TINH_HINH_BO_LOP.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_RPT_F460_TINH_HINH_BO_LOP();
            m_ds.Clear();
            m_ds.EnforceConstraints = false;
            m_us.FillDatasetByProc(m_ds, m_dat_tu_ngay.Value.Date, m_dat_den_ngay.Value.Date);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);

            m_fg.Subtotal(AggregateEnum.Count
                , 1
                , (int)e_col_Number.MO_TA
                , (int)e_col_Number.HO_TEN
                , "{0}");
            m_fg.Subtotal(AggregateEnum.Count
               , 0
               , -1
               , (int)e_col_Number.HO_TEN
               , "Tổng số");

            m_fg.Rows.Frozen = 1;
            m_fg.Redraw = true;
        }
        private void grid2us_object(US_V_RPT_F460_TINH_HINH_BO_LOP i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_RPT_F460_TINH_HINH_BO_LOP i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_rpt_f460_tinh_hinh_bo_lop()
        {
            //	fr_test_DE v_fDE = new  fr_test_DE();								
            //	v_fDE.display();
            load_data_2_grid();
        }

        private void update_v_rpt_f460_tinh_hinh_bo_lop()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	fr_test_DE v_fDE = new fr_test_DE();
            //	v_fDE.display(m_us);
            load_data_2_grid();
        }

        private void delete_v_rpt_f460_tinh_hinh_bo_lop()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_RPT_F460_TINH_HINH_BO_LOP v_us = new US_V_RPT_F460_TINH_HINH_BO_LOP();
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

        private void view_v_rpt_f460_tinh_hinh_bo_lop()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	fr_test_DE v_fDE = new fr_test_DE();			
            //	v_fDE.display(m_us);
        }

        private void xuat_excel() {
            var v_start_row = 8;
            var v_start_col = 2;
            var v_obj_excel_rpt = new CExcelReport("f460_tinh_hinh_thoi_hoc.xlsx", v_start_row, v_start_col);
            v_obj_excel_rpt.AddFindAndReplaceItem("<tu_ngay>", string.Format("{0}/{1}/{2}", m_dat_tu_ngay.Value.Date.Day, m_dat_tu_ngay.Value.Month, m_dat_tu_ngay.Value.Year));
            v_obj_excel_rpt.AddFindAndReplaceItem("<den_ngay>", string.Format("{0}/{1}/{2}", m_dat_den_ngay.Value.Day, m_dat_den_ngay.Value.Month, m_dat_den_ngay.Value.Year));
            v_obj_excel_rpt.AddFindAndReplaceItem("<tong_so>", m_txt_sl_dang_hoc.Text);
            v_obj_excel_rpt.FindAndReplace(false);
            v_obj_excel_rpt.Export2ExcelWithoutFixedRows(m_fg, 0, m_fg.Cols.Count - 1, false);
        }

        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //
        private void set_define_events()
        {
            this.Load += f460_bc_tinh_hinh_bo_hoc_Load;
            m_cmd_search.Click += m_cmd_search_Click;
            this.KeyDown += f460_bc_tinh_hinh_bo_hoc_KeyDown;
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

        void f460_bc_tinh_hinh_bo_hoc_KeyDown(object sender, KeyEventArgs e)
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

        void f460_bc_tinh_hinh_bo_hoc_Load(object sender, EventArgs e)
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
                insert_v_rpt_f460_tinh_hinh_bo_lop();
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
                update_v_rpt_f460_tinh_hinh_bo_lop();
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
                delete_v_rpt_f460_tinh_hinh_bo_lop();
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
                view_v_rpt_f460_tinh_hinh_bo_lop();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
