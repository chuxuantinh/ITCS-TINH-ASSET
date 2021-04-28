using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThietBiPY.HeThong
{
    public partial class frm_hethong_thietlap : DevComponents.DotNetBar.Office2007Form 
    {
        public frm_hethong_thietlap()
        {
            InitializeComponent();
            superTabControl1_SelectedTabChanged(null, null);
        }

        private void superTabControl1_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        {
            if (superTabControl1.SelectedTab == superTabItem_Server)
            {



                LopHoTro.CAUHINHREGISTRY REG = new ThietBiPY.LopHoTro.CAUHINHREGISTRY();
                LopHoTro.CHUYENKIEU MAHOA = new ThietBiPY.LopHoTro.CHUYENKIEU();

                chk_luuketnoi.Checked = REG.laykhoa("Server") != "" ? true : false;

                txt_hethong_server.Text = MAHOA.Mahoa2Mahoa(REG.laykhoa("Server"));
                txt_hethong_csdl.Text = MAHOA.Mahoa2Mahoa(REG.laykhoa("Database"));

                cmbAuthentication.SelectedIndex = (REG.laykhoa("User ID") != "" ? 1 : 0);
                txt_hethong_taikhoanserver.Text = MAHOA.Mahoa2Mahoa(REG.laykhoa("User ID"));
                txt_hethong_matkhauserver.Text = MAHOA.Mahoa2Mahoa(REG.laykhoa("Password"));
            }
        }

        private void cmbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAuthentication.SelectedIndex == 0)
            {
                txt_hethong_taikhoanserver.Text = "";
                txt_hethong_matkhauserver.Text = "";
                txt_hethong_taikhoanserver.Enabled = false;
                txt_hethong_matkhauserver.Enabled = false;
            }
            else
            {
                txt_hethong_taikhoanserver.Enabled = true;
                txt_hethong_matkhauserver.Enabled = true;
            }
        }

        private void btn_apdung_server_Click(object sender, EventArgs e)
        {
            if (chk_luuketnoi.Checked == false)
            {
                LopHoTro.CAUHINHREGISTRY REG = new ThietBiPY.LopHoTro.CAUHINHREGISTRY();
                REG.datkhoa("Server", "");
                REG.datkhoa("Database", "");
                REG.datkhoa("User ID", "");
                REG.datkhoa("Password", "");
            }
        }
    }
}
