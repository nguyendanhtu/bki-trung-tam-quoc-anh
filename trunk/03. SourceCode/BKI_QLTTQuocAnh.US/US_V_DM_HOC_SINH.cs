///************************************************
/// Generated by: vinhnt
/// Date: 04/02/2015 07:43:31
/// Goal: Create User Service Class for V_DM_HOC_SINH
///************************************************
/// <summary>
/// Create User Service Class for V_DM_HOC_SINH
/// </summary>

using System;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLTTQuocAnh.US
{

    public class US_V_DM_HOC_SINH : US_Object
    {
        private const string c_TableName = "V_DM_HOC_SINH";
        #region "Public Properties"
        public decimal dcID
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID"] = value;
            }
        }

        public bool IsIDNull()
        {
            return pm_objDR.IsNull("ID");
        }

        public void SetIDNull()
        {
            pm_objDR["ID"] = System.Convert.DBNull;
        }

        public string strMA_DOI_TUONG
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_DOI_TUONG", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_DOI_TUONG"] = value;
            }
        }

        public bool IsMA_DOI_TUONGNull()
        {
            return pm_objDR.IsNull("MA_DOI_TUONG");
        }

        public void SetMA_DOI_TUONGNull()
        {
            pm_objDR["MA_DOI_TUONG"] = System.Convert.DBNull;
        }

        public string strHO
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "HO", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["HO"] = value;
            }
        }

        public bool IsHONull()
        {
            return pm_objDR.IsNull("HO");
        }

        public void SetHONull()
        {
            pm_objDR["HO"] = System.Convert.DBNull;
        }

        public string strTEN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN"] = value;
            }
        }

        public bool IsTENNull()
        {
            return pm_objDR.IsNull("TEN");
        }

        public void SetTENNull()
        {
            pm_objDR["TEN"] = System.Convert.DBNull;
        }

        public string strHO_TEN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "HO_TEN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["HO_TEN"] = value;
            }
        }

        public bool IsHO_TENNull()
        {
            return pm_objDR.IsNull("HO_TEN");
        }

        public void SetHO_TENNull()
        {
            pm_objDR["HO_TEN"] = System.Convert.DBNull;
        }

        public string strTRUONG_DANG_HOC
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TRUONG_DANG_HOC", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TRUONG_DANG_HOC"] = value;
            }
        }

        public bool IsTRUONG_DANG_HOCNull()
        {
            return pm_objDR.IsNull("TRUONG_DANG_HOC");
        }

        public void SetTRUONG_DANG_HOCNull()
        {
            pm_objDR["TRUONG_DANG_HOC"] = System.Convert.DBNull;
        }

        public string strEMAIL_HS
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "EMAIL_HS", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["EMAIL_HS"] = value;
            }
        }

        public bool IsEMAIL_HSNull()
        {
            return pm_objDR.IsNull("EMAIL_HS");
        }

        public void SetEMAIL_HSNull()
        {
            pm_objDR["EMAIL_HS"] = System.Convert.DBNull;
        }

        public string strEMAIL_PH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "EMAIL_PH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["EMAIL_PH"] = value;
            }
        }

        public bool IsEMAIL_PHNull()
        {
            return pm_objDR.IsNull("EMAIL_PH");
        }

        public void SetEMAIL_PHNull()
        {
            pm_objDR["EMAIL_PH"] = System.Convert.DBNull;
        }

        public string strDIA_CHI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DIA_CHI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DIA_CHI"] = value;
            }
        }

        public bool IsDIA_CHINull()
        {
            return pm_objDR.IsNull("DIA_CHI");
        }

        public void SetDIA_CHINull()
        {
            pm_objDR["DIA_CHI"] = System.Convert.DBNull;
        }

        public string strSDT_HS
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SDT_HS", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SDT_HS"] = value;
            }
        }

        public bool IsSDT_HSNull()
        {
            return pm_objDR.IsNull("SDT_HS");
        }

        public void SetSDT_HSNull()
        {
            pm_objDR["SDT_HS"] = System.Convert.DBNull;
        }

        public string strSDT_PH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SDT_PH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SDT_PH"] = value;
            }
        }

        public bool IsSDT_PHNull()
        {
            return pm_objDR.IsNull("SDT_PH");
        }

        public void SetSDT_PHNull()
        {
            pm_objDR["SDT_PH"] = System.Convert.DBNull;
        }

        public string strHO_TEN_PH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "HO_TEN_PH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["HO_TEN_PH"] = value;
            }
        }

        public bool IsHO_TEN_PHNull()
        {
            return pm_objDR.IsNull("HO_TEN_PH");
        }

        public void SetHO_TEN_PHNull()
        {
            pm_objDR["HO_TEN_PH"] = System.Convert.DBNull;
        }

        public string strSDT_CO_DINH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SDT_CO_DINH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SDT_CO_DINH"] = value;
            }
        }

        public bool IsSDT_CO_DINHNull()
        {
            return pm_objDR.IsNull("SDT_CO_DINH");
        }

        public void SetSDT_CO_DINHNull()
        {
            pm_objDR["SDT_CO_DINH"] = System.Convert.DBNull;
        }

        public decimal dcID_LOP_MON
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOP_MON", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LOP_MON"] = value;
            }
        }

        public bool IsID_LOP_MONNull()
        {
            return pm_objDR.IsNull("ID_LOP_MON");
        }

        public void SetID_LOP_MONNull()
        {
            pm_objDR["ID_LOP_MON"] = System.Convert.DBNull;
        }

        public decimal dcID_LOP
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOP", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LOP"] = value;
            }
        }

        public bool IsID_LOPNull()
        {
            return pm_objDR.IsNull("ID_LOP");
        }

        public void SetID_LOPNull()
        {
            pm_objDR["ID_LOP"] = System.Convert.DBNull;
        }

        public decimal dcID_MON
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_MON", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_MON"] = value;
            }
        }

        public bool IsID_MONNull()
        {
            return pm_objDR.IsNull("ID_MON");
        }

        public void SetID_MONNull()
        {
            pm_objDR["ID_MON"] = System.Convert.DBNull;
        }

        public string strMA_LOP_MON
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_LOP_MON", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_LOP_MON"] = value;
            }
        }

        public bool IsMA_LOP_MONNull()
        {
            return pm_objDR.IsNull("MA_LOP_MON");
        }

        public void SetMA_LOP_MONNull()
        {
            pm_objDR["MA_LOP_MON"] = System.Convert.DBNull;
        }

        public decimal dcDON_GIA_BUOI_HOC
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "DON_GIA_BUOI_HOC", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["DON_GIA_BUOI_HOC"] = value;
            }
        }

        public bool IsDON_GIA_BUOI_HOCNull()
        {
            return pm_objDR.IsNull("DON_GIA_BUOI_HOC");
        }

        public void SetDON_GIA_BUOI_HOCNull()
        {
            pm_objDR["DON_GIA_BUOI_HOC"] = System.Convert.DBNull;
        }

        public decimal dcID_GD_HOC
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_GD_HOC", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_GD_HOC"] = value;
            }
        }

        public bool IsID_GD_HOCNull()
        {
            return pm_objDR.IsNull("ID_GD_HOC");
        }

        public void SetID_GD_HOCNull()
        {
            pm_objDR["ID_GD_HOC"] = System.Convert.DBNull;
        }

        public string strTRANG_THAI_YN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TRANG_THAI_YN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TRANG_THAI_YN"] = value;
            }
        }

        public bool IsTRANG_THAI_YNNull()
        {
            return pm_objDR.IsNull("TRANG_THAI_YN");
        }

        public void SetTRANG_THAI_YNNull()
        {
            pm_objDR["TRANG_THAI_YN"] = System.Convert.DBNull;
        }

        public string strTRANG_THAI_HS
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TRANG_THAI_HS", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TRANG_THAI_HS"] = value;
            }
        }

        public bool IsTRANG_THAI_HSNull()
        {
            return pm_objDR.IsNull("TRANG_THAI_HS");
        }

        public void SetTRANG_THAI_HSNull()
        {
            pm_objDR["TRANG_THAI_HS"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_V_DM_HOC_SINH()
        {
            pm_objDS = new DS_V_DM_HOC_SINH();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_V_DM_HOC_SINH(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_V_DM_HOC_SINH(decimal i_dbID)
        {
            pm_objDS = new DS_V_DM_HOC_SINH();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion
        public void FillDataset(DS_V_DM_HOC_SINH op_ds
         , decimal ip_dc_id_lop_mon
         , string ip_str_search
         , string ip_str_trang_thai_hoc)
        {
            CStoredProc v_obj_spr = new CStoredProc("f230_danh_muc_hoc_sinh_theo_lop_mon");
            v_obj_spr.addDecimalInputParam("@ip_dc_id_lop_mon", ip_dc_id_lop_mon);
            v_obj_spr.addNVarcharInputParam("@ip_str_search", ip_str_search);
            v_obj_spr.addNVarcharInputParam("@ip_str_trang_thai_hoc", ip_str_trang_thai_hoc);
            v_obj_spr.fillDataSetByCommand(this, op_ds);
        }
        //public void FillDataset_danh_sach_hoc_sinh_theo_lop_mon(DS_V_DM_HOC_SINH op_ds
        // , decimal ip_dc_id_lop_mon)
        //{
        //    CStoredProc v_obj_spr = new CStoredProc("f320_danh_sach_hoc_sinh_theo_lop_mon");
        //    v_obj_spr.addDecimalInputParam("@ip_dc_id_lop_mon", ip_dc_id_lop_mon);
        //    v_obj_spr.fillDataSetByCommand(this, op_ds);
        //}

        public void FillDataset_danh_sach_hoc_sinh_theo_lop_mon(
            DS_V_DM_HOC_SINH op_ds
            , decimal ip_dc_id_lop_mon
            , decimal ip_dc_id_nguoi_diem_danh
            , DateTime ip_dat_tai_ngay)
        {
            CStoredProc v_obj_spr = new CStoredProc("f320_danh_sach_hoc_sinh_theo_lop_mon");
            v_obj_spr.addDecimalInputParam("@ip_dc_id_lop_mon", ip_dc_id_lop_mon);
            v_obj_spr.addDecimalInputParam("@ip_dc_id_nguoi_diem_danh", ip_dc_id_nguoi_diem_danh);
            v_obj_spr.addDatetimeInputParam("@ip_dat_tai_ngay", ip_dat_tai_ngay);

            v_obj_spr.fillDataSetByCommand(this, op_ds);
        }

        public bool check_diem_danh_hs(
            decimal ip_dc_id_hoc_sinh
            , decimal ip_dc_id_lop_mon
            , decimal ip_dc_id_nguoi_diem_danh
            , DateTime ip_dat_tai_ngay
            , ref decimal op_dc_id_gd_diem_danh)
        {
            DS_GD_DIEM_DANH op_ds_diem_danh = new DS_GD_DIEM_DANH();
            CStoredProc v_obj_spr = new CStoredProc("pr_kiem_tra_hoc_sinh_diem_danh");
            v_obj_spr.addDecimalInputParam("@ip_dc_id_hoc_sinh", ip_dc_id_hoc_sinh);
            v_obj_spr.addDecimalInputParam("@ip_dc_id_lop_mon", ip_dc_id_lop_mon);
            v_obj_spr.addDecimalInputParam("@ip_dc_id_nguoi_diem_danh", ip_dc_id_nguoi_diem_danh);
            v_obj_spr.addDatetimeInputParam("@ip_dat_tai_ngay", ip_dat_tai_ngay);
            SqlParameter v_id_gd_diem_danh = v_obj_spr.addDecimalOutputParam("@op_dc_id_gd_diem_danh", 0);

            v_obj_spr.ExecuteCommand(this);

            op_dc_id_gd_diem_danh = CIPConvert.ToDecimal(v_id_gd_diem_danh.Value);
            if (op_dc_id_gd_diem_danh == -1)
            {
                return false;
            }
            else
                return true;
        }
    }
}