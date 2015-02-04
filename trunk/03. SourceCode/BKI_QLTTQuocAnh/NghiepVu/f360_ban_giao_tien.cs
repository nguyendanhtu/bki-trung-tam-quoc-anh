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

            m_fg.Styles[CellStyleEnum.Normal].WordWrap = true;
            // m_fg.AllowResizing = AllowResizingEnum.Rows;
            m_fg.AutoSizeRows();

            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            set_define_events();
            this.KeyPreview = true;
        }
        private void wrap_text_cell() {
            m_fg.Styles[CellStyleEnum.Normal].WordWrap = true;
            m_fg.AllowResizing = AllowResizingEnum.Rows;
            m_fg.AutoSizeRows();
        }
        private void load_data_2_cbo_nv_thu() {
            DS_HT_NGUOI_SU_DUNG v_ds_ht_nsd = new DS_HT_NGUOI_SU_DUNG();
            US_HT_NGUOI_SU_DUNG v_us_ht_nsd = new US_HT_NGUOI_SU_DUNG();
            v_us_ht_nsd.FillDataset(v_ds_ht_nsd);

            DataRow v_dr = v_ds_ht_nsd.HT_NGUOI_SU_DUNG.NewRow();
            v_dr[HT_NGUOI_SU_DUNG.ID] = -1;
            v_dr[HT_NGUOI_SU_DUNG.TEN_TRUY_CAP] = "";
            v_dr[HT_NGUOI_SU_DUNG.TEN] = "--Tất cả--";
            v_dr[HT_NGUOI_SU_DUNG.MAT_KHAU] = "";
            v_dr[HT_NGUOI_SU_DUNG.NGAY_TAO] = DateTime.Now.Date;
            v_dr[HT_NGUOI_SU_DUNG.NGUOI_TAO] = "";
            v_dr[HT_NGUOI_SU_DUNG.TRANG_THAI] = "";
            v_dr[HT_NGUOI_SU_DUNG.BUILT_IN_YN] = "Y";


            v_ds_ht_nsd.HT_NGUOI_SU_DUNG.Rows.InsertAt(v_dr, 0);

            m_cbo_nhan_vien_thu.ValueMember = HT_NGUOI_SU_DUNG.ID;
            m_cbo_nhan_vien_thu.DisplayMember = HT_NGUOI_SU_DUNG.TEN;
            m_cbo_nhan_vien_thu.DataSource = v_ds_ht_nsd.HT_NGUOI_SU_DUNG;

            m_cbo_nhan_vien_thu.SelectedIndex = 0;
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
            m_us.FillDatasetNguoiThu(
                m_ds
                , m_dat_tu_ngay.Value.Date
                , m_dat_den_ngay.Value.Date
                , CIPConvert.ToDecimal(m_cbo_nhan_vien_thu.SelectedValue));

            m_fg.Redraw = true;
            create_tree_2grid();

            wrap_text_cell();
        }
        private void set_initial_form_load() {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_cbo_nv_thu();
        }
        #endregion
        //
        //Events
        //
        private void set_define_events() {
            this.Load += f360_ban_giao_tien_Load;
            m_cmd_search.Click += m_cmd_search_Click;
        }

        void m_cmd_search_Click(object sender, EventArgs e) {
            try {
                load_data_2_grid();
                m_txt_tong_tien.Text = String.Format("{0:#,###0}", m_fg.Rows[m_fg.Rows.Fixed][(int)e_col_Number.TIEN_THUC_THU]);
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
