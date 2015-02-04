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
    public partial class f320_diem_danh : Form
    {
        public f320_diem_danh()
        {
            InitializeComponent();
            format_controls();
        }

        #region public interface
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            
            MA_DOI_TUONG = 1
                ,
            HO_TEN = 4
                ,
            TEN = 3
                ,
            HO = 2
                ,
            ID_HOC_SINH = 7

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_DM_HOC_SINH m_ds = new DS_V_DM_HOC_SINH();
        US_V_DM_HOC_SINH m_us = new US_V_DM_HOC_SINH();
        DS_GD_DIEM_DANH m_ds_diem_danh = new DS_GD_DIEM_DANH();
        US_GD_DIEM_DANH m_us_diem_danh = new US_GD_DIEM_DANH(); 
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
            m_fg.AllowEditing = true;
            this.KeyPreview = true;

        }
        private void load_data_2_cbo_lop_mon()
        {
            DS_DM_LOP_MON v_ds = new DS_DM_LOP_MON();
            US_DM_LOP_MON v_us = new US_DM_LOP_MON();
            v_us.FillDataset(v_ds);

            //DataRow v_dr = v_ds.DM_LOP_MON.NewRow();
            //v_dr[DM_LOP_MON.ID] = -1;
            //v_dr[DM_LOP_MON.MA_LOP_MON] = "--Tất cả--";

            //v_ds.DM_LOP_MON.Rows.InsertAt(v_dr, 0);
            m_cbo_lop_mon.DataSource = v_ds.DM_LOP_MON;
            m_cbo_lop_mon.DisplayMember = DM_LOP_MON.MO_TA;
            m_cbo_lop_mon.ValueMember = DM_LOP_MON.ID;
        }
        private void load_data_2_cbo_nguoi_su_dung()
        {
            DS_V_HT_NGUOI_SU_DUNG v_ds = new DS_V_HT_NGUOI_SU_DUNG();
            US_V_HT_NGUOI_SU_DUNG v_us = new US_V_HT_NGUOI_SU_DUNG();
            v_us.FillDataset(v_ds);

            //DataRow v_dr = v_ds.DM_LOP_MON.NewRow();
            //v_dr[DM_LOP_MON.ID] = -1;
            //v_dr[DM_LOP_MON.MA_LOP_MON] = "--Tất cả--";

            //v_ds.DM_LOP_MON.Rows.InsertAt(v_dr, 0);

            m_cbo_nguoi_diem_danh.DataSource = v_ds.V_HT_NGUOI_SU_DUNG;
            m_cbo_nguoi_diem_danh.DisplayMember = V_HT_NGUOI_SU_DUNG.TEN;
            m_cbo_nguoi_diem_danh.ValueMember = V_HT_NGUOI_SU_DUNG.ID;
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_cbo_lop_mon();
            load_data_2_cbo_nguoi_su_dung();
            WinFormControls.load_data_to_cbo_tu_dien(WinFormControls.eLOAI_TU_DIEN.DM_CA_HOC, WinFormControls.eTAT_CA.NO, m_cbo_ca_hoc);
            load_data_2_grid();
        }

        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_HOC_SINH.MA_DOI_TUONG, e_col_Number.MA_DOI_TUONG);
            v_htb.Add(V_DM_HOC_SINH.TEN, e_col_Number.TEN);
            v_htb.Add(V_DM_HOC_SINH.HO, e_col_Number.HO);
            v_htb.Add(V_DM_HOC_SINH.HO_TEN, e_col_Number.HO_TEN);
            v_htb.Add(V_DM_HOC_SINH.ID, e_col_Number.ID_HOC_SINH);
            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_DM_HOC_SINH.NewRow());
            return v_obj_trans;
        }
        private void grid2us_object(US_V_DM_HOC_SINH i_us
    , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_DM_HOC_SINH i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }

        private void form_2_us_object()
        {
            /*m_us_dm_lop_mon.strMA_LOP_MON = m_txt_ma_lop_mon.Text;
            m_us_dm_lop_mon.strMO_TA = m_txt_mo_ta.Text;
            m_us_dm_lop_mon.dcDON_GIA_BUOI_HOC = CIPConvert.ToDecimal(m_txt_don_gia.Text);*/
        }
        private void insert_v_dm_hoc_sinh()
        {
            DS_GD_DIEM_DANH v_ds_diem_danh = new DS_GD_DIEM_DANH();
            US_GD_DIEM_DANH v_us_diem_danh = new US_GD_DIEM_DANH();
            for (int i = m_fg.Rows.Fixed; i < m_fg.Rows.Count; i++)
            {
                if (m_fg.GetCellCheck(i, 5) == CheckEnum.Checked)
                {
                    v_us_diem_danh.dcID_HOC_SINH = CIPConvert.ToDecimal(m_fg.Rows[i][(int)e_col_Number.ID_HOC_SINH]);
                    v_us_diem_danh.dcID_LOP_MON = CIPConvert.ToDecimal(m_cbo_lop_mon.SelectedValue);
                    v_us_diem_danh.dcID_NGUOI_NHAP = CIPConvert.ToDecimal(m_cbo_nguoi_diem_danh.SelectedValue);
                    v_us_diem_danh.dcID_NGUOI_DIEM_DANH = CIPConvert.ToDecimal(m_cbo_nguoi_diem_danh.SelectedValue);
                    v_us_diem_danh.datNGAY_HOC = m_dat_tu_ngay.Value.Date;
                    v_us_diem_danh.dcID_CA_HOC = CIPConvert.ToDecimal(m_cbo_ca_hoc.SelectedValue);
                    v_us_diem_danh.Insert();
                }
            }
            BaseMessages.MsgBox_Infor("Bạn đã điểm danh thành công!!!");
        }

        private void load_data_2_grid()
        {
            DS_V_DM_HOC_SINH m_ds = new DS_V_DM_HOC_SINH();
            m_ds.EnforceConstraints = false;
                m_us.FillDataset_danh_sach_hoc_sinh_theo_lop_mon(m_ds,CIPConvert.ToDecimal(m_cbo_lop_mon.SelectedValue));
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }
        #endregion
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
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
        private void f230_danh_muc_hs_theo_lop_Load(object sender, System.EventArgs e)
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
                insert_v_dm_hoc_sinh();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


        private void m_cbo_lop_mon_SelectedIndexChanged(object sender, EventArgs e)
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
