///************************************************
/// Generated by: Haihd
/// Date: 22/01/2015 02:10:20
/// Goal: Create User Service Class for V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU
///************************************************
/// <summary>
/// Create User Service Class for V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU
/// </summary>

using System;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLTTQuocAnh.US {

    public class US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU : US_Object {
        private const string c_TableName = "V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU";
        #region "Public Properties"
        public decimal dcID {
            get {
                return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
            }
            set {
                pm_objDR["ID"] = value;
            }
        }

        public bool IsIDNull() {
            return pm_objDR.IsNull("ID");
        }

        public void SetIDNull() {
            pm_objDR["ID"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_THU {
            get {
                return CNull.RowNVLDate(pm_objDR, "NGAY_THU", IPConstants.c_DefaultDate);
            }
            set {
                pm_objDR["NGAY_THU"] = value;
            }
        }

        public bool IsNGAY_THUNull() {
            return pm_objDR.IsNull("NGAY_THU");
        }

        public void SetNGAY_THUNull() {
            pm_objDR["NGAY_THU"] = System.Convert.DBNull;
        }

        public decimal dcID_LOAI_PHIEU_THU {
            get {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_PHIEU_THU", IPConstants.c_DefaultDecimal);
            }
            set {
                pm_objDR["ID_LOAI_PHIEU_THU"] = value;
            }
        }

        public bool IsID_LOAI_PHIEU_THUNull() {
            return pm_objDR.IsNull("ID_LOAI_PHIEU_THU");
        }

        public void SetID_LOAI_PHIEU_THUNull() {
            pm_objDR["ID_LOAI_PHIEU_THU"] = System.Convert.DBNull;
        }

        public string strSO_PHIEU {
            get {
                return CNull.RowNVLString(pm_objDR, "SO_PHIEU", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["SO_PHIEU"] = value;
            }
        }

        public bool IsSO_PHIEUNull() {
            return pm_objDR.IsNull("SO_PHIEU");
        }

        public void SetSO_PHIEUNull() {
            pm_objDR["SO_PHIEU"] = System.Convert.DBNull;
        }

        public string strNOI_DUNG {
            get {
                return CNull.RowNVLString(pm_objDR, "NOI_DUNG", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["NOI_DUNG"] = value;
            }
        }

        public bool IsNOI_DUNGNull() {
            return pm_objDR.IsNull("NOI_DUNG");
        }

        public void SetNOI_DUNGNull() {
            pm_objDR["NOI_DUNG"] = System.Convert.DBNull;
        }

        public decimal dcID_HOC_SINH {
            get {
                return CNull.RowNVLDecimal(pm_objDR, "ID_HOC_SINH", IPConstants.c_DefaultDecimal);
            }
            set {
                pm_objDR["ID_HOC_SINH"] = value;
            }
        }

        public bool IsID_HOC_SINHNull() {
            return pm_objDR.IsNull("ID_HOC_SINH");
        }

        public void SetID_HOC_SINHNull() {
            pm_objDR["ID_HOC_SINH"] = System.Convert.DBNull;
        }

        public string strMA_HOC_SINH {
            get {
                return CNull.RowNVLString(pm_objDR, "MA_HOC_SINH", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["MA_HOC_SINH"] = value;
            }
        }

        public bool IsMA_HOC_SINHNull() {
            return pm_objDR.IsNull("MA_HOC_SINH");
        }

        public void SetMA_HOC_SINHNull() {
            pm_objDR["MA_HOC_SINH"] = System.Convert.DBNull;
        }

        public string strHO_TEN_HS {
            get {
                return CNull.RowNVLString(pm_objDR, "HO_TEN_HS", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["HO_TEN_HS"] = value;
            }
        }

        public bool IsHO_TEN_HSNull() {
            return pm_objDR.IsNull("HO_TEN_HS");
        }

        public void SetHO_TEN_HSNull() {
            pm_objDR["HO_TEN_HS"] = System.Convert.DBNull;
        }

        public string strHO_TEN_PH {
            get {
                return CNull.RowNVLString(pm_objDR, "HO_TEN_PH", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["HO_TEN_PH"] = value;
            }
        }

        public bool IsHO_TEN_PHNull() {
            return pm_objDR.IsNull("HO_TEN_PH");
        }

        public void SetHO_TEN_PHNull() {
            pm_objDR["HO_TEN_PH"] = System.Convert.DBNull;
        }

        public decimal dcID_NGUOI_THU {
            get {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_THU", IPConstants.c_DefaultDecimal);
            }
            set {
                pm_objDR["ID_NGUOI_THU"] = value;
            }
        }

        public bool IsID_NGUOI_THUNull() {
            return pm_objDR.IsNull("ID_NGUOI_THU");
        }

        public void SetID_NGUOI_THUNull() {
            pm_objDR["ID_NGUOI_THU"] = System.Convert.DBNull;
        }

        public string strNGUOI_THU {
            get {
                return CNull.RowNVLString(pm_objDR, "NGUOI_THU", IPConstants.c_DefaultString);
            }
            set {
                pm_objDR["NGUOI_THU"] = value;
            }
        }

        public bool IsNGUOI_THUNull() {
            return pm_objDR.IsNull("NGUOI_THU");
        }

        public void SetNGUOI_THUNull() {
            pm_objDR["NGUOI_THU"] = System.Convert.DBNull;
        }

        public decimal dcTIEN_PHAI_THU {
            get {
                return CNull.RowNVLDecimal(pm_objDR, "TIEN_PHAI_THU", IPConstants.c_DefaultDecimal);
            }
            set {
                pm_objDR["TIEN_PHAI_THU"] = value;
            }
        }

        public bool IsTIEN_PHAI_THUNull() {
            return pm_objDR.IsNull("TIEN_PHAI_THU");
        }

        public void SetTIEN_PHAI_THUNull() {
            pm_objDR["TIEN_PHAI_THU"] = System.Convert.DBNull;
        }

        public decimal dcTIEN_GIAM_TRU {
            get {
                return CNull.RowNVLDecimal(pm_objDR, "TIEN_GIAM_TRU", IPConstants.c_DefaultDecimal);
            }
            set {
                pm_objDR["TIEN_GIAM_TRU"] = value;
            }
        }

        public bool IsTIEN_GIAM_TRUNull() {
            return pm_objDR.IsNull("TIEN_GIAM_TRU");
        }

        public void SetTIEN_GIAM_TRUNull() {
            pm_objDR["TIEN_GIAM_TRU"] = System.Convert.DBNull;
        }

        public decimal dcTIEN_THUC_THU {
            get {
                return CNull.RowNVLDecimal(pm_objDR, "TIEN_THUC_THU", IPConstants.c_DefaultDecimal);
            }
            set {
                pm_objDR["TIEN_THUC_THU"] = value;
            }
        }

        public bool IsTIEN_THUC_THUNull() {
            return pm_objDR.IsNull("TIEN_THUC_THU");
        }

        public void SetTIEN_THUC_THUNull() {
            pm_objDR["TIEN_THUC_THU"] = System.Convert.DBNull;
        }

        public decimal dcTIEN_CON_PHAI_THU {
            get {
                return CNull.RowNVLDecimal(pm_objDR, "TIEN_CON_PHAI_THU", IPConstants.c_DefaultDecimal);
            }
            set {
                pm_objDR["TIEN_CON_PHAI_THU"] = value;
            }
        }

        public bool IsTIEN_CON_PHAI_THUNull() {
            return pm_objDR.IsNull("TIEN_CON_PHAI_THU");
        }

        public void SetTIEN_CON_PHAI_THUNull() {
            pm_objDR["TIEN_CON_PHAI_THU"] = System.Convert.DBNull;
        }

        #endregion

        #region "Init Functions"
        public US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU() {
            pm_objDS = new DS_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU(DataRow i_objDR)
            : this() {
            this.DataRow2Me(i_objDR);
        }

        public US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU(decimal i_dbID) {
            pm_objDS = new DS_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion
        #region Additional
        public void FillDataset(
            DS_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU op_ds
            , decimal ip_dc_id_hoc_sinh
            , DateTime ip_dat_tu_ngay
            , DateTime ip_dat_den_ngay
            , decimal ip_dc_id_nguoi_thu
            , decimal ip_dc_id_loai_phieu_thu
            , string ip_str_search) {
            CStoredProc v_obj_spr = new CStoredProc("f430_bao_cao_danh_sach_phieu_thuc_thu");
            v_obj_spr.addDecimalInputParam("@ip_dc_id_hoc_sinh", ip_dc_id_hoc_sinh);
            v_obj_spr.addDatetimeInputParam("@ip_dat_tu_ngay", ip_dat_tu_ngay);
            v_obj_spr.addDatetimeInputParam("@ip_dat_den_ngay", ip_dat_den_ngay);
            v_obj_spr.addDecimalInputParam("@ip_dc_id_nguoi_thu", ip_dc_id_nguoi_thu);
            v_obj_spr.addNVarcharInputParam("@ip_str_search", ip_str_search);
            v_obj_spr.addDecimalInputParam("@ip_dc_id_loai_phieu_thu", ip_dc_id_loai_phieu_thu);
            v_obj_spr.fillDataSetByCommand(this, op_ds);
        }
        public void FillDatasetNguoiThu(
            DS_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU op_ds
            , DateTime ip_dat_tu_ngay
            , DateTime ip_dat_den_ngay
            , decimal ip_dc_id_nguoi_thu) {
            CStoredProc v_obj_spr = new CStoredProc("f360_danh_sach_phieu_thuc_thu_chua_ban_giao");
            v_obj_spr.addDatetimeInputParam("@ip_dat_tu_ngay", ip_dat_tu_ngay);
            v_obj_spr.addDatetimeInputParam("@ip_dat_den_ngay", ip_dat_den_ngay);
            v_obj_spr.addDecimalInputParam("@ip_dc_id_nguoi_thu", ip_dc_id_nguoi_thu);
            v_obj_spr.fillDataSetByCommand(this, op_ds);
        }
        #endregion

    }
}
