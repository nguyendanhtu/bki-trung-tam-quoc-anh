///************************************************
/// Generated by: haihd
/// Date: 29/01/2015 09:58:58
/// Goal: Create User Service Class for V_RPT_210_DM_LOP_MON
///************************************************
/// <summary>
/// Create User Service Class for V_RPT_210_DM_LOP_MON
/// </summary>

using System;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLTTQuocAnh.US{

public class US_V_RPT_210_DM_LOP_MON : US_Object
{
	private const string c_TableName = "V_RPT_210_DM_LOP_MON";
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

    public string strTEN_LOP_MON
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TEN_LOP_MON", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TEN_LOP_MON"] = value;
        }
    }

    public bool IsTEN_LOP_MONNull()
    {
        return pm_objDR.IsNull("TEN_LOP_MON");
    }

    public void SetTEN_LOP_MONNull()
    {
        pm_objDR["TEN_LOP_MON"] = System.Convert.DBNull;
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

    public decimal dcID_CA_HOC
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_CA_HOC", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_CA_HOC"] = value;
        }
    }

    public bool IsID_CA_HOCNull()
    {
        return pm_objDR.IsNull("ID_CA_HOC");
    }

    public void SetID_CA_HOCNull()
    {
        pm_objDR["ID_CA_HOC"] = System.Convert.DBNull;
    }

    public string strCA_HOC
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "CA_HOC", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["CA_HOC"] = value;
        }
    }

    public bool IsCA_HOCNull()
    {
        return pm_objDR.IsNull("CA_HOC");
    }

    public void SetCA_HOCNull()
    {
        pm_objDR["CA_HOC"] = System.Convert.DBNull;
    }

    #endregion
    #region "Init Functions"
	public US_V_RPT_210_DM_LOP_MON() 
	{
		pm_objDS = new DS_V_RPT_210_DM_LOP_MON();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_RPT_210_DM_LOP_MON(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_RPT_210_DM_LOP_MON(decimal i_dbID) 
	{
		pm_objDS = new DS_V_RPT_210_DM_LOP_MON();
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