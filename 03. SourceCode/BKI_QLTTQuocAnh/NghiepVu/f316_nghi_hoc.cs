using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.DS.CDBNames;
using BKI_QLTTQuocAnh.US;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_QLTTQuocAnh.NghiepVu
{
    public partial class f316_nghi_hoc : Form
    {
        public f316_nghi_hoc()
        {
            InitializeComponent();
            format_controls();
        }

        #region public interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Datastruct
        #endregion

        #region Members
        DS_GD_HOC m_ds_gd_hoc = new DS_GD_HOC();
        US_GD_HOC m_us_gd_hoc = new US_GD_HOC();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            Design_for_form_316();

            //m_cmd_nghi_hoc.Visible = false;
            //m_cmd_nghi_hoc.Visible = false;
            //m_cmd_nghi_hoc.Visible = false;
            m_cmd_update.Visible = false;
            m_cmd_delete.Visible = false;

            set_define_events();
            this.KeyPreview = true;
        }

        private void Design_for_form_316()
        {
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_tu_ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_lop_mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_chon_hoc_sinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_dat_tu_ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_cbo_lop_mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_cbo_hs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_cmd_nghi_hoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_tong_so.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_tong_so_hoc_sinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
        }

        private void set_initial_form_load()
        {
            load_data_2_cbo_chon_lop_mon();
            m_cbo_lop_mon.SelectedIndexChanged += m_cbo_lop_mon_SelectedIndexChanged;
        }

        
        private void load_data_2_cbo_chon_lop_mon()
        {
            DS_DM_LOP_MON v_ds_dm_lop_mon = new DS_DM_LOP_MON();
            US_DM_LOP_MON v_us_dm_lop_mon = new US_DM_LOP_MON();
            v_us_dm_lop_mon.FillDataset(v_ds_dm_lop_mon, "where TRANG_THAI_LOP_MON = 88");

            DataRow v_dr = v_ds_dm_lop_mon.DM_LOP_MON.NewRow();
            v_dr[DM_LOP_MON.ID] = -1;
            v_dr[DM_LOP_MON.MA_LOP_MON] = "--Tất cả--";
            v_dr[DM_LOP_MON.MO_TA] = "--Tất cả--";
            v_dr[DM_LOP_MON.DON_GIA_BUOI_HOC] = 0;
            v_dr[DM_LOP_MON.TRANG_THAI_LOP_MON] = -1;

            v_ds_dm_lop_mon.DM_LOP_MON.Rows.InsertAt(v_dr, 0);

            m_cbo_lop_mon.DataSource = v_ds_dm_lop_mon.DM_LOP_MON;
            m_cbo_lop_mon.DisplayMember = DM_LOP_MON.MO_TA;
            m_cbo_lop_mon.ValueMember = DM_LOP_MON.ID;

            m_cbo_lop_mon.SelectedIndex = 0;
        }

        private void load_data_2_lbl_tong_so_hoc_sinh(decimal ip_dc_id_lop_mon)
        {
            DS_V_F316_DM_HOC_SINH_LOP_MON v_ds_hoc_sinh_lop_mon = new DS_V_F316_DM_HOC_SINH_LOP_MON();
            US_V_F316_DM_HOC_SINH_LOP_MON v_us_hoc_sinh_lop_mon = new US_V_F316_DM_HOC_SINH_LOP_MON();

            decimal op_dc_tong_so_hoc_sinh = 0;
            v_us_hoc_sinh_lop_mon.FillDataset_2_lbl_tong_so(v_ds_hoc_sinh_lop_mon, ip_dc_id_lop_mon, ref op_dc_tong_so_hoc_sinh);

            m_lbl_tong_so_hoc_sinh.Text = op_dc_tong_so_hoc_sinh.ToString();
        }

        private void load_data_2_cbo_hoc_sinh(decimal ip_dc_id_lop_mon)
        {
            DS_V_F316_DM_HOC_SINH_LOP_MON v_ds_hoc_sinh_lop_mon = new DS_V_F316_DM_HOC_SINH_LOP_MON();
            US_V_F316_DM_HOC_SINH_LOP_MON v_us_hoc_sinh_lop_mon = new US_V_F316_DM_HOC_SINH_LOP_MON();

            v_ds_hoc_sinh_lop_mon.Clear();
            v_ds_hoc_sinh_lop_mon.EnforceConstraints = false;

            v_us_hoc_sinh_lop_mon.FillDataset(v_ds_hoc_sinh_lop_mon
                , ip_dc_id_lop_mon);

            m_cbo_hs.DataSource = v_ds_hoc_sinh_lop_mon.V_F316_DM_HOC_SINH_LOP_MON;
            m_cbo_hs.DisplayMember = V_F316_DM_HOC_SINH_LOP_MON.HO_TEN;
            m_cbo_hs.ValueMember = V_F316_DM_HOC_SINH_LOP_MON.ID;
        }

        private bool check_validate_data()
        {
            if (m_cbo_lop_mon.SelectedIndex == 0)
            {
                BaseMessages.MsgBox_Infor("Bạn chưa chọn LỚP MÔN!");
                return false;
            }
            //if (m_cbo_hs.SelectedIndex == 0)
            //{
            //    BaseMessages.MsgBox_Infor("Bạn chưa chọn HỌC SINH!");
            //    return false;
            //}

            return true;
        }

        private void hoc_sinh_nghi_hoc()
        {
            if (DialogResult.Yes == BaseMessages.MsgBox_YES_NO_CANCEL("Bạn có chắc chắc muốn học sinh này nghỉ học không?"))
            {
                US_GD_HOC v_us = new US_GD_HOC();
                decimal op_dc_id_gd_hoc = 0;
                v_us.Find_ID_GD_HOC(CIPConvert.ToDecimal(m_cbo_lop_mon.SelectedValue), CIPConvert.ToDecimal(m_cbo_hs.SelectedValue), ref op_dc_id_gd_hoc);
                US_GD_HOC v_us_gd_hoc = new US_GD_HOC(op_dc_id_gd_hoc);
                v_us_gd_hoc.strTRANG_THAI_YN = "N";
                v_us_gd_hoc.datNGAY_KET_THUC = m_dat_tu_ngay.Value.Date;
                v_us_gd_hoc.Update();
                BaseMessages.MsgBox_Infor("Xong!!!");
                load_data_2_cbo_hoc_sinh(CIPConvert.ToDecimal(m_cbo_lop_mon.SelectedValue));
                load_data_2_lbl_tong_so_hoc_sinh(CIPConvert.ToDecimal(m_cbo_lop_mon.SelectedValue));
            }
        }

        #endregion
        private void set_define_events()
        {
            this.Load += f316_nghi_hoc_Load;

            m_cmd_nghi_hoc.Click += m_cmd_nghi_hoc_Click;
        }

        void m_cmd_nghi_hoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (!check_validate_data())
                {
                    return;
                }
                hoc_sinh_nghi_hoc();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        void m_cbo_lop_mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                decimal ip_dc_id_lop_mon = CIPConvert.ToDecimal(m_cbo_lop_mon.SelectedValue);
                
                if (m_cbo_lop_mon.SelectedIndex != 0)
                {
                    load_data_2_lbl_tong_so_hoc_sinh(CIPConvert.ToDecimal(m_cbo_lop_mon.SelectedValue));
                }

                load_data_2_cbo_hoc_sinh(ip_dc_id_lop_mon);
                m_cbo_hs.Focus();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        void f316_nghi_hoc_Load(object sender, EventArgs e)
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

    }
}
