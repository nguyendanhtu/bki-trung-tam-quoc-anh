using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_QLTTQuocAnh;
//using DevComponents.DotNetBar;
using IP.Core.IPSystemAdmin;
using System.Security.Policy;

using BKI_QLTTQuocAnh.HeThong;
using BKI_QLTTQuocAnh.DanhMuc;
using BKI_QLTTQuocAnh.BaoCao;
namespace Form_menu {
    public partial class f399_MainMenu : DevComponents.DotNetBar.Office2007RibbonForm {
        public f399_MainMenu() {
            InitializeComponent();
            format_controls();
        }
        #region Members
        int trangthaiweb = 1;
        #endregion
        #region Public Interface
        public void display(ref IP.Core.IPCommon.IPConstants.HowUserWantTo_Exit_MainForm v_exitmode) {
            try {
                this.ShowDialog();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }
        #endregion
        #region Private Method

        private void format_controls() {
            //CControlFormat.setFormStyle(this, new CAppContext_201());
            set_define_events();
            this.ShowInTaskbar = true;
        }
        #endregion
        // Event handlers
        private void set_define_events() {
            m_cmd_nhap_kho.Click += m_cmd_nhap_kho_Click;
            m_cmd_xuat_kho.Click += m_cmd_xuat_kho_Click;
            m_cmd_phai_thu_thuc_thu_theo_lop.Click += m_cmd_phai_thu_thuc_thu_theo_lop_Click;
            m_cmd_tien_phai_thu_thuc_thu_theo_lop_hoc_sinh.Click += m_cmd_tien_phai_thu_thuc_thu_theo_lop_hoc_sinh_Click;
        }

        private void m_cmd_tien_phai_thu_thuc_thu_theo_lop_hoc_sinh_Click(object sender, EventArgs e)
        {
            try
            {
                f480_bao_cao_tinh_hinh_tai_chinh_theo_hs_lm v_frm = new f480_bao_cao_tinh_hinh_tai_chinh_theo_hs_lm();
                v_frm.display();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_phai_thu_thuc_thu_theo_lop_Click(object sender, EventArgs e)
        {
            try
            {
                f470_bao_cao_tinh_hinh_tai_chinh_theo_hoc_sinh v_frm = new f470_bao_cao_tinh_hinh_tai_chinh_theo_hoc_sinh();
                v_frm.display();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_danh_sach_lop_mon_Click(object sender, EventArgs e)
        {
            try
            {
                f201_danh_sach_lop_mon v_frm = new f201_danh_sach_lop_mon();
                v_frm.display();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_xuat_kho_Click(object sender, EventArgs e) {
            try {
              
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nhap_kho_Click(object sender, EventArgs e) {
            try {
              
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_mat_hang_Click(object sender, EventArgs e) {
            try {
               
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nhom_hang_Click(object sender, EventArgs e) {
            try {
                
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_doanh_thu_theo_nhan_vien_Click(object sender, EventArgs e) {
            try {
             
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nhan_vien_Click(object sender, EventArgs e) {
            try {
             
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_kho_Click(object sender, EventArgs e) {
            try {
               
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_mat_hang_theo_nhom_Click(object sender, EventArgs e) {
            try {
              
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_loai_chung_tu_Click(object sender, EventArgs e) {
            try {
            
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_khach_hang_Click(object sender, EventArgs e) {
            try {
               
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_don_vi_tinh_Click(object sender, EventArgs e) {
            try {
              
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nha_san_xuat_Click(object sender, EventArgs e) {
            try {
               
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_bao_hanh_seri_Click(object sender, EventArgs e) {
            try {
             
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_xuat_nhap_ton_Click(object sender, EventArgs e) {
            try {
              
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_loi_nhuan_gop_Click(object sender, EventArgs e) {
            try {
              
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_phan_quyen_Click(object sender, EventArgs e) {
            try {
                f999_ht_nguoi_su_dung frm999 = new f999_ht_nguoi_su_dung();
                frm999.display();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);

            }
        }

        private void m_cmd_thoat_Click(object sender, EventArgs e) {
            try {
                this.Close();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tu_dien_Click(object sender, EventArgs e) {
            try {
                f100_TuDien frm100 = new f100_TuDien();
                frm100.display();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_nhap_so_du_dau_Click(object sender, EventArgs e) {
            try {
                
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_sua_chua_Click(object sender, EventArgs e) {
            try
            {
              
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nhom_nguoi_sd_Click(object sender, EventArgs e) {
            try
            {
                f306_HT_USER_GROUP v_frm = new f306_HT_USER_GROUP();
                v_frm.display();
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_phan_quyen_cho_nhom_Click(object sender, EventArgs e) {
            try
            {
                f995_ht_phan_quyen_cho_nhom v_frm = new f995_ht_phan_quyen_cho_nhom();
                v_frm.display();
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_phan_quyen_he_thong_Click(object sender, EventArgs e) {
            try
            {
                f993_phan_quyen_he_thong v_frm = new f993_phan_quyen_he_thong();
                v_frm.display();
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_phan_quyen_chi_tiet_Click(object sender, EventArgs e) {
            try
            {
                f994_phan_quyen_detail v_frm = new f994_phan_quyen_detail();
                v_frm.display();
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        

    }
}
