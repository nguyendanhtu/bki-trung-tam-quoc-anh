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
using IP.Core.IPSystemAdmin;
namespace BKI_QLTTQuocAnh
{
    public partial class f388_main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public f388_main()
        {
            InitializeComponent();
            format_control();
            MdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            ribbon.SelectedPage = ribbonPage3;
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
            US_V_HT_NGUOI_SU_DUNG v_us = new US_V_HT_NGUOI_SU_DUNG();
            if (US_V_HT_NGUOI_SU_DUNG.isInAdminGroup(CAppContext_201.getCurrentUserID()))
            {
                ribbonPageGroup4.Visible = false;
                ribbonPageGroup5.Visible = false;
                m_cmd_lap_phai_thu_le.Visibility = BarItemVisibility.Never;
                m_cmd_lap_phai_thu_tu_dong.Visibility = BarItemVisibility.Never;
                m_cmd_lap_thuc_thu.Visibility = BarItemVisibility.Never;
                m_cmd_lap_giam_tru.Visibility = BarItemVisibility.Never;
                //m_cmd_phan_quyen_nhom.Visibility = BarItemVisibility.Never;
                //m_cmd_nhom_nguoi_su_dung.Visibility = BarItemVisibility.Never;
                //m_cmd_nguoi_sd.Visibility = BarItemVisibility.Never;
                ribbonPage2.Visible = false;
                m_cmd_ds_phieu.Visibility = BarItemVisibility.Always ;
            }
            else
            {
                m_cmd_ban_giao_tien.Visibility = BarItemVisibility.Never;
                m_cmd_phan_quyen_nhom.Visibility = BarItemVisibility.Never;
                m_cmd_nhom_nguoi_su_dung.Visibility = BarItemVisibility.Never;
                m_cmd_nguoi_sd.Visibility = BarItemVisibility.Never;
                ribbonPageGroup2.Visible = false;
            }
            set_define_events();
        }
        private bool IsExistFormName(Form ip_frm)
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
        private bool IsExistFormText(Form ip_frm)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Text == ip_frm.Text)
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
            //Nghiệp vụ
            m_cmd_nhap_hoc.ItemClick += m_cmd_nhap_hoc_ItemClick;
            m_cmd_nghi_hoc.ItemClick += m_cmd_nghi_hoc_ItemClick;
            m_cmd_diem_danh.ItemClick += m_cmd_diem_danh_ItemClick;
            m_cmd_cap_nhat_hs.ItemClick += m_cmd_cap_nhat_hs_ItemClick;
            m_cmd_lap_phai_thu_le.ItemClick += m_cmd_lap_phai_thu_le_ItemClick;
            m_cmd_lap_phai_thu_tu_dong.ItemClick += m_cmd_lap_phai_thu_tu_dong_ItemClick;
            m_cmd_lap_thuc_thu.ItemClick += m_cmd_lap_thuc_thu_ItemClick;
            m_cmd_lap_giam_tru.ItemClick += m_cmd_lap_giam_tru_ItemClick;
            m_cmd_ban_giao_tien.ItemClick += m_cmd_ban_giao_tien_ItemClick;
            m_cmd_import_excel.ItemClick += m_cmd_import_excel_ItemClick;
            //Hệ thống
            m_cmd_thoat.ItemClick += m_cmd_thoat_ItemClick;
            m_cmd_phan_quyen_nhom.ItemClick += m_cmd_phan_quyen_nhom_ItemClick;
            m_cmd_nhom_nguoi_su_dung.ItemClick += m_cmd_nhom_nguoi_su_dung_ItemClick;
            m_cmd_doi_mat_khau.ItemClick += m_cmd_doi_mat_khau_ItemClick;
            m_cmd_nguoi_sd.ItemClick += m_cmd_nguoi_sd_ItemClick;
            m_cmd_backup_restore.ItemClick += m_cmd_backup_restore_ItemClick;
            //Danh muc
            m_cmd_dm_hs.ItemClick += m_cmd_dm_hs_ItemClick;
            m_cmd_dm_lop_mon.ItemClick += m_cmd_dm_lop_mon_ItemClick;
            //Bao cao
            m_cmd_tai_chinh_hs.ItemClick += m_cmd_tai_chinh_hs_ItemClick;
            m_cmd_tai_chinh_hs_lm.ItemClick += m_cmd_tai_chinh_hs_lm_ItemClick;
            m_cmd_tai_chinh_lm.ItemClick += m_cmd_tai_chinh_lm_ItemClick;
            m_cmd_tai_chinh_lm_hs.ItemClick += m_cmd_tai_chinh_lm_hs_ItemClick;
            m_cmd_hs_hien_nay.ItemClick += m_cmd_hs_hien_nay_ItemClick;
            m_cmd_hs_chua_nop_tien.ItemClick += m_cmd_hs_chua_nop_tien_ItemClick;
            m_cmd_bc_diem_danh.ItemClick += m_cmd_bc_diem_danh_ItemClick;
            m_cmd_thuc_thu_nv.ItemClick += m_cmd_thuc_thu_nv_ItemClick;
            m_cmd_ds_phieu.ItemClick += m_cmd_ds_phieu_ItemClick;
            m_cmd_bien_dong_hs.ItemClick += m_cmd_bien_dong_hs_ItemClick;
            m_cmd_ds_hs_theo_lm.ItemClick += m_cmd_ds_hs_theo_lm_ItemClick;
        }

        void m_cmd_import_excel_ItemClick(object sender, ItemClickEventArgs e) {
            try {
                f300_import_ds_hoc_vien v_frm = new f300_import_ds_hoc_vien();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_ds_hs_theo_lm_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f230_danh_muc_hs_theo_lop v_frm = new f230_danh_muc_hs_theo_lop();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_backup_restore_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                BackupDB v_frm = new BackupDB();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_bien_dong_hs_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f460_bc_tinh_hinh_bo_hoc v_frm = new f460_bc_tinh_hinh_bo_hoc();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_ban_giao_tien_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f360_ban_giao_tien v_frm = new f360_ban_giao_tien();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_lap_giam_tru_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f340_lap_phieu_thu v_frm = new f340_lap_phieu_thu();
                v_frm.set_phieu_giam_tru();
                if (IsExistFormText(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_lap_thuc_thu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f340_lap_phieu_thu v_frm = new f340_lap_phieu_thu();
                v_frm.set_phieu_thuc_thu();
                if (IsExistFormText(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_lap_phai_thu_tu_dong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f330_lap_phai_thu_hoc_vien v_frm = new f330_lap_phai_thu_hoc_vien();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_lap_phai_thu_le_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f340_lap_phieu_thu v_frm = new f340_lap_phieu_thu();
                v_frm.set_phieu_phai_thu();
                if (IsExistFormText(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_cap_nhat_hs_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f220_cap_nhat_thong_tin_hoc_sinh v_frm = new f220_cap_nhat_thong_tin_hoc_sinh();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_diem_danh_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f320_diem_danh v_frm = new f320_diem_danh();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_ds_phieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f430_bao_cao_danh_sach_phai_thu_thuc_thu v_frm = new f430_bao_cao_danh_sach_phai_thu_thuc_thu();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_thuc_thu_nv_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f490_bc_thuc_thu_theo_nv v_frm = new f490_bc_thuc_thu_theo_nv();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_bc_diem_danh_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f440_bao_cao_tinh_hinh_di_hoc_theo_lop_mon_hs v_frm = new f440_bao_cao_tinh_hinh_di_hoc_theo_lop_mon_hs();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_hs_chua_nop_tien_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f415_bao_cao_hoc_sinh_chua_nop_tien_theo_lop_mon v_frm = new f415_bao_cao_hoc_sinh_chua_nop_tien_theo_lop_mon();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_hs_hien_nay_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f450_bc_so_luong_hs_hien_nay v_frm = new f450_bc_so_luong_hs_hien_nay();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_tai_chinh_lm_hs_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                F420_bao_cao_tien_phai_thu_theo_lop_mon_hoc_sinh v_frm = new F420_bao_cao_tien_phai_thu_theo_lop_mon_hoc_sinh();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_tai_chinh_lm_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f410_bao_cao_tai_chinh_theo_lop_mon v_frm = new f410_bao_cao_tai_chinh_theo_lop_mon();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_tai_chinh_hs_lm_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f480_bao_cao_tinh_hinh_tai_chinh_theo_hs_lm v_frm = new f480_bao_cao_tinh_hinh_tai_chinh_theo_hs_lm();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_tai_chinh_hs_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f470_bao_cao_tinh_hinh_tai_chinh_theo_hoc_sinh v_frm = new f470_bao_cao_tinh_hinh_tai_chinh_theo_hoc_sinh();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_dm_lop_mon_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f210_dm_lop_mon v_frm = new f210_dm_lop_mon();

                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_dm_hs_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f230_danh_muc_hs_theo_lop v_frm = new f230_danh_muc_hs_theo_lop();

                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nguoi_sd_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f999_ht_nguoi_su_dung v_frm = new f999_ht_nguoi_su_dung();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_doi_mat_khau_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f308_DOI_MAT_KHAU_NGUOI_SD v_frm = new f308_DOI_MAT_KHAU_NGUOI_SD();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nhom_nguoi_su_dung_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f306_HT_USER_GROUP v_frm = new f306_HT_USER_GROUP();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_phan_quyen_nhom_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f995_ht_phan_quyen_cho_nhom v_frm = new f995_ht_phan_quyen_cho_nhom();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_thoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nghi_hoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f316_nghi_hoc v_frm = new f316_nghi_hoc();

                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nhap_hoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f315_nhap_hoc v_frm = new f315_nhap_hoc();

                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}