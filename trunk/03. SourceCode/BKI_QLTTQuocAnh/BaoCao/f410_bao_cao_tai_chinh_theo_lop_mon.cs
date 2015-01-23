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
            m_us.FillDataset(m_ds);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
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
            this.Load += f410_bao_cao_tai_chinh_theo_lop_mon_Load;
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
