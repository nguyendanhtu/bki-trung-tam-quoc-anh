using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using IP.Core.IPCommon;
using BKI_QLTTQuocAnh.BaoCao;
using BKI_QLTTQuocAnh.DanhMuc;
using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.HeThong;
using BKI_QLTTQuocAnh.NghiepVu;

namespace BKI_QLTTQuocAnh
{
    public partial class f388_main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public f388_main()
        {
            InitializeComponent();
            format_control();
        }
        public void display(ref IP.Core.IPCommon.IPConstants.HowUserWantTo_Exit_MainForm v_exitmode)
        {
            try
            {
                this.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        #region Private Methods
        private void format_control()
        {

            set_define_events();
        }
        private bool IsExistForm(Form ip_frm)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == ip_frm.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
        #endregion

        ///
        ///Events
        ///
        ///
        private void set_define_events()
        {
            m_cmd_nhap_hoc.ItemClick += m_cmd_nhap_hoc_ItemClick;
            m_cmd_nghi_hoc.ItemClick += m_cmd_nghi_hoc_ItemClick;
        }

        void m_cmd_nghi_hoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            f316_nghi_hoc v_frm = new f316_nghi_hoc();

            if (IsExistForm(v_frm)) return;

            v_frm.MdiParent = this;
            v_frm.Show();
        }

        void m_cmd_nhap_hoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            f315_nhap_hoc v_frm = new f315_nhap_hoc();

            if (IsExistForm(v_frm)) return;

            v_frm.MdiParent = this;
            v_frm.Show();
        }
    }
}