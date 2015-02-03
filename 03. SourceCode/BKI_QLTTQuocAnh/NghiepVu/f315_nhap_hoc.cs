﻿///************************************************
/// Generated by: vinhnt
/// Date: 29/01/2015 08:34:56
/// Goal: Create Form for V_GD_HOC
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
using BKI_QLTTQuocAnh.DanhMuc;
namespace BKI_QLTTQuocAnh.NghiepVu
{
    public partial class f315_nhap_hoc : Form
    {
        public f315_nhap_hoc()
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
            HO_TEN = 2
,
            STT = 1
                ,
            MO_TA = 3
                , TRANG_THAI = 4

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DataEntryFormMode m_e_form_mode;
        DS_DM_HOC_SINH m_ds_dm_hoc_sinh = new DS_DM_HOC_SINH();
        US_DM_HOC_SINH m_us_dm_hoc_sinh = new US_DM_HOC_SINH();
        DS_GD_HOC m_ds_gd_hoc = new DS_GD_HOC();
        US_GD_HOC m_us_gd_hoc = new US_GD_HOC();
        DS_V_GD_HOC m_ds = new DS_V_GD_HOC();
        US_V_GD_HOC m_us = new US_V_GD_HOC();
        US_V_DM_HOC_SINH m_us_v_dm_hoc_sinh = new US_V_DM_HOC_SINH();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            m_fg.Visible = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_cbo_lop_mon();
            //load_data_2_grid();
        }

        private bool check_data_is_ok()
        {
            return true;
        }

        private void form_2_us_object()
        {

        }

        private void save_data()
        {
            if (check_data_is_ok() == false) return;
            form_2_us_object();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_dm_hoc_sinh.Insert();
                    m_us_gd_hoc.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_hoc_sinh.Update();
                    m_us_gd_hoc.Update();
                    break;
            }
            BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhât!");
            load_data_2_grid();
        }

        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_GD_HOC.HO_TEN, e_col_Number.HO_TEN);
            v_htb.Add(V_GD_HOC.STT, e_col_Number.STT);
            v_htb.Add(V_GD_HOC.MO_TA, e_col_Number.MO_TA);
            v_htb.Add(V_GD_HOC.TRANG_THAI, e_col_Number.TRANG_THAI);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_GD_HOC.NewRow());
            return v_obj_trans;
        }

        private void load_data_2_cbo_lop_mon()
        {
            DS_DM_LOP_MON v_ds_dm_lop_mon = new DS_DM_LOP_MON();
            US_DM_LOP_MON v_us_dm_lop_mon = new US_DM_LOP_MON();
            v_us_dm_lop_mon.FillDataset(v_ds_dm_lop_mon);

            //DataRow v_dr = v_ds_dm_lop_mon.DM_LOP_MON.NewRow();
            //v_dr[DM_LOP_MON.ID] = -1;
            //v_dr[DM_LOP_MON.MA_LOP_MON] = "--Tất cả--";
            //v_dr[DM_LOP_MON.DON_GIA_BUOI_HOC] = 0;

            //v_ds_dm_lop_mon.DM_LOP_MON.Rows.InsertAt(v_dr, 0);

            m_cbo_nhap_vao_lop_mon.DataSource = v_ds_dm_lop_mon.DM_LOP_MON;
            m_cbo_nhap_vao_lop_mon.DisplayMember = DM_LOP_MON.MO_TA;
            m_cbo_nhap_vao_lop_mon.ValueMember = DM_LOP_MON.ID;

            //m_cbo_nhap_vao_lop_mon.SelectedIndex = 0;
        }

        private void load_data_2_grid()
        {
            m_ds = new DS_V_GD_HOC();
            m_ds.Clear();
            m_us.FillDataset(m_ds, m_txt_search.Text.Trim());
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }

        private void grid2us_object(US_V_GD_HOC i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }

        private void us_object2grid(US_V_GD_HOC i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }

        private void insert_v_gd_hoc()
        {
            //	f_gd_hoc_DE v_fDE = new  f_gd_hoc_DE();								
            //	v_fDE.display();
            load_data_2_grid();
        }

        private void update_v_gd_hoc()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	f_gd_hoc_DE v_fDE = new f_gd_hoc_DE();
            //	v_fDE.display(m_us);
            load_data_2_grid();
        }

        private void delete_v_gd_hoc()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_GD_HOC v_us = new US_V_GD_HOC();
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

        private void view_v_gd_hoc()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	f_gd_hoc_DE v_fDE = new f_gd_hoc_DE();			
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
            this.Load += f315_nhap_hoc_Load;
            m_cmd_danh_sach.Click += m_cmd_nhap_hoc_Click;
            m_cmd_search_2.Click += m_cmd_search_2_Click;
            m_cmd_chon_hs.Click += m_cmd_chon_hs_Click;
        }

        void m_cmd_search_2_Click(object sender, EventArgs e)
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

        void m_cmd_nhap_hoc_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_chon_hs_Click(object sender, EventArgs e)
        {
            try
            {
                f220_cap_nhat_thong_tin_hoc_sinh v_frm = new f220_cap_nhat_thong_tin_hoc_sinh();
                v_frm.display(ref m_us_v_dm_hoc_sinh);

                m_txt_chon_hs.Text = m_us_v_dm_hoc_sinh.strHO_TEN;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f315_nhap_hoc_Load(object sender, EventArgs e)
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
                insert_v_gd_hoc();
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
                update_v_gd_hoc();
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
                delete_v_gd_hoc();
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
                view_v_gd_hoc();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_hs_moi_Click(object sender, EventArgs e)
        {
            f221_cap_nhat_thong_tin_hoc_sinh_de v_frm = new f221_cap_nhat_thong_tin_hoc_sinh_de();
            v_frm.display_for_insert();
        }

        private void m_cmd_danh_sach_Click(object sender, EventArgs e)
        {            
            try
            {
                //load_data_2_grid();
                f230_danh_muc_hs_theo_lop v_frm = new f230_danh_muc_hs_theo_lop();
                v_frm.display();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}
