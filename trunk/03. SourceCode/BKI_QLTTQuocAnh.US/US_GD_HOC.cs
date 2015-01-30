///************************************************
/// Generated by: vinhnt
/// Date: 30/01/2015 03:11:59
/// Goal: Create User Service Class for GD_HOC
///************************************************
/// <summary>
/// Create User Service Class for GD_HOC
/// </summary>

using System;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLTTQuocAnh.US{

public class US_GD_HOC : US_Object
{
	private const string c_TableName = "GD_HOC";
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

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
	}

	public decimal dcID_HOC_SINH 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_HOC_SINH", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_HOC_SINH"] = value;
		}
	}

	public bool IsID_HOC_SINHNull()	{
		return pm_objDR.IsNull("ID_HOC_SINH");
	}

	public void SetID_HOC_SINHNull() {
		pm_objDR["ID_HOC_SINH"] = System.Convert.DBNull;
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

	public bool IsID_LOP_MONNull()	{
		return pm_objDR.IsNull("ID_LOP_MON");
	}

	public void SetID_LOP_MONNull() {
		pm_objDR["ID_LOP_MON"] = System.Convert.DBNull;
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

	public void SetTRANG_THAI_YNNull() {
		pm_objDR["TRANG_THAI_YN"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_BAT_DAU
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_BAT_DAU", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_BAT_DAU"] = value;
		}
	}

	public bool IsNGAY_BAT_DAUNull()
	{
		return pm_objDR.IsNull("NGAY_BAT_DAU");
	}

	public void SetNGAY_BAT_DAUNull()
	{
		pm_objDR["NGAY_BAT_DAU"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_KET_THUC
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_KET_THUC", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_KET_THUC"] = value;
		}
	}

	public bool IsNGAY_KET_THUCNull()
	{
		return pm_objDR.IsNull("NGAY_KET_THUC");
	}

	public void SetNGAY_KET_THUCNull()
	{
		pm_objDR["NGAY_KET_THUC"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_GD_HOC() 
	{
		pm_objDS = new DS_GD_HOC();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_GD_HOC(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_GD_HOC(decimal i_dbID) 
	{
		pm_objDS = new DS_GD_HOC();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion
	}
}