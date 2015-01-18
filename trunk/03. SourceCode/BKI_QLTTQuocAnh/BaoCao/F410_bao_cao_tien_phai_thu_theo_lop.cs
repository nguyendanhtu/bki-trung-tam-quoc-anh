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
    public partial class F410_bao_cao_tien_phai_thu_theo_lop : Form
    {
        public F410_bao_cao_tien_phai_thu_theo_lop()
        {
            InitializeComponent();
        }

        #region Public Properties
        public void display()
        {
            this.ShowDialog();
        }
        #endregion
    }
}
