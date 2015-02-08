using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_QLTTQuocAnh.BaoCao
{
    public partial class f_diem_danh : Form
    {
        public f_diem_danh()
        {
            InitializeComponent();
            control_format();
        }
        #region Public Interface

        #endregion

        #region DataStructure

        #endregion
        #region Members

        #endregion
        #region Private Methods
        private void control_format()
        {
            set_define_events();
        }

        private void set_initial_form_load()
        {
        }
        #endregion
        private void set_define_events()
        {
            this.Load += f_diem_danh_Load;
            this.KeyPress += f_diem_danh_KeyPress;
        }

        void f_diem_danh_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Escape)
                {
                    this.Close();
                }
                else if (e.KeyChar == (char)Keys.Enter)
                {

                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            } 
        }

        void f_diem_danh_Load(object sender, EventArgs e)
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
