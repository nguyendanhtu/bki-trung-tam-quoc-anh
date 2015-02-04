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
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            //m_cmd_nghi_hoc.Visible = false;
            m_cmd_update.Visible = false;
            m_cmd_delete.Visible = false;

            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_cbo_chon_lop_mon();
        }

        private void load_data_2_cbo_chon_lop_mon()
        {
            DS_DM_LOP_MON v_ds_dm_lop_mon = new DS_DM_LOP_MON();
            US_DM_LOP_MON v_us_dm_lop_mon = new US_DM_LOP_MON();
            v_us_dm_lop_mon.FillDataset(v_ds_dm_lop_mon);

            DataRow v_dr = v_ds_dm_lop_mon.DM_LOP_MON.NewRow();
            v_dr[DM_LOP_MON.ID] = -1;
            v_dr[DM_LOP_MON.MA_LOP_MON] = "--Tất cả--";
            v_dr[DM_LOP_MON.MO_TA] = "--Tất cả--";
            v_dr[DM_LOP_MON.DON_GIA_BUOI_HOC] = 0;

            v_ds_dm_lop_mon.DM_LOP_MON.Rows.InsertAt(v_dr, 0);

            m_cbo_lop_mon.DataSource = v_ds_dm_lop_mon.DM_LOP_MON;
            m_cbo_lop_mon.DisplayMember = DM_LOP_MON.MO_TA;
            m_cbo_lop_mon.ValueMember = DM_LOP_MON.ID;

            m_cbo_lop_mon.SelectedIndex = 0;
        }

        private void load_data_2_cbo_hoc_sinh()
        {
            DS_V_F316_DM_HOC_SINH_LOP_MON v_ds_hoc_sinh_lop_mon = new DS_V_F316_DM_HOC_SINH_LOP_MON();
            US_V_F316_DM_HOC_SINH_LOP_MON v_us_hoc_sinh_lop_mon = new US_V_F316_DM_HOC_SINH_LOP_MON();

            v_us_hoc_sinh_lop_mon.FillDataset(v_ds_hoc_sinh_lop_mon
                , CIPConvert.ToDecimal(m_cbo_lop_mon.SelectedValue));

            m_cbo_hs.DataSource = v_ds_hoc_sinh_lop_mon.V_F316_DM_HOC_SINH_LOP_MON;
            m_cbo_hs.DisplayMember = V_F316_DM_HOC_SINH_LOP_MON.HO_TEN;
            m_cbo_hs.ValueMember = V_F316_DM_HOC_SINH_LOP_MON.ID;
        }

        private void hoc_sinh_nghi_hoc()
        {
            
        }

        #endregion
        private void set_define_events()
        {
            this.Load += f316_nghi_hoc_Load;
            m_cbo_lop_mon.SelectedIndexChanged += m_cbo_lop_mon_SelectedIndexChanged;
            m_cmd_nghi_hoc.Click += m_cmd_nghi_hoc_Click;
        }

        void m_cmd_nghi_hoc_Click(object sender, EventArgs e)
        {
            hoc_sinh_nghi_hoc();
        }

        void m_cbo_lop_mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data_2_cbo_hoc_sinh();
        }

        void f316_nghi_hoc_Load(object sender, EventArgs e)
        {
            set_initial_form_load();
        }

        
    }
}
