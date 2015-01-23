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
            format_controls();
        }
        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        public void display(DateTime ip_dat_dau_thang, DateTime ip_dat_cuoi_thang, decimal ip_dc_id_lop_mon)
        {
            m_dat_tu_ngay.Value = ip_dat_dau_thang.Date;
            m_dat_den_ngay.Value = ip_dat_cuoi_thang.Date;
            m_cbo_lop.SelectedValue = ip_dc_id_lop_mon;

            m_flag_trang_thai_click = 1; // trạng thái click từ from 410

            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            MA_DOI_TUONG = 2
,
            MO_TA = 10
                ,
            TIEN_THUC_THU = 6
                ,
            MA_LOP_MON = 1
                ,
            TEN = 9
                ,
            HO_TEN = 3
                ,
            TIEN_CON_PHAI_THU = 7
                ,
            TIEN_GIAM_TRU = 5
                ,
            TIEN_PHAI_THU = 4
                ,
            HO = 8
                , DON_GIA_BUOI_HOC = 11

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS m_ds = new DS_V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS();
        US_V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS m_us = new US_V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS();
        int m_flag_trang_thai_click = 0;// = 0 nếu click từ nút trên menu, = 1 nếu click từ form 410
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            set_define_events();
            this.KeyPreview = true;
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            if (m_flag_trang_thai_click == 1)
            {
                
            }
            load_data_2_cbo_lop_mon();
            load_data_2_grid();
        }

        private void load_data_2_cbo_lop_mon()
        {
            DS_DM_LOP_MON v_ds = new DS_DM_LOP_MON();
            US_DM_LOP_MON v_us = new US_DM_LOP_MON();
            v_us.FillDataset(v_ds);

            DataRow v_dr = v_ds.DM_LOP_MON.NewRow();
            v_dr[DM_LOP_MON.ID] = -1;
            v_dr[DM_LOP_MON.MA_LOP_MON] = "--Tất cả--";

            v_ds.DM_LOP_MON.Rows.InsertAt(v_dr, 0);

            m_cbo_lop.DataSource = v_ds.DM_LOP_MON;
            m_cbo_lop.DisplayMember = DM_LOP_MON.MA_LOP_MON;
            m_cbo_lop.ValueMember = DM_LOP_MON.ID;

            m_cbo_lop.SelectedIndex = 0;
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS.MA_DOI_TUONG, e_col_Number.MA_DOI_TUONG);
            v_htb.Add(V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS.MO_TA, e_col_Number.MO_TA);
            v_htb.Add(V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS.TIEN_THUC_THU, e_col_Number.TIEN_THUC_THU);
            v_htb.Add(V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS.MA_LOP_MON, e_col_Number.MA_LOP_MON);
            v_htb.Add(V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS.TEN, e_col_Number.TEN);
            v_htb.Add(V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS.HO_TEN, e_col_Number.HO_TEN);
            v_htb.Add(V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS.TIEN_CON_PHAI_THU, e_col_Number.TIEN_CON_PHAI_THU);
            v_htb.Add(V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS.TIEN_GIAM_TRU, e_col_Number.TIEN_GIAM_TRU);
            v_htb.Add(V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS.TIEN_PHAI_THU, e_col_Number.TIEN_PHAI_THU);
            v_htb.Add(V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS.HO, e_col_Number.HO);
            v_htb.Add(V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS.DON_GIA_BUOI_HOC, e_col_Number.DON_GIA_BUOI_HOC);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS();
            m_us.FillDataset(m_ds
                             ,m_dat_tu_ngay.Value.Date
                             ,m_dat_den_ngay.Value.Date
                             ,m_txt_tim_kiem.Text.Trim()
                             ,CIPConvert.ToDecimal(m_cbo_lop.SelectedValue)
                             , -1);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }
        private void grid2us_object(US_V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_rpt_420_bc_tai_chinh_theo_lop_mon_hs()
        {
            //	frm_V_RPT_420_DE v_fDE = new  frm_V_RPT_420_DE();								
            //	v_fDE.display();
            load_data_2_grid();
        }

        private void update_v_rpt_420_bc_tai_chinh_theo_lop_mon_hs()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	frm_V_RPT_420_DE v_fDE = new frm_V_RPT_420_DE();
            //	v_fDE.display(m_us);
            load_data_2_grid();
        }

        private void delete_v_rpt_420_bc_tai_chinh_theo_lop_mon_hs()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS v_us = new US_V_RPT_420_BC_TAI_CHINH_THEO_LOP_MON_HS();
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

        private void view_v_rpt_420_bc_tai_chinh_theo_lop_mon_hs()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	frm_V_RPT_420_DE v_fDE = new frm_V_RPT_420_DE();			
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
            this.Load += F420_bao_cao_tien_phai_thu_theo_lop_mon_hoc_sinh_Load;
            m_cmd_search.Click += m_cmd_search_Click;
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

        void F420_bao_cao_tien_phai_thu_theo_lop_mon_hoc_sinh_Load(object sender, EventArgs e)
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
                insert_v_rpt_420_bc_tai_chinh_theo_lop_mon_hs();
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
                update_v_rpt_420_bc_tai_chinh_theo_lop_mon_hs();
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
                delete_v_rpt_420_bc_tai_chinh_theo_lop_mon_hs();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

       
    }
}
