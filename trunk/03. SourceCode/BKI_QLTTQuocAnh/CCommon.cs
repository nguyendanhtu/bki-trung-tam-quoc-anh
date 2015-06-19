using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.DS.CDBNames;
using BKI_QLTTQuocAnh.US;

namespace BKI_QLTTQuocAnh
{
    class CCommon
    {
        /// <summary>
        /// Trả về danh sách các nhân viên được quyền chọn theo user người sử dụng
        /// </summary>
        /// <param name="ip_id_user"></param>
        public static void load_data_2_cbo_nhan_vien(
            decimal ip_dc_id_user
            , System.Windows.Forms.ComboBox op_cbo_nhan_vien_thu
            )
        {

            DS_V_HT_NGUOI_SU_DUNG v_ds = new DS_V_HT_NGUOI_SU_DUNG();
            US_V_HT_NGUOI_SU_DUNG v_us = new US_V_HT_NGUOI_SU_DUNG();
            if (US_V_HT_NGUOI_SU_DUNG.isInAdminGroup(ip_dc_id_user))
            {

                v_us.FillDataset(v_ds);
                DataRow v_dr = v_ds.V_HT_NGUOI_SU_DUNG.NewRow();
                v_dr[V_HT_NGUOI_SU_DUNG.ID] = -1;
                v_dr[V_HT_NGUOI_SU_DUNG.TEN_TRUY_CAP] = "All";
                v_dr[V_HT_NGUOI_SU_DUNG.TEN] = "--Tất cả---";
                v_dr[V_HT_NGUOI_SU_DUNG.MAT_KHAU] = 123;
                v_dr[V_HT_NGUOI_SU_DUNG.NGAY_TAO] = "2015-01-20";
                v_dr[V_HT_NGUOI_SU_DUNG.NGUOI_TAO] = "ADMIN";
                v_dr[V_HT_NGUOI_SU_DUNG.TRANG_THAI] = "0";
                v_dr[V_HT_NGUOI_SU_DUNG.BUILT_IN_YN] = "Y";
                v_dr[V_HT_NGUOI_SU_DUNG.ID_USER_GROUP] = 3;
                v_ds.V_HT_NGUOI_SU_DUNG.Rows.InsertAt(v_dr, 0);
            }
            else
            {
                v_us.FillDataset(v_ds, "where ID=" + ip_dc_id_user.ToString());
            }
            op_cbo_nhan_vien_thu.DataSource = v_ds.V_HT_NGUOI_SU_DUNG;
            op_cbo_nhan_vien_thu.DisplayMember = V_HT_NGUOI_SU_DUNG.TEN;
            op_cbo_nhan_vien_thu.ValueMember = V_HT_NGUOI_SU_DUNG.ID;

            op_cbo_nhan_vien_thu.SelectedIndex = 0;
        }


        public static void load_data_2_cbo_lop_mon(
            decimal ip_dc_id_lop_mon
            , System.Windows.Forms.ComboBox op_cbo_lop_mon
            )
        {
            DS_DM_LOP_MON v_ds_dm_lop_mon = new DS_DM_LOP_MON();
            US_DM_LOP_MON v_us_dm_lop_mon = new US_DM_LOP_MON();
            if (ip_dc_id_lop_mon == -1)
            {
                v_us_dm_lop_mon.FillDataset(v_ds_dm_lop_mon, "where TRANG_THAI_LOP_MON = 88");

                DataRow v_dr = v_ds_dm_lop_mon.DM_LOP_MON.NewRow();
                v_dr[DM_LOP_MON.ID] = -1;
                v_dr[DM_LOP_MON.MA_LOP_MON] = "--Tất cả--";
                v_dr[DM_LOP_MON.MO_TA] = "--Tất cả--";
                v_dr[DM_LOP_MON.TRANG_THAI_LOP_MON] = -1;
                v_dr[DM_LOP_MON.DON_GIA_BUOI_HOC] = 0;
                

                v_ds_dm_lop_mon.DM_LOP_MON.Rows.InsertAt(v_dr, 0);
            }
            else
            {
                v_us_dm_lop_mon.FillDataset(v_ds_dm_lop_mon, "where ID = " + ip_dc_id_lop_mon + " and TRANG_THAI_LOP_MON = 88");
            }
            op_cbo_lop_mon.DataSource = v_ds_dm_lop_mon.DM_LOP_MON;
            op_cbo_lop_mon.DisplayMember = DM_LOP_MON.MO_TA;
            op_cbo_lop_mon.ValueMember = DM_LOP_MON.ID;
            op_cbo_lop_mon.SelectedIndex = 0;
        }

        public static void load_data_2_cbo_trang_thai_lop_mon(
            decimal ip_dc_id_trang_thai_lop_mon
            , System.Windows.Forms.ComboBox op_cbo_trang_thai_lop_mon
            )
        {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds, "where id_loai_tu_dien = " + ip_dc_id_trang_thai_lop_mon);


            //DS_V_RPT_210_DM_LOP_MON v_ds_v_rpt_210_dm_lop_mon = new DS_V_RPT_210_DM_LOP_MON();
            //US_V_RPT_210_DM_LOP_MON v_us_v_rpt_210_dm_lop_mon = new US_V_RPT_210_DM_LOP_MON();

            //v_us_v_rpt_210_dm_lop_mon.FillDataset(v_ds_v_rpt_210_dm_lop_mon, "Where TRANG_THAI_LOP_MON = " + ip_dc_id_trang_thai_lop_mon.ToString());
            op_cbo_trang_thai_lop_mon.DataSource = v_ds.CM_DM_TU_DIEN;
            op_cbo_trang_thai_lop_mon.DisplayMember = CM_DM_TU_DIEN.TEN_NGAN;
            op_cbo_trang_thai_lop_mon.ValueMember = CM_DM_TU_DIEN.ID;
            op_cbo_trang_thai_lop_mon.SelectedIndex = 0;
           
        }

        public static void load_data_2_cbo_trang_thai_hoc_sinh(
            decimal ip_dc_id_trang_thai_hoc_sinh
            , System.Windows.Forms.ComboBox op_cbo_trang_thai_hoc_sinh
            )
        {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds, "where id_loai_tu_dien = " + ip_dc_id_trang_thai_hoc_sinh);

            //DataRow v_dr = v_ds.CM_DM_TU_DIEN.NewRow();
            //v_dr[CM_DM_TU_DIEN.ID] = -1;
            //v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "All";
            //v_dr[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN] = 10;
            //v_dr[CM_DM_TU_DIEN.TEN_NGAN] = "--Tất cả---";
            //v_dr[CM_DM_TU_DIEN.TEN] = "--Tất cả---";
            //v_ds.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);

            //DS_V_RPT_210_DM_LOP_MON v_ds_v_rpt_210_dm_lop_mon = new DS_V_RPT_210_DM_LOP_MON();
            //US_V_RPT_210_DM_LOP_MON v_us_v_rpt_210_dm_lop_mon = new US_V_RPT_210_DM_LOP_MON();

            //v_us_v_rpt_210_dm_lop_mon.FillDataset(v_ds_v_rpt_210_dm_lop_mon, "Where TRANG_THAI_LOP_MON = " + ip_dc_id_trang_thai_lop_mon.ToString());
            op_cbo_trang_thai_hoc_sinh.DataSource = v_ds.CM_DM_TU_DIEN;
            op_cbo_trang_thai_hoc_sinh.DisplayMember = CM_DM_TU_DIEN.TEN_NGAN;
            op_cbo_trang_thai_hoc_sinh.ValueMember = CM_DM_TU_DIEN.ID;
            op_cbo_trang_thai_hoc_sinh.SelectedIndex = 0;

        }

        public static void load_data_2_cbo_loai_phieu_thu(
            decimal ip_dc_id_loai_tu_dien
            , System.Windows.Forms.ComboBox op_cbo_tu_dien)
        {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds, "where id_loai_tu_dien = " + ip_dc_id_loai_tu_dien);

            DataRow v_dr = v_ds.CM_DM_TU_DIEN.NewRow();
            v_dr[CM_DM_TU_DIEN.ID] = -1;
            v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "TAT_CA";
            v_dr[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN] = -1;
            v_dr[CM_DM_TU_DIEN.TEN_NGAN] = "--Tất cả--";
            v_dr[CM_DM_TU_DIEN.TEN] = "--Tất cả--";
            v_dr[CM_DM_TU_DIEN.GHI_CHU] = "";

            v_ds.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);

            op_cbo_tu_dien.DataSource = v_ds.CM_DM_TU_DIEN;
            op_cbo_tu_dien.DisplayMember = CM_DM_TU_DIEN.TEN_NGAN;
            op_cbo_tu_dien.ValueMember = CM_DM_TU_DIEN.ID;

            op_cbo_tu_dien.SelectedIndex = 0;
        }

        public static void load_data_2_cbo_trang_thai_hoc_sinh(
            System.Windows.Forms.ComboBox op_cbo_trang_thai_hoc_sinh
            ) {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds, "where id_loai_tu_dien = " + CONST_LOAI_TU_DIEN.TRANG_THAI_HOC_SINH);

            op_cbo_trang_thai_hoc_sinh.DataSource = v_ds.CM_DM_TU_DIEN;
            op_cbo_trang_thai_hoc_sinh.DisplayMember = CM_DM_TU_DIEN.TEN_NGAN;
            op_cbo_trang_thai_hoc_sinh.ValueMember = CM_DM_TU_DIEN.ID;
            op_cbo_trang_thai_hoc_sinh.SelectedIndex = 0;

        }
    }
}
