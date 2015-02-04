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

namespace BKI_QLTTQuocAnh.NghiepVu
{
    public partial class f360_ban_giao_tien : Form
    {
        public f360_ban_giao_tien()
        {
            InitializeComponent();
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
        #region Private Methods
        private void format_controls() {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);//Xuat excel
            CGridUtils.AddSearch_Handlers(m_fg);//Ctrl F dc

            m_cmd_insert.Visible = false;
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

        
        #endregion
        //
        //Events
        //
        private void set_define_events() {
            throw new NotImplementedException();
        }
    }
}
