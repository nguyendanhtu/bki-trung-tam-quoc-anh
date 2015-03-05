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

namespace BKI_QLTTQuocAnh
{
    public partial class f221_cap_nhat_thong_tin_hoc_sinh_de : Form
    {
        public f221_cap_nhat_thong_tin_hoc_sinh_de()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interfaces
        public void display_for_insert()
        {
            US_V_HOC_SINH v_us_hs = new US_V_HOC_SINH();
            m_txt_ma_hoc_sinh.Text = v_us_hs.suggest_id_hs_moi();
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        //public US_V_HOC_SINH get_us_v_dm_hoc_sinh()
        //{
        //    return m_us_hs;
        //}
        public US_V_HOC_SINH select_hoc_sinh(ref US_V_HOC_SINH m_us_v_hoc_sinh)
        {
            m_us_v_hoc_sinh = m_us_hs;
            //m_cmd_delete.Visible = false;
            //m_cmd_insert.Visible = false;
            //m_cmd_update.Visible = false;
            // m_dgl_result = System.Windows.Forms.DialogResult.Cancel;
            //// m_cmd_exit.Visible = true;
            //this.ShowDialog();
            
            return m_us_v_hoc_sinh;
        }
        public void display_for_update(US_V_HOC_SINH ip_us_test)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_hs = ip_us_test;
            us_obj_2_from();
            this.ShowDialog();
        }

        private void us_obj_2_from()
        {
            m_txt_ma_hoc_sinh.Text = m_us_hs.strMA_DOI_TUONG;
            m_txt_ho_va_ten_lot.Text = m_us_hs.strHO;
            m_txt_ten.Text = m_us_hs.strTEN;
            m_txt_so_dien_thoai_hoc_sinh.Text = m_us_hs.strSDT_HS;
            m_txt_so_dien_thoai_phu_huynh.Text = m_us_hs.strSDT_PH;
            m_txt_email_hoc_sinh.Text = m_us_hs.strEMAIL_HS;
            m_txt_email_phu_huynh.Text = m_us_hs.strEMAIL_PH;
            m_txt_truong_dang_hoc.Text = m_us_hs.strTRUONG_DANG_HOC;
            m_txt_dia_chi.Text = m_us_hs.strDIA_CHI;
            m_txt_ho_ten_phu_huynh.Text = m_us_hs.strHO_TEN_PH;
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode;
        DialogResult m_dgl_result = DialogResult.Cancel;
        US_V_DM_HOC_SINH m_us = new US_V_DM_HOC_SINH();
        US_V_HOC_SINH m_us_hs = new US_V_HOC_SINH();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            Desgin_For_f221();
            set_define_events();
            m_cmd_exit.Visible = false;
            this.KeyPreview = true;
        }

        private void Desgin_For_f221()
        {
            //label
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_dia_chi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_email_hoc_sinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_email_phu_huynh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_ho_ten_phu_huynh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_ho_va_ten_lot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_ma_so_hoc_sinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_so_dien_thoai_hoc_sinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_so_dien_thoai_phu_huynh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_truong_dang_hoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_so_co_dinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            //textbox
            this.m_txt_dia_chi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_txt_email_hoc_sinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_txt_email_phu_huynh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_txt_ho_ten_phu_huynh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_txt_ho_va_ten_lot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_txt_ma_hoc_sinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_txt_so_dien_thoai_hoc_sinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_txt_so_dien_thoai_phu_huynh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_txt_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_txt_truong_dang_hoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_txt_sdt_co_dinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            //button
            this.m_cmd_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_cmd_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
        }

        private void save_data()
        {
            if (check_validate_data() == false) return;
            form_2_us();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_hs.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_hs.Update();
                    break;
                default:
                    break;
            }
            BaseMessages.MsgBox_Infor("Đã cập nhật thành công!");
        }

        private void form_2_us()
        {
            m_us_hs.strMA_DOI_TUONG = m_txt_ma_hoc_sinh.Text.Trim();
            m_us_hs.strHO = m_txt_ho_va_ten_lot.Text.Trim();
            m_us_hs.strTEN = m_txt_ten.Text.Trim();
            m_us_hs.strSDT_HS = m_txt_so_dien_thoai_hoc_sinh.Text.Trim();
            m_us_hs.strEMAIL_HS = m_txt_email_hoc_sinh.Text.Trim();
            m_us_hs.strTRUONG_DANG_HOC = m_txt_truong_dang_hoc.Text.Trim();
            m_us_hs.strDIA_CHI = m_txt_dia_chi.Text.Trim();
            m_us_hs.strHO_TEN_PH = m_txt_ho_ten_phu_huynh.Text.Trim();
            m_us_hs.strEMAIL_PH = m_txt_email_phu_huynh.Text.Trim();
            m_us_hs.strSDT_PH = m_txt_so_dien_thoai_phu_huynh.Text.Trim();
            m_us_hs.strSDT_CO_DINH = m_txt_sdt_co_dinh.Text.Trim();

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

        private void form_2_us_2()
        {
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
        }

        private bool check_validate_data()
        {
            if (!CValidateTextBox.IsValid(m_txt_ma_hoc_sinh, DataType.StringType, allowNull.NO, true))
            {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập mã học sinh");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ho_va_ten_lot, DataType.StringType, allowNull.NO, true))
            {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập họ đệm học sinh");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ten, DataType.StringType, allowNull.NO, true))
            {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập tên học sinh");
                return false;
            }
            //if (!CValidateTextBox.IsValid(m_txt_so_dien_thoai_hoc_sinh, DataType.StringType, allowNull.NO,true)) {
            //    BaseMessages.MsgBox_Infor("Bạn chưa nhập SĐT học sinh");
            //    return false;
            //}
            //if (!CValidateTextBox.IsValid(m_txt_truong_dang_hoc, DataType.StringType, allowNull.NO,true)) {
            //    BaseMessages.MsgBox_Infor("Bạn chưa nhập trường đang học của học sinh");
            //    return false;
            //}
            return true;
        }

        #endregion

        //Events
        private void set_define_events()
        {
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
            this.KeyDown += f221_cap_nhat_thong_tin_hoc_sinh_de_KeyDown;
        }

        void f221_cap_nhat_thong_tin_hoc_sinh_de_KeyDown(object sender, KeyEventArgs e)
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

        void m_cmd_exit_Click(object sender, EventArgs e)
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

        void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}
