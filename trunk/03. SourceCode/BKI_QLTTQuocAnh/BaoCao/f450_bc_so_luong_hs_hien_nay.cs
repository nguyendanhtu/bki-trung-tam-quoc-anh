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

using C1.Win.C1FlexGrid;

namespace BKI_QLTTQuocAnh.BaoCao
{
    public partial class f450_bc_so_luong_hs_hien_nay : Form
    {
        public f450_bc_so_luong_hs_hien_nay()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            MA_LOP_MON = 1
, TONG_SO_HS = 2

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_RPT_450_BAO_CAO_SO_LUONG_LUONG_HOC_VIEN_HIEN_NAY m_ds = new DS_V_RPT_450_BAO_CAO_SO_LUONG_LUONG_HOC_VIEN_HIEN_NAY();
        US_V_RPT_450_BAO_CAO_SO_LUONG_LUONG_HOC_VIEN_HIEN_NAY m_us = new US_V_RPT_450_BAO_CAO_SO_LUONG_LUONG_HOC_VIEN_HIEN_NAY();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            set_define_events();
            this.KeyPreview = true;


        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_cbo_lop_mon();
            load_data_2_grid();
        }
        private void wrap_text_cell()
        {
            m_fg.Styles[CellStyleEnum.Normal].WordWrap = true;
            m_fg.AllowResizing = AllowResizingEnum.Rows;
            m_fg.AutoSizeRows();
        }
        private void load_data_2_cbo_lop_mon()
        {
            DS_DM_LOP_MON v_ds = new DS_DM_LOP_MON();
            US_DM_LOP_MON v_us = new US_DM_LOP_MON();
            v_us.FillDataset(v_ds, "where TRANG_THAI_LOP_MON = 88");

            DataRow v_dr = v_ds.DM_LOP_MON.NewRow();
            v_dr[DM_LOP_MON.ID] = -1;
            v_dr[DM_LOP_MON.MA_LOP_MON] = "--Tất cả--";
            v_dr[DM_LOP_MON.MO_TA] = "--Tất cả--";
            v_dr[DM_LOP_MON.DON_GIA_BUOI_HOC] = 0;
            v_dr[DM_LOP_MON.TRANG_THAI_LOP_MON] = "-1";

            v_ds.DM_LOP_MON.Rows.InsertAt(v_dr, 0);
            m_cbo_lop.DataSource = v_ds.DM_LOP_MON;
            m_cbo_lop.DisplayMember = DM_LOP_MON.MO_TA;
            m_cbo_lop.ValueMember = DM_LOP_MON.ID;

            m_cbo_lop.SelectedIndex = 0;
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_RPT_450_BAO_CAO_SO_LUONG_LUONG_HOC_VIEN_HIEN_NAY.MA_LOP_MON, e_col_Number.MA_LOP_MON);
            v_htb.Add(V_RPT_450_BAO_CAO_SO_LUONG_LUONG_HOC_VIEN_HIEN_NAY.TONG_SO_HS, e_col_Number.TONG_SO_HS);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_RPT_450_BAO_CAO_SO_LUONG_LUONG_HOC_VIEN_HIEN_NAY.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_RPT_450_BAO_CAO_SO_LUONG_LUONG_HOC_VIEN_HIEN_NAY();
            m_ds.Clear();
            m_ds.EnforceConstraints = false;
            m_us.FillDataset(m_ds
                                , CIPConvert.ToDecimal(m_cbo_lop.SelectedValue));
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);

            wrap_text_cell();

            m_fg.Subtotal(AggregateEnum.Sum
                        , 0
                        , -1
                        , (int)e_col_Number.TONG_SO_HS
                        , "");

            CGridUtils.MakeSoTT(0, m_fg);
            m_fg.Redraw = true;
        }
        private void grid2us_object(US_V_RPT_450_BAO_CAO_SO_LUONG_LUONG_HOC_VIEN_HIEN_NAY i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_RPT_450_BAO_CAO_SO_LUONG_LUONG_HOC_VIEN_HIEN_NAY i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_rpt_450_bao_cao_so_luong_luong_hoc_vien_hien_nay()
        {
            //	frm_420_DE v_fDE = new  frm_420_DE();								
            //	v_fDE.display();
            load_data_2_grid();
        }

        private void update_v_rpt_450_bao_cao_so_luong_luong_hoc_vien_hien_nay()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	frm_420_DE v_fDE = new frm_420_DE();
            //	v_fDE.display(m_us);
            load_data_2_grid();
        }

        private void delete_v_rpt_450_bao_cao_so_luong_luong_hoc_vien_hien_nay()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_RPT_450_BAO_CAO_SO_LUONG_LUONG_HOC_VIEN_HIEN_NAY v_us = new US_V_RPT_450_BAO_CAO_SO_LUONG_LUONG_HOC_VIEN_HIEN_NAY();
            grid2us_object(v_us, m_fg.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_fg.Rows.Remove(m_fg.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_v_rpt_450_bao_cao_so_luong_luong_hoc_vien_hien_nay()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	frm_420_DE v_fDE = new frm_420_DE();			
            //	v_fDE.display(m_us);
        }

        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            this.Load += f450_bc_so_luong_hs_hien_nay_Load;
            m_cmd_search.Click += m_cmd_search_Click;
            m_fg.DoubleClick += m_fg_DoubleClick;
            this.KeyDown += f450_bc_so_luong_hs_hien_nay_KeyDown;
        }

        void f450_bc_so_luong_hs_hien_nay_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    load_data_2_grid();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            } 
        }

        void m_fg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                US_V_RPT_450_BAO_CAO_SO_LUONG_LUONG_HOC_VIEN_HIEN_NAY v_us = new US_V_RPT_450_BAO_CAO_SO_LUONG_LUONG_HOC_VIEN_HIEN_NAY();
                if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
                if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
                grid2us_object(v_us, m_fg.Row);

                f230_danh_muc_hs_theo_lop v_frm = new f230_danh_muc_hs_theo_lop();
                v_frm.display(v_us.dcID);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            } 
        }

        void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            } 
        }

        void f450_bc_so_luong_hs_hien_nay_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            } 
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                insert_v_rpt_450_bao_cao_so_luong_luong_hoc_vien_hien_nay();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                update_v_rpt_450_bao_cao_so_luong_luong_hoc_vien_hien_nay();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                delete_v_rpt_450_bao_cao_so_luong_luong_hoc_vien_hien_nay();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_view_Click(object sender, EventArgs e)
        {
            try
            {
                view_v_rpt_450_bao_cao_so_luong_luong_hoc_vien_hien_nay();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
