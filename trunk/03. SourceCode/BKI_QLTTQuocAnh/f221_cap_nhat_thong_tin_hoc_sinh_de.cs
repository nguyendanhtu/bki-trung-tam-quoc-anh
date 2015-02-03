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
        public void display() {
            this.ShowDialog();
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
            check_validate_data();
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
        }

        private void check_validate_data() {
            if (!CValidateTextBox.IsValid(m_txt_ma_hoc_sinh, DataType.StringType, allowNull.NO)) {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập mã học sinh");
                return;
            }
            if (!CValidateTextBox.IsValid(m_txt_ho_va_ten_lot, DataType.StringType, allowNull.NO)) {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập họ đệm học sinh");
                return;
            }
            if (!CValidateTextBox.IsValid(m_txt_ten, DataType.StringType, allowNull.NO)) {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập tên học sinh");
                return;
            }
            if (!CValidateTextBox.IsValid(m_txt_so_dien_thoai_hoc_sinh, DataType.StringType, allowNull.NO)) {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập SĐT học sinh");
                return;
            }
            if (!CValidateTextBox.IsValid(m_txt_truong_dang_hoc, DataType.StringType, allowNull.NO)) {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập trường đang học của học sinh");
                return;
            }
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
