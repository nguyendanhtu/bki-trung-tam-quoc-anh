using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using IP.Core.IPCommon;

using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.DS.CDBNames;

using C1.Win.C1FlexGrid;
namespace BKI_QLTTQuocAnh.NghiepVu
{
    public partial class f315_nhap_hoc : Form
    {
        public f315_nhap_hoc()
        {
            InitializeComponent();
            format_controls();
        }

        #region public interface
        #endregion

        #region Datastruct
        #endregion

        #region Members
        #endregion

        #region Private Methods
        private void format_controls()
        {
            m_cmd_insert.Visible = false;
            m_cmd_update.Visible = false;
            m_cmd_delete.Visible = false;

            set_define_events();
            this.KeyPreview = true;
        }
        private void set_initial_form_load()
        {
            load_data_cbo_2_lop_mon();
        }
        private void save_data()
        {

        }
        private bool check_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ma_hoc_sinh, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }
          
            return true;
        }
        private void load_data_cbo_2_lop_mon()
        {
            DS_DM_LOP_MON v_ds= new DS_DM_LOP_MON();
            US_DM_LOP_MON v_us = new US_DM_LOP_MON();
            v_us.FillDataset(v_ds);

            m_cbo_nhap_vao_lop.DataSource = v_ds.DM_LOP_MON;
            m_cbo_nhap_vao_lop.DisplayMember = DM_LOP_MON.MA_LOP_MON;
            m_cbo_nhap_vao_lop.ValueMember = DM_LOP_MON.ID;

            m_cbo_nhap_vao_lop.SelectedIndex = 1;
        }

        #endregion
        private void set_define_events()
        {
            this.Load += f315_nhap_hoc_Load;
            m_cmd_nhap_hoc.Click += m_cmd_nhap_hoc_Click;
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

    }
}
