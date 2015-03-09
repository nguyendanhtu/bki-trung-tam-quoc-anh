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


namespace BKI_QLTTQuocAnh.NghiepVu {
    public partial class f330_lap_phai_thu_hoc_vien : Form {
        public f330_lap_phai_thu_hoc_vien() {
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
        decimal m_row_selected = -1;
        #endregion

        #region Private Methods
        private void format_controls() {
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

            m_fg.AllowEditing = true;
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
            DS_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU v_ds_ds_pt = new DS_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
            US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU v_us_ds_pt = new US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
            v_ds_ds_pt.EnforceConstraints = false;
            v_ds_ds_pt.Clear();
            v_us_ds_pt.FillThongTinHS(v_ds_ds_pt,CIPConvert.ToDecimal(m_cbo_lop_mon.SelectedValue));
            CGridUtils.Dataset2C1Grid(v_ds_ds_pt, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_fg);
            //Fill cac cot con lai
            for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count; v_i_cur_row++) {
                m_fg.Rows[v_i_cur_row][(int)e_col_Number.NGAY_THU] = m_dat_tai_ngay.Value.Date;
                m_fg.Rows[v_i_cur_row][(int)e_col_Number.NOI_DUNG] = m_txt_noi_dung.Text.Trim();
                m_fg.Rows[v_i_cur_row][(int)e_col_Number.HO_TEN_PH] = "PH "+ m_fg.Rows[v_i_cur_row][(int)e_col_Number.HO_TEN_HS];

                US_V_HT_NGUOI_SU_DUNG v_us_ht_nsd = new US_V_HT_NGUOI_SU_DUNG(CAppContext_201.getCurrentUserID());
                m_fg.Rows[v_i_cur_row][(int)e_col_Number.NGUOI_THU] = v_us_ht_nsd.strTEN;
                m_fg.Rows[v_i_cur_row][(int)e_col_Number.SO_PHIEU] = "PPT" + m_cbo_lop_mon.SelectedValue.ToString() +"_" + m_fg.Rows[v_i_cur_row][(int)e_col_Number.MA_HOC_SINH];
                m_fg.Rows[v_i_cur_row][(int)e_col_Number.TIEN_PHAI_THU] = m_txt_thanh_tien.Text;
            }
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
            CCommon.load_data_2_cbo_lop_mon(-1, m_cbo_lop_mon);
            CCommon.load_data_2_cbo_nhan_vien(CAppContext_201.getCurrentUserID(), m_cbo_nhan_vien_thu);
            CCommon.load_data_2_cbo_nhan_vien(CAppContext_201.getCurrentUserID(), m_cbo_nhan_vien_nhap);
            m_cbo_lop_mon.SelectedIndexChanged += m_cbo_lop_mon_SelectedIndexChanged;
            //load_data_2_grid();
        }
        private void goi_y_so_tien_textbox() {

        }
        private decimal is_null_text_box(TextBox ip_txt) {
            if (ip_txt.Text == "") {
                return 0;
            }
            else return CIPConvert.ToDecimal(ip_txt.Text.Trim());
        }
        private void get_thanh_tien() {
            m_txt_thanh_tien.Text = string.Format("{0:#,##0}", is_null_text_box(m_txt_don_gia) * is_null_text_box(m_txt_so_buoi));
        }
        private bool check_validate_data() {

            return true;
        }
        private bool check_all_ma_phieu_is_exist() {

            return false;
        }

        private void save_data() {
            if (check_all_ma_phieu_is_exist()) {
                BaseMessages.MsgBox_Error("Có một vài mã phiếu đã bị trùng!");
                return;
            }
            US_GD_PHIEU_THU v_us_gd_phieu_thu = new US_GD_PHIEU_THU();
            US_GD_CHI_TIET_PHIEU_THU v_us_gd_chi_tiet_phieu_thu = new US_GD_CHI_TIET_PHIEU_THU();

            v_us_gd_phieu_thu.BeginTransaction();
            for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count; v_i_cur_row++) {
                US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU v_us_rpt = new US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
                if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
                if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, v_i_cur_row)) return;
                grid2us_object(v_us_rpt, v_i_cur_row);

                
                //form_2_us_gd_phieu_thu
                v_us_gd_phieu_thu.strSO_PHIEU = m_fg.Rows[v_i_cur_row][(int)e_col_Number.SO_PHIEU].ToString().Trim();
                v_us_gd_phieu_thu.dcID_HOC_SINH = v_us_rpt.dcID_HOC_SINH;
                v_us_gd_phieu_thu.dcID_NGUOI_THU = CIPConvert.ToDecimal(m_cbo_nhan_vien_thu.SelectedValue);
                v_us_gd_phieu_thu.dcID_NGUOI_NHAP = CIPConvert.ToDecimal(m_cbo_nhan_vien_nhap.SelectedValue);
                v_us_gd_phieu_thu.strTEN_NGUOI_NOP_TIEN = m_fg.Rows[v_i_cur_row][(int)e_col_Number.HO_TEN_PH].ToString().Trim();
                v_us_gd_phieu_thu.strNOI_DUNG = m_fg.Rows[v_i_cur_row][(int)e_col_Number.NOI_DUNG].ToString().Trim();
                v_us_gd_phieu_thu.SetSO_TIENNull();
                v_us_gd_phieu_thu.datNGAY_THU = m_dat_tai_ngay.Value.Date;
                v_us_gd_phieu_thu.datNGAY_NHAP = m_dat_ngay_nhap.Value.Date;
                v_us_gd_phieu_thu.dcID_LOAI_PHIEU_THU = CONST_ID_LOAI_PHIEU_THU.PHIEU_PHAI_THU;
                v_us_gd_phieu_thu.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_BAN_GIAO.DA_BAN_GIAO;

                
                v_us_gd_phieu_thu.Insert();

                //form_2_us_gd_chi_tiet_phieu_thu
                v_us_gd_chi_tiet_phieu_thu.dcID_GD_PHIEU_THU = v_us_gd_phieu_thu.dcID;
                v_us_gd_chi_tiet_phieu_thu.dcID_LOP_MON = CIPConvert.ToDecimal(m_cbo_lop_mon.SelectedValue);
                v_us_gd_chi_tiet_phieu_thu.dcSO_TIEN = CIPConvert.ToDecimal(m_fg.Rows[v_i_cur_row][(int)e_col_Number.TIEN_PHAI_THU].ToString());
                v_us_gd_chi_tiet_phieu_thu.UseTransOfUSObject(v_us_gd_phieu_thu);
                v_us_gd_chi_tiet_phieu_thu.Insert();
            }
            v_us_gd_phieu_thu.CommitTransaction();
            BaseMessages.MsgBox_Infor("Đã tạo phiếu phải thu tự động cho lớp " + m_cbo_lop_mon.Text);
        }

        #endregion

        private void set_define_events() {
            //this.KeyPress += f330_lap_phai_thu_hoc_vien_KeyPress;
            m_cmd_tu_dong.Click += m_cmd_tu_dong_Click;
            this.Load += f330_lap_phai_thu_hoc_vien_Load;
            m_cmd_ds_phieu_phai_thu.Click += m_cmd_ds_phieu_phai_thu_Click;
            m_txt_don_gia.TextChanged += m_txt_don_gia_TextChanged;
            m_txt_so_buoi.TextChanged += m_txt_so_buoi_TextChanged;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_xoa_hang.Click += m_cmd_xoa_hang_Click;
        }

        void m_cmd_xoa_hang_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
                if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
                m_fg.RemoveItem(m_fg.Row);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_insert_Click(object sender, EventArgs e) {
            try {
                save_data();
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_txt_so_buoi_TextChanged(object sender, EventArgs e) {
            try {
                get_thanh_tien();

            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_txt_don_gia_TextChanged(object sender, EventArgs e) {
            try {
                //m_txt_don_gia.Text = string.Format("{0:#,##0}", is_null_text_box(m_txt_don_gia));
                get_thanh_tien();

            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cbo_lop_mon_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                goi_y_so_tien_textbox();

            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_ds_phieu_phai_thu_Click(object sender, EventArgs e) {
            try {
                f430_bao_cao_danh_sach_phai_thu_thuc_thu v_frm = new f430_bao_cao_danh_sach_phai_thu_thuc_thu();
                v_frm.display_ds_phieu_phai_thu();
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void f330_lap_phai_thu_hoc_vien_Load(object sender, EventArgs e) {
            try {
                set_initial_form_load();
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tu_dong_Click(object sender, EventArgs e) {
            try {
                if (check_validate_data()) {
                    load_data_2_grid();
                }
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


    }
}
