using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPData;
using IP.Core.IPUserService;
using BKI_QLTTQuocAnh.DS.CDBNames;
using System.Collections;

namespace BKI_QLTTQuocAnh.NghiepVu {
    public partial class f360_ban_giao_tien : Form {
        public f360_ban_giao_tien() {
            InitializeComponent();
            format_controls();
        }

        #region Data Structure
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
        ITransferDataRow m_obj_trans;
        DS_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU m_ds = new DS_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
        US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU m_us = new US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
        #endregion

        #region Private Methods
        private void format_controls() {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);//Xuat excel
            CGridUtils.AddSearch_Handlers(m_fg);//Ctrl F dc

            m_fg.Tree.Column = (int)e_col_Number.NGAY_THU;
            m_fg.Tree.Style = TreeStyleFlags.SimpleLeaf;
            m_fg.Cols[(int)e_col_Number.TIEN_CON_PHAI_THU].Visible = false;
            m_fg.Cols[(int)e_col_Number.TIEN_GIAM_TRU].Visible = false;
            m_fg.Cols[(int)e_col_Number.TIEN_PHAI_THU].Visible = false;

            m_cmd_update.Visible = false;
            m_cmd_delete.Visible = false;

            m_fg.Styles[CellStyleEnum.Normal].WordWrap = true;
            // m_fg.AllowResizing = AllowResizingEnum.Rows;
            m_fg.AutoSizeRows();

            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_tong_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_txt_tong_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            set_define_events();
            this.KeyPreview = true;
        }
        private void wrap_text_cell() {
            m_fg.Styles[CellStyleEnum.Normal].WordWrap = true;
            m_fg.AllowResizing = AllowResizingEnum.Rows;
            m_fg.AutoSizeRows();
        }
        private void grid2us_object(US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU i_us
            , int i_grid_row) {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
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
        private void create_tree_2grid() {
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);

            m_fg.Subtotal(AggregateEnum.Sum
                , 0
                , -1
                , (int)e_col_Number.TIEN_PHAI_THU
                , "Tổng cộng");
            m_fg.Subtotal(AggregateEnum.Sum
                , 0
                , -1
                , (int)e_col_Number.TIEN_GIAM_TRU
                , "Tổng cộng");
            m_fg.Subtotal(AggregateEnum.Sum
                , 0
                , -1
                , (int)e_col_Number.TIEN_THUC_THU
                , "Tổng cộng");
            m_fg.Subtotal(AggregateEnum.Sum
             , 0
             , -1
             , (int)e_col_Number.TIEN_CON_PHAI_THU
             , "Tổng cộng");

            m_fg.Redraw = true;
        }
        private void load_data_2_grid() {
            m_ds = new DS_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
            m_ds.Clear();
            m_ds.EnforceConstraints = false;
            m_us.FillDatasetNguoiThu(
                m_ds
                , m_dat_tu_ngay.Value.Date
                , m_dat_den_ngay.Value.Date
                , CIPConvert.ToDecimal(m_cbo_nhan_vien_thu.SelectedValue));

            m_fg.Redraw = true;
            create_tree_2grid();
            CGridUtils.MakeSoTT(0, m_fg);
            wrap_text_cell();
        }
        private void set_initial_form_load() {
            m_obj_trans = get_trans_object(m_fg);
            CCommon.load_data_2_cbo_nhan_vien(CAppContext_201.getCurrentUserID(),m_cbo_nhan_vien_thu);
            load_data_2_grid();
        }
        private void cap_nhat_ban_giao() {
            if (m_fg.Rows.Count == 1) {
                return;
            }
            for (int v_i_cur_row = m_fg.Rows.Fixed+1; v_i_cur_row < m_fg.Rows.Count; v_i_cur_row++) {
                US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU v_us_v_rpt = new US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
                grid2us_object(v_us_v_rpt, v_i_cur_row);

                US_GD_PHIEU_THU v_us_gd_pt = new US_GD_PHIEU_THU(v_us_v_rpt.dcID);
                v_us_gd_pt.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_BAN_GIAO.DA_BAN_GIAO;
                v_us_gd_pt.Update();
            }
            load_data_2_grid();
            m_txt_tong_tien.Clear();
            BaseMessages.MsgBox_Infor("Đã bàn giao tiền!");
        }
        #endregion
        //
        //Events
        //
        private void set_define_events() {
            this.Load += f360_ban_giao_tien_Load;
            m_cmd_search.Click += m_cmd_search_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
            this.KeyDown += f360_ban_giao_tien_KeyDown;
            m_fg.DoubleClick += m_fg_DoubleClick;
        }

        void m_fg_DoubleClick(object sender, EventArgs e) {
            try {
                US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU v_us = new US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
                if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
                if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
                grid2us_object(v_us, m_fg.Row);

                //if (!check_ban_giao_is_da_thu_or_admin(v_us)) {
                //    BaseMessages.MsgBox_Infor("Phiếu này đã bàn giao, không được quyền sửa!");
                //    return;
                //}

                US_GD_PHIEU_THU v_us_gd_pt = new US_GD_PHIEU_THU(v_us.dcID);

                f340_lap_phieu_thu v_frm = new f340_lap_phieu_thu();
                v_frm.display(v_us, v_us_gd_pt.dcID_LOAI_PHIEU_THU, v_us_gd_pt.dcID_NGUOI_NHAP);
                load_data_2_grid();
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f360_ban_giao_tien_KeyDown(object sender, KeyEventArgs e)
        {
            try {
                if (e.KeyCode == Keys.Enter) {
                    load_data_2_grid();
                }
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_insert_Click(object sender, EventArgs e) {
            try {
                cap_nhat_ban_giao();
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        } 

        void m_cmd_search_Click(object sender, EventArgs e) {
            try {
                load_data_2_grid();
                if (m_fg.Rows.Count > 1) {
                    m_txt_tong_tien.Text = String.Format("{0:#,###0}", m_fg.Rows[m_fg.Rows.Fixed][(int)e_col_Number.TIEN_THUC_THU]);
                }
                
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f360_ban_giao_tien_Load(object sender, EventArgs e) {
            try {
                set_initial_form_load();
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        
    }
}
