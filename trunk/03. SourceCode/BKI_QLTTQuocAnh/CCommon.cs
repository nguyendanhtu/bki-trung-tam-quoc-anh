using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.DS.CDBNames;
using BKI_QLTTQuocAnh.US;

namespace BKI_QLTTQuocAnh {
    class CCommon {
        /// <summary>
        /// Trả về danh sách các nhân viên được quyền chọn theo user người sử dụng
        /// </summary>
        /// <param name="ip_id_user"></param>
        public static void load_data_2_cbo_nhan_vien(
            decimal ip_dc_id_user
            , System.Windows.Forms.ComboBox op_cbo_nhan_vien_thu
            ) {

            DS_V_HT_NGUOI_SU_DUNG v_ds = new DS_V_HT_NGUOI_SU_DUNG();
            US_V_HT_NGUOI_SU_DUNG v_us = new US_V_HT_NGUOI_SU_DUNG();
            if (US_V_HT_NGUOI_SU_DUNG.isInAdminGroup(ip_dc_id_user)) {

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
            else {
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
            ) {
            DS_DM_LOP_MON v_ds_dm_lop_mon = new DS_DM_LOP_MON();
            US_DM_LOP_MON v_us_dm_lop_mon = new US_DM_LOP_MON();
            if (ip_dc_id_lop_mon == -1) {
                v_us_dm_lop_mon.FillDataset(v_ds_dm_lop_mon);

                DataRow v_dr = v_ds_dm_lop_mon.DM_LOP_MON.NewRow();
                v_dr[DM_LOP_MON.ID] = -1;
                v_dr[DM_LOP_MON.MA_LOP_MON] = "--Tất cả--";
                v_dr[DM_LOP_MON.MO_TA] = "--Tất cả--";
                v_dr[DM_LOP_MON.DON_GIA_BUOI_HOC] = 0;

                v_ds_dm_lop_mon.DM_LOP_MON.Rows.InsertAt(v_dr, 0);

                op_cbo_lop_mon.DataSource = v_ds_dm_lop_mon.DM_LOP_MON;
                op_cbo_lop_mon.DisplayMember = DM_LOP_MON.MO_TA;
                op_cbo_lop_mon.ValueMember = DM_LOP_MON.ID;
            }
            else {
                v_us_dm_lop_mon.FillDataset(v_ds_dm_lop_mon, "where ID = "+ip_dc_id_lop_mon);
            }
            op_cbo_lop_mon.SelectedIndex = 0;
        }
    }
}
