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
                    v_us.FillDataset(v_ds,"where ID="+ip_dc_id_user.ToString());
                }
            op_cbo_nhan_vien_thu.DataSource = v_ds.V_HT_NGUOI_SU_DUNG;
            op_cbo_nhan_vien_thu.DisplayMember = V_HT_NGUOI_SU_DUNG.TEN;
            op_cbo_nhan_vien_thu.ValueMember = V_HT_NGUOI_SU_DUNG.ID;

            op_cbo_nhan_vien_thu.SelectedIndex = 0;
        }

    }
}
