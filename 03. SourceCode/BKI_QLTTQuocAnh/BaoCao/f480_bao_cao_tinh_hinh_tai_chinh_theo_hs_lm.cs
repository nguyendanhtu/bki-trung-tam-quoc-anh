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
    public partial class f480_bao_cao_tinh_hinh_tai_chinh_theo_hs_lm : Form
    {
        public f480_bao_cao_tinh_hinh_tai_chinh_theo_hs_lm()
        {
            InitializeComponent();
            format_controls();
            m_dat_tu_ngay.Value = DateTime.Now.AddDays(-DateTime.Now.Day + 1);
            m_dat_den_ngay.Value = DateTime.Now.Date;
            set_initial_form_load();
            //load_data_2_cbo_lop_mon();
        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        public void display_chi_tiet_lm_hs(DateTime ip_dat_tu_ngay
                                            , DateTime ip_dat_den_ngay
                                            , decimal ip_dc_id_hoc_sinh
                                            , string ip_str_ten_hoc_sinh)
        {
            m_txt_search.Text = ip_str_ten_hoc_sinh;
            m_dat_tu_ngay.Value = ip_dat_tu_ngay;
            m_dat_den_ngay.Value = ip_dat_den_ngay;

            load_data_2_grid(ip_dc_id_hoc_sinh);
            m_fg.Subtotal(AggregateEnum.Clear
                 , 0
                 , -1
                 , (int)e_col_Number.TONG_PHAI_THU
                 , "Tổng");
            m_fg.Subtotal(AggregateEnum.Clear
             , 1
             , -1
             , (int)e_col_Number.TONG_PHAI_THU
             , "Tổng");
            m_fg.Subtotal(AggregateEnum.Sum
              , 1
              , (int)e_col_Number.HO_TEN
              , (int)e_col_Number.TONG_PHAI_THU
              , "{0}");

            m_fg.Subtotal(AggregateEnum.Sum
                , 1
                , (int)e_col_Number.HO_TEN
                , (int)e_col_Number.TONG_GIAM_TRU
                , "{0}");

            m_fg.Subtotal(AggregateEnum.Sum
                , 1
                , (int)e_col_Number.HO_TEN
                , (int)e_col_Number.TONG_THUC_THU
                , "{0}");

            m_fg.Subtotal(AggregateEnum.Sum
                , 1
                , (int)e_col_Number.HO_TEN
                , (int)e_col_Number.TONG_CON_NO
                , "{0}");
            m_cmd_search.Visible = false;
            this.ShowDialog();
        }
        //public void display(decimal ip_dc_id_hoc_sinh, DateTime ip_dat_tu_ngay, DateTime ip_dat_den_ngay)
        //{
        //    m_id_hoc_sinh = ip_dc_id_hoc_sinh;
        //    m_dat_tu_ngay.Value = ip_dat_tu_ngay;
        //    m_dat_den_ngay.Value = ip_dat_den_ngay;
        //    load_data_2_grid(ip_dc_id_hoc_sinh);
        //    this.ShowDialog();
        //}
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            MA_LOP_MON = 3
,
            HO_TEN_PH = 4
                ,
            TONG_GIAM_TRU = 10
                ,
            MA_DOI_TUONG = 1
                ,
            TONG_THUC_THU = 11
                ,
            SDT_PH = 6
                ,
            TONG_CON_NO = 12
                ,
            TONG_PHAI_THU = 9
                ,
            HO_TEN = 2
                ,
            EMAIL_PH = 8
                ,
            SDT_HS = 5
                , EMAIL_HS = 7

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON m_ds = new DS_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON();
        US_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON m_us = new US_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON();
        #endregion

        #region Private Methods
        private void format_controls()
        {

            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);

            m_fg.Tree.Column = (int)e_col_Number.MA_LOP_MON;
            m_fg.Cols[(int)e_col_Number.MA_DOI_TUONG].Visible = false;
            m_fg.Cols[(int)e_col_Number.HO_TEN].Visible = false;
            m_fg.Tree.Style = TreeStyleFlags.CompleteLeaf;
            
            m_cmd_exit.Visible = false;
            m_cmd_insert.Visible = false;
            m_cmd_update.Visible = false;
            m_cmd_delete.Visible = false;

            set_define_events();
            this.KeyPreview = true;
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid(-1);
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.MA_LOP_MON, e_col_Number.MA_LOP_MON);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.HO_TEN_PH, e_col_Number.HO_TEN_PH);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.TONG_GIAM_TRU, e_col_Number.TONG_GIAM_TRU);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.MA_DOI_TUONG, e_col_Number.MA_DOI_TUONG);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.TONG_THUC_THU, e_col_Number.TONG_THUC_THU);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.SDT_PH, e_col_Number.SDT_PH);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.TONG_CON_NO, e_col_Number.TONG_CON_NO);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.TONG_PHAI_THU, e_col_Number.TONG_PHAI_THU);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.HO_TEN, e_col_Number.HO_TEN);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.EMAIL_PH, e_col_Number.EMAIL_PH);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.SDT_HS, e_col_Number.SDT_HS);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.EMAIL_HS, e_col_Number.EMAIL_HS);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.NewRow());
            return v_obj_trans;
        }
        private void wrap_text_cell()
        {
            m_fg.Styles[CellStyleEnum.Normal].WordWrap = true;
            m_fg.AllowResizing = AllowResizingEnum.Both;
            m_fg.AutoSizeRows();
        }
        private void load_data_2_grid(decimal ip_dc_id_hoc_sinh)
        {
            m_ds = new DS_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON();
            m_ds.Clear();
            m_ds.EnforceConstraints = false;
            m_us.FillDataset(m_ds, m_dat_tu_ngay.Value.Date
                                        , m_dat_den_ngay.Value.Date
                                        , ip_dc_id_hoc_sinh
                                        , m_txt_search.Text.Trim());
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count; v_i_cur_row++)
            {
                m_fg[v_i_cur_row, (int)e_col_Number.HO_TEN]
                    = m_fg[v_i_cur_row, (int)e_col_Number.MA_DOI_TUONG]
                    + "-"
                    + m_fg[v_i_cur_row, (int)e_col_Number.HO_TEN];
            }
            m_fg.Subtotal(AggregateEnum.Sum
                , 0
                , -1
                , (int)e_col_Number.TONG_PHAI_THU
                , "Tổng");

            m_fg.Subtotal(AggregateEnum.Sum
                , 0
                , -1
                , (int)e_col_Number.TONG_GIAM_TRU
                , "Tổng");

            m_fg.Subtotal(AggregateEnum.Sum
                 , 0
                , -1
                , (int)e_col_Number.TONG_THUC_THU
               , "Tổng");

            m_fg.Subtotal(AggregateEnum.Sum
              , 0
                , -1
                , (int)e_col_Number.TONG_CON_NO
               , "Tổng");

            m_fg.Subtotal(AggregateEnum.Sum
              , 1
              , (int)e_col_Number.HO_TEN
              , (int)e_col_Number.TONG_PHAI_THU
              , "{0}");

            m_fg.Subtotal(AggregateEnum.Sum
                , 1
                , (int)e_col_Number.HO_TEN
                , (int)e_col_Number.TONG_GIAM_TRU
                , "{0}");

            m_fg.Subtotal(AggregateEnum.Sum
                , 1
                , (int)e_col_Number.HO_TEN
                , (int)e_col_Number.TONG_THUC_THU
                , "{0}");

            m_fg.Subtotal(AggregateEnum.Sum
                , 1
                , (int)e_col_Number.HO_TEN
                , (int)e_col_Number.TONG_CON_NO
                , "{0}");

            m_fg.Tree.Show(1);

            wrap_text_cell();
            //CGridUtils.MakeSoTTByLevelofRow(0, m_fg, 1, false);
            m_fg.Rows.Frozen = 1;

            //format_grid_to_print();

            m_fg.Redraw = true;
        }

        //private void format_grid_to_print() {
        //    int v_tong_so_row = m_fg.Rows.Count - 1;
        //    for(int v_i_row = m_fg.Rows.Fixed; v_i_row < v_tong_so_row; v_i_row++) {
        //        if(m_fg.Rows[v_i_row].IsNode == true) {
        //            m_fg.Rows.Insert(v_i_row);
        //            v_i_row = v_i_row + 1;
        //            v_tong_so_row++;
        //            //m_fg.Rows.Insert(v_i_row);
        //        }
        //    }
        //}
        private void grid2us_object(US_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_rpt_bao_cao_tinh_hinh_tai_chinh_hoc_sinh_lop_mon()
        {
            //	frm_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON_DE v_fDE = new  frm_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON_DE();								
            //	v_fDE.display();
            load_data_2_grid(-1);
        }

        private void update_v_rpt_bao_cao_tinh_hinh_tai_chinh_hoc_sinh_lop_mon()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	frm_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON_DE v_fDE = new frm_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON_DE();
            //	v_fDE.display(m_us);
            load_data_2_grid(-1);
        }

        private void delete_v_rpt_bao_cao_tinh_hinh_tai_chinh_hoc_sinh_lop_mon()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON v_us = new US_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON();
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

        private void view_v_rpt_bao_cao_tinh_hinh_tai_chinh_hoc_sinh_lop_mon()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	frm_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON_DE v_fDE = new frm_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON_DE();			
            //	v_fDE.display(m_us);
        }

        private void xuat_excel() {
            var v_start_row = 8;
            var v_start_col = 2;
            var v_obj_excel_rpt = new CExcelReport("f480_bao_cao_tai_chinh_hs_theo_lop_mon.xlsx", v_start_row, v_start_col);
            v_obj_excel_rpt.AddFindAndReplaceItem("<tu_ngay>", string.Format("{0}/{1}/{2}", m_dat_tu_ngay.Value.Date.Day, m_dat_tu_ngay.Value.Month, m_dat_tu_ngay.Value.Year));
            v_obj_excel_rpt.AddFindAndReplaceItem("<den_ngay>", string.Format("{0}/{1}/{2}", m_dat_den_ngay.Value.Day, m_dat_den_ngay.Value.Month, m_dat_den_ngay.Value.Year));
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
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            this.Load += f480_bao_cao_tinh_hinh_tai_chinh_theo_hs_lm_Load;
            m_cmd_search.Click += m_cmd_search_Click;
            this.KeyDown += f480_bao_cao_tinh_hinh_tai_chinh_theo_hs_lm_KeyDown;
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

        void f480_bao_cao_tinh_hinh_tai_chinh_theo_hs_lm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    load_data_2_grid(-1);
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
                load_data_2_grid(-1);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f480_bao_cao_tinh_hinh_tai_chinh_theo_hs_lm_Load(object sender, EventArgs e)
        {
            try
            {
                //set_initial_form_load();
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
                insert_v_rpt_bao_cao_tinh_hinh_tai_chinh_hoc_sinh_lop_mon();
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
                update_v_rpt_bao_cao_tinh_hinh_tai_chinh_hoc_sinh_lop_mon();
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
                delete_v_rpt_bao_cao_tinh_hinh_tai_chinh_hoc_sinh_lop_mon();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}
