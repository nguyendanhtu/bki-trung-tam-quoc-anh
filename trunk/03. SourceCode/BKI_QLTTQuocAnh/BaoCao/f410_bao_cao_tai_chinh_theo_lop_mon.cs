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
    public partial class f410_bao_cao_tai_chinh_theo_lop_mon : Form
    {
        public f410_bao_cao_tai_chinh_theo_lop_mon()
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
            TIEN_PHAI_THU = 3
,
            MA_LOP_MON = 1
                ,
            MO_TA = 2
                ,
            TIEN_GIAM_TRU = 4
                ,
            TIEN_THUC_THU = 5
                ,
            DON_GIA_BUOI_HOC = 7
                , TIEN_CON_PHAI_THU = 6

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_RPT_410_BAO_CAO_TAI_CHINH_THEO_LOP_MON m_ds = new DS_V_RPT_410_BAO_CAO_TAI_CHINH_THEO_LOP_MON();
        US_V_RPT_410_BAO_CAO_TAI_CHINH_THEO_LOP_MON m_us = new US_V_RPT_410_BAO_CAO_TAI_CHINH_THEO_LOP_MON();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);

            m_fg.Cols[(int)e_col_Number.MA_LOP_MON].Visible = false;
            m_fg.Tree.Column = (int)e_col_Number.MO_TA;
            set_define_events();
            this.KeyPreview = true;
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            m_dat_tu_ngay.Value = DateTime.Now.Date.AddDays(-DateTime.Now.Day + 1);
            m_dat_den_ngay.Value = DateTime.Now.AddMonths(1).Date.AddDays(-DateTime.Now.Date.Day);
            load_data_2_cbo_lop_mon();
            load_data_2_grid();
        }
        private void wrap_text_cell()
        {
            m_fg.Styles[CellStyleEnum.Normal].WordWrap = true;
            m_fg.AllowResizing = AllowResizingEnum.Both;
            m_fg.AutoSizeRows();
        }
        private void load_data_2_cbo_lop_mon()
        {
            DS_DM_LOP_MON v_ds = new DS_DM_LOP_MON();
            US_DM_LOP_MON v_us = new US_DM_LOP_MON();
            v_us.FillDataset(v_ds, "where TRANG_THAI_LOP_MON = 88");

            DataRow v_dr = v_ds.DM_LOP_MON.NewRow();
            v_dr[DM_LOP_MON.ID] = -1;
            v_dr[DM_LOP_MON.MA_LOP_MON] = "--Tất cả--";
            v_dr[DM_LOP_MON.MO_TA] = "--Tất cả--";
            v_dr[DM_LOP_MON.DON_GIA_BUOI_HOC] = 0;
            v_dr[DM_LOP_MON.TRANG_THAI_LOP_MON] = "-1";

            v_ds.DM_LOP_MON.Rows.InsertAt(v_dr, 0);

            m_cbo_lop.DataSource = v_ds.DM_LOP_MON;
            m_cbo_lop.DisplayMember = DM_LOP_MON.MO_TA;
            m_cbo_lop.ValueMember = DM_LOP_MON.ID;

            m_cbo_lop.SelectedIndex = 0;
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_RPT_410_BAO_CAO_TAI_CHINH_THEO_LOP_MON.TIEN_PHAI_THU, e_col_Number.TIEN_PHAI_THU);
            v_htb.Add(V_RPT_410_BAO_CAO_TAI_CHINH_THEO_LOP_MON.MA_LOP_MON, e_col_Number.MA_LOP_MON);
            v_htb.Add(V_RPT_410_BAO_CAO_TAI_CHINH_THEO_LOP_MON.MO_TA, e_col_Number.MO_TA);
            v_htb.Add(V_RPT_410_BAO_CAO_TAI_CHINH_THEO_LOP_MON.TIEN_GIAM_TRU, e_col_Number.TIEN_GIAM_TRU);
            v_htb.Add(V_RPT_410_BAO_CAO_TAI_CHINH_THEO_LOP_MON.TIEN_THUC_THU, e_col_Number.TIEN_THUC_THU);
            v_htb.Add(V_RPT_410_BAO_CAO_TAI_CHINH_THEO_LOP_MON.DON_GIA_BUOI_HOC, e_col_Number.DON_GIA_BUOI_HOC);
            v_htb.Add(V_RPT_410_BAO_CAO_TAI_CHINH_THEO_LOP_MON.TIEN_CON_PHAI_THU, e_col_Number.TIEN_CON_PHAI_THU);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_RPT_410_BAO_CAO_TAI_CHINH_THEO_LOP_MON.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_RPT_410_BAO_CAO_TAI_CHINH_THEO_LOP_MON();
            m_ds.Clear();
            m_ds.EnforceConstraints = false;
            m_us.FillDataset(m_ds
                            , m_dat_tu_ngay.Value.Date
                            , m_dat_den_ngay.Value.Date
                            , CIPConvert.ToDecimal(m_cbo_lop.SelectedValue)
                            , "");
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            wrap_text_cell();
            

            m_fg.Subtotal(AggregateEnum.Sum
                , 0
                , -1
                , (int)e_col_Number.TIEN_PHAI_THU
                , "Tổng");
            m_fg.Subtotal(AggregateEnum.Sum
                , 0
                , -1
                , (int)e_col_Number.TIEN_THUC_THU
                , "Tổng");
            m_fg.Subtotal(AggregateEnum.Sum
                , 0
                , -1
                , (int)e_col_Number.TIEN_GIAM_TRU
                , "Tổng");
            m_fg.Subtotal(AggregateEnum.Sum
                , 0
                , -1
                , (int)e_col_Number.TIEN_CON_PHAI_THU
                , "Tổng");

            CGridUtils.MakeSoTTofRowNotIsNode(0,m_fg, false);
            m_fg.Redraw = true;
        }
        private void grid2us_object(US_V_RPT_410_BAO_CAO_TAI_CHINH_THEO_LOP_MON i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_RPT_410_BAO_CAO_TAI_CHINH_THEO_LOP_MON i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_rpt_410_bao_cao_tai_chinh_theo_lop_mon()
        {
            //	frm_410_DE v_fDE = new  frm_410_DE();								
            //	v_fDE.display();
            load_data_2_grid();
        }

        private void update_v_rpt_410_bao_cao_tai_chinh_theo_lop_mon()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	frm_410_DE v_fDE = new frm_410_DE();
            //	v_fDE.display(m_us);
            load_data_2_grid();
        }

        private void delete_v_rpt_410_bao_cao_tai_chinh_theo_lop_mon()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_RPT_410_BAO_CAO_TAI_CHINH_THEO_LOP_MON v_us = new US_V_RPT_410_BAO_CAO_TAI_CHINH_THEO_LOP_MON();
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

        private void view_v_rpt_410_bao_cao_tai_chinh_theo_lop_mon()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	frm_410_DE v_fDE = new frm_410_DE();			
            //	v_fDE.display(m_us);
        }

        private void xuat_excel() {
            var v_start_row = 8;
            var v_start_col = 2;
            var v_obj_excel_rpt = new CExcelReport("f410_bao_cao_tai_chinh_theo_lop_mon.xlsx", v_start_row, v_start_col);
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
            m_cmd_search.Click += m_cmd_search_Click;
            this.Load += f410_bao_cao_tai_chinh_theo_lop_mon_Load;
            this.KeyDown += f410_bao_cao_tai_chinh_theo_lop_mon_KeyDown;
            m_fg.DoubleClick += m_fg_DoubleClick;
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

        void f410_bao_cao_tai_chinh_theo_lop_mon_KeyDown(object sender, KeyEventArgs e)
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
                US_V_RPT_410_BAO_CAO_TAI_CHINH_THEO_LOP_MON v_us = new US_V_RPT_410_BAO_CAO_TAI_CHINH_THEO_LOP_MON();
                if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
                if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
                grid2us_object(v_us, m_fg.Row);

                F420_bao_cao_tien_phai_thu_theo_lop_mon_hoc_sinh v_frm = new F420_bao_cao_tien_phai_thu_theo_lop_mon_hoc_sinh();
                v_frm.display(m_dat_tu_ngay.Value.Date
                                , m_dat_den_ngay.Value.Date
                                , v_us.dcID
                                );
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

        void f410_bao_cao_tai_chinh_theo_lop_mon_Load(object sender, EventArgs e)
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
                insert_v_rpt_410_bao_cao_tai_chinh_theo_lop_mon();
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
                update_v_rpt_410_bao_cao_tai_chinh_theo_lop_mon();
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
                delete_v_rpt_410_bao_cao_tai_chinh_theo_lop_mon();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
