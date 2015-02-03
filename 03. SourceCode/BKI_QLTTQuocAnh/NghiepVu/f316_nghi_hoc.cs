using BKI_QLTTQuocAnh.DS;
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

        #endregion
        private void set_define_events()
        {

        }
    }
}
