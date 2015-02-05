using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.DS.CDBNames;
using BKI_QLTTQuocAnh.NghiepVu;
using C1.Win.C1FlexGrid;


namespace BKI_QLTTQuocAnh.NghiepVu
{
    public partial class f330_lap_phai_thu_hoc_vien : Form
    {
        public f330_lap_phai_thu_hoc_vien()
        {
            InitializeComponent();
            format_controls();
        }

        #region public interface
        #endregion

        #region Datastruct
        private enum e_col_Number {
            NGUOI_THU = 7
,
            SO_PHIEU = 2
                ,
            HO_TEN_PH = 6
                ,
            TIEN_THUC_THU = 10
                ,
            NGAY_THU = 1
                ,
            MA_HOC_SINH = 4
                ,
            NOI_DUNG = 3
                ,
            TIEN_CON_PHAI_THU = 11
                ,
            TIEN_GIAM_TRU = 9
                ,
            TIEN_PHAI_THU = 8
                , HO_TEN_HS = 5

        }
        #endregion

        #region Members
        DS_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU m_ds = new DS_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
        US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU m_us = new US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
        ITransferDataRow m_obj_trans;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);//Xuat excel
            CGridUtils.AddSearch_Handlers(m_fg);//Ctrl F dc

            //m_cmd_insert.Visible = false;
            m_cmd_update.Visible = false;
            m_cmd_delete.Visible = false;
            m_cmd_exit.Visible = false;

            m_fg.Tree.Column = (int)e_col_Number.NGAY_THU;
            m_fg.Tree.Style = TreeStyleFlags.SimpleLeaf;

            m_fg.Styles[CellStyleEnum.Normal].WordWrap = true;
            // m_fg.AllowResizing = AllowResizingEnum.Rows;
            m_fg.AutoSizeRows();

            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            set_define_events();
            this.KeyPreview = true;
        }
        private void grid2us_object(US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU i_us
           , int i_grid_row) {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU i_us
            , int i_grid_row) {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }
        private void load_data_2_grid() {

        }
        private void load_data_2_cbo_lop_mon() {
            DS_DM_LOP_MON v_ds = new DS_DM_LOP_MON();
            US_DM_LOP_MON v_us = new US_DM_LOP_MON();
            v_us.FillDataset(v_ds);

            DataRow v_dr = v_ds.DM_LOP_MON.NewRow();
            v_dr[DM_LOP_MON.ID] = -1;
            v_dr[DM_LOP_MON.MA_LOP_MON] = "--Tất cả--";
            v_dr[DM_LOP_MON.MO_TA] = "--Tất cả--";
            v_dr[DM_LOP_MON.DON_GIA_BUOI_HOC] = "0";
            v_ds.DM_LOP_MON.Rows.InsertAt(v_dr, 0);

            m_cbo_lop_mon.DataSource = v_ds.DM_LOP_MON;
            m_cbo_lop_mon.DisplayMember = DM_LOP_MON.MO_TA;
            m_cbo_lop_mon.ValueMember = DM_LOP_MON.ID;

            m_cbo_lop_mon.SelectedIndex = 0;
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg) {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.NGUOI_THU, e_col_Number.NGUOI_THU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.SO_PHIEU, e_col_Number.SO_PHIEU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.HO_TEN_PH, e_col_Number.HO_TEN_PH);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TIEN_THUC_THU, e_col_Number.TIEN_THUC_THU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.NGAY_THU, e_col_Number.NGAY_THU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.MA_HOC_SINH, e_col_Number.MA_HOC_SINH);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.NOI_DUNG, e_col_Number.NOI_DUNG);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TIEN_CON_PHAI_THU, e_col_Number.TIEN_CON_PHAI_THU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TIEN_GIAM_TRU, e_col_Number.TIEN_GIAM_TRU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TIEN_PHAI_THU, e_col_Number.TIEN_PHAI_THU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.HO_TEN_HS, e_col_Number.HO_TEN_HS);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.NewRow());
            return v_obj_trans;
        }
        private void set_initial_form_load() {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_cbo_lop_mon();
            m_cbo_lop_mon.SelectedIndexChanged += m_cbo_lop_mon_SelectedIndexChanged;
        }

        void m_cbo_lop_mon_SelectedIndexChanged(object sender, EventArgs e) {
            
        }
        #endregion
        private void set_define_events()
        {
            //this.KeyPress += f330_lap_phai_thu_hoc_vien_KeyPress;
            m_cmd_tu_dong.Click += m_cmd_tu_dong_Click;
            this.Load += f330_lap_phai_thu_hoc_vien_Load;
        }

        void f330_lap_phai_thu_hoc_vien_Load(object sender, EventArgs e) {
            try {
                set_initial_form_load();
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_tu_dong_Click(object sender, EventArgs e) {
            try {
                load_data_2_grid();
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        //void f330_lap_phai_thu_hoc_vien_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        load_data_2_grid();
        //    }
        //}


    }
}
