using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Net.SourceForge.Vietpad.InputMethod;
using ThietBiBLL;
using ThietBiDAL;

namespace ThietBiPY.DanhMuc.vitridiali
{
    public partial class frm_nuoc_capnhat : DevComponents.DotNetBar.Office2007Form 
    {

        string ma = "";

        public frm_nuoc_capnhat()
        {
            InitializeComponent();
        }
        public frm_nuoc_capnhat(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            this.txt_tennuoc.Text = new NUOC_BLL().nuoc_thongtin(ma).TenNuoc;
        }

        #region "Pass Data"
        public delegate void passData(string giatri);
        public passData DuLieu;
        public void guidulieu(string giatri)
        {
            if (DuLieu != null) DuLieu(giatri);
        }
        #endregion

        public void thuchien()
        {
            NUOC_BLL NUOC = new NUOC_BLL();
            if (ma == "")
            {
                NUOC.NUOC_DTO.TenNuoc = txt_tennuoc.Text.Trim();
                if (NUOC.nuoc_them() > 0)
                {
                    guidulieu(NUOC.NUOC_DTO.NuocID.ToString());
                    this.Close();
                }
            }
            else
            {
                NUOC.NUOC_DTO.TenNuoc = txt_tennuoc.Text.Trim();
                if (NUOC.nuoc_sua(ma) > 0)
                {
                    guidulieu(NUOC.NUOC_DTO.NuocID.ToString());
                    this.Close();
                }
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            thuchien();
        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_nuoc_capnhat_Load(object sender, EventArgs e)
        {
            txt_tennuoc.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_tennuoc).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
    }
}
