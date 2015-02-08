using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using C1.Win.C1FlexGrid;
using BKI_QLTTQuocAnh.US;


namespace BKI_QLTTQuocAnh.DanhMuc
{
    public partial class f211_dm_lop_mon_de : Form
    {
        public f211_dm_lop_mon_de()
        {
            InitializeComponent();
            format_control();
        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }

        public void display_4_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_4_update(US.US_DM_LOP_MON ip_us_dm_lop_mon)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_lop_mon = ip_us_dm_lop_mon;
            us_object_2_form();
            this.ShowDialog();
        }

        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode;
        US_DM_LOP_MON m_us_dm_lop_mon = new US_DM_LOP_MON();
        #endregion

        #region Private methods

        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            //CControlFormat.setC1FlexFormat(m_fg);
            //CGridUtils.AddSave_Excel_Handlers(m_fg);
            //CGridUtils.AddSearch_Handlers(m_fg);

            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_cbo_mon_hoc();
        }

        private void load_data_2_cbo_mon_hoc()
        {
        }

        private bool check_validate_data_is_OK()
        {
            return true;
        }

        private void form_2_us_object()
        {
            m_us_dm_lop_mon.strMA_LOP_MON = m_txt_ma_lop_mon.Text;
            m_us_dm_lop_mon.strMO_TA = m_txt_mo_ta.Text;
            m_us_dm_lop_mon.dcDON_GIA_BUOI_HOC = CIPConvert.ToDecimal(m_txt_don_gia.Text);
        }

        private void us_object_2_form()
        {
            m_txt_ma_lop_mon.Text = m_us_dm_lop_mon.strMA_LOP_MON;
            m_txt_mo_ta.Text = m_us_dm_lop_mon.strMO_TA;
            m_txt_don_gia.Text = m_us_dm_lop_mon.dcDON_GIA_BUOI_HOC.ToString();
        }

        private void save_data()
        {
            if (check_validate_data_is_OK() != true)
            {
                return;
            }

            form_2_us_object();

            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    //us.insert();
                    m_us_dm_lop_mon.Insert();
                    BaseMessages.MsgBox_Infor("Bạn đã thêm thành công!!!");
                    this.Close();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    //us.UPDATE();
                    m_us_dm_lop_mon.Update();
                    BaseMessages.MsgBox_Infor("Bạn đã sửa thành công!!!");
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        #endregion

        private void set_define_events()
        {
            this.Load += f211_dm_lop_mon_de_Load;
            m_cmd_luu.Click += m_cmd_luu_Click;
            this.KeyDown += f211_dm_lop_mon_de_KeyDown;
        }

        void f211_dm_lop_mon_de_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            } 
        }

        void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f211_dm_lop_mon_de_Load(object sender, EventArgs e)
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

    }
}
