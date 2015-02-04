using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;

namespace BKI_QLTTQuocAnh {
    public partial class f221_cap_nhat_thong_tin_hoc_sinh_de : Form {
        public f221_cap_nhat_thong_tin_hoc_sinh_de() {
            InitializeComponent();
            format_controls();
        }

        #region Public Interfaces
        public void display_for_insert() {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_V_DM_HOC_SINH ip_us_test)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = ip_us_test;
            us_obj_2_from();
            this.ShowDialog();
        }

        private void us_obj_2_from()
        {
            m_txt_ma_hoc_sinh.Text = m_us.strMA_DOI_TUONG;
            m_txt_ho_va_ten_lot.Text = m_us.strHO;
            m_txt_ten.Text = m_us.strTEN;
            m_txt_so_dien_thoai_hoc_sinh.Text = m_us.strSDT_HS;
            m_txt_so_dien_thoai_phu_huynh.Text = m_us.strSDT_PH;
            m_txt_email_hoc_sinh.Text = m_us.strEMAIL_HS;
            m_txt_email_phu_huynh.Text = m_us.strEMAIL_PH;
            m_txt_truong_dang_hoc.Text = m_us.strTRUONG_DANG_HOC;
            m_txt_dia_chi.Text = m_us.strDIA_CHI;
            m_txt_ho_ten_phu_huynh.Text = m_us.strHO_TEN_PH;
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode;
        US_V_DM_HOC_SINH m_us = new US_V_DM_HOC_SINH();
        #endregion

        #region Private Methods
        private void format_controls() {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            set_define_events();
            this.KeyPreview = true;
        }
        private void save_data() {
            if (check_validate_data() == false) return;
            form_2_us();
            switch (m_e_form_mode) {
                case DataEntryFormMode.InsertDataState:
                    m_us.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us.Update();
                    break;
                default:
                    break;
            }
            BaseMessages.MsgBox_Infor("Đã cập nhật thành công!");
        }

        private void form_2_us() {
            m_us.strMA_DOI_TUONG = m_txt_ma_hoc_sinh.Text.Trim();
            m_us.strHO = m_txt_ho_va_ten_lot.Text.Trim();
            m_us.strTEN = m_txt_ten.Text.Trim();
            m_us.strSDT_HS = m_txt_so_dien_thoai_hoc_sinh.Text.Trim();
            m_us.strEMAIL_HS = m_txt_email_hoc_sinh.Text.Trim();
            m_us.strTRUONG_DANG_HOC = m_txt_truong_dang_hoc.Text.Trim();
            m_us.strDIA_CHI = m_txt_dia_chi.Text.Trim();
            m_us.strHO_TEN_PH = m_txt_ho_ten_phu_huynh.Text.Trim();
            m_us.strEMAIL_PH = m_txt_email_phu_huynh.Text.Trim();
            m_us.strSDT_PH = m_txt_so_dien_thoai_phu_huynh.Text.Trim();

            //m_us.SetIDNull();
            //m_us.SetHO_TENNull();
            //m_us.SetHO_TEN_PHNull();
            //m_us.SetSDT_CO_DINHNull();
            //m_us.SetID_LOP_MONNull();
            //m_us.SetID_LOPNull();
            //m_us.SetID_MONNull();
            //m_us.SetMA_LOP_MONNull();
            //m_us.SetDON_GIA_BUOI_HOCNull();
            //m_us.SetID_GD_HOCNull();
            //m_us.SetTRANG_THAI_YNNull();
            //m_us.SetTRANG_THAI_HSNull();
        }

        private bool check_validate_data() {
            if (!CValidateTextBox.IsValid(m_txt_ma_hoc_sinh, DataType.StringType, allowNull.NO,true)) {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập mã học sinh");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ho_va_ten_lot, DataType.StringType, allowNull.NO,true)) {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập họ đệm học sinh");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ten, DataType.StringType, allowNull.NO,true)) {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập tên học sinh");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_so_dien_thoai_hoc_sinh, DataType.StringType, allowNull.NO,true)) {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập SĐT học sinh");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_truong_dang_hoc, DataType.StringType, allowNull.NO,true)) {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập trường đang học của học sinh");
                return false;
            }
            return true;
        }





//Events
        private void set_define_events() {
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
        }

        void m_cmd_exit_Click(object sender, EventArgs e) {
            try {
                this.Close();
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_save_Click(object sender, EventArgs e) {
            try {
                save_data();
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #endregion


    }
}
