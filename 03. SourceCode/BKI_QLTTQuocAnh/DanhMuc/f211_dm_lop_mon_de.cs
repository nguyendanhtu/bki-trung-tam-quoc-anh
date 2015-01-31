using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using C1.Win.C1FlexGrid;


namespace BKI_QLTTQuocAnh.DanhMuc
{
    public partial class f211_dm_lop_mon_de : Form
    {
        public f211_dm_lop_mon_de()
        {
            InitializeComponent();
            format_control();
        }
        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion
        #region Private methods
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            //CControlFormat.setC1FlexFormat(m_fg);
            //CGridUtils.AddSave_Excel_Handlers(m_fg);
            //CGridUtils.AddSearch_Handlers(m_fg);

            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            set_define_events();
        }
        #endregion
        private void set_define_events()
        {

        }



    }
}
