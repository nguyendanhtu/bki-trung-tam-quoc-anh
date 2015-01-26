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
    public partial class f320_diem_danh : Form
    {
        public f320_diem_danh()
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

        #endregion
        private void set_define_events()
        {

        }
    }
}
