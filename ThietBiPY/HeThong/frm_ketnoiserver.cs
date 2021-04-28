using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ThietBiBLL;
using ThietBiDAL;

namespace ThietBiPY.HeThong
{
    public partial class frm_ketnoiserver : DevComponents.DotNetBar.Office2007Form
    {
        public frm_ketnoiserver()
        {
            InitializeComponent();
            this.ShowIcon = true;
            this.ShowInTaskbar = true;

            cmbAuthentication.SelectedIndex = 0;
        }

        //
        private void cmbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAuthentication.SelectedIndex == 0)
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            string chuoiketnoi = "";
            if (cmbAuthentication.SelectedIndex == 0)
            {
                chuoiketnoi = "Server=" + cboServers.Text + ";Database=master" + ";Trusted_Connection=True;";
            }
            else chuoiketnoi = "Server=" + cboServers.Text + ";Database=master" + ";User ID=" + txtUsername.Text + ";Password=" + txtPassword.Text;

            if (new HETHONGBLL().KetNoi(chuoiketnoi) > 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else DevComponents.DotNetBar.MessageBoxEx.Show("Lỗi, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            /* List<string> DS_CSDL = new HETHONGBLL().DanhSachCSDL(cmbAuthentication.SelectedIndex,cboServers.Text, txtUsername.Text, txtPassword.Text);
           
             if (DS_CSDL.Count > 0)
             {
                 for (int i = 0; i < DS_CSDL.Count; i++)
                 {
                     if (DS_CSDL[i] == "ThietBiPY")
                     {
                         cmbDatabase.Items.Add(DS_CSDL[i]);
                         return;
                     }
                 }
                 cmbDatabase.SelectedIndex = 0;
                
                 DevComponents.DotNetBar.MessageBoxEx.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else DevComponents.DotNetBar.MessageBoxEx.Show("Lỗi, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            */
        }
        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDatabase.SelectedIndex >= 0)
            {
                btnOK.Enabled = true;
            }
        }
        
        //
        private void btnOK_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            LopHoTro.CAUHINHREGISTRY Reg = new ThietBiPY.LopHoTro.CAUHINHREGISTRY();
            LopHoTro.CHUYENKIEU MaHoa = new ThietBiPY.LopHoTro.CHUYENKIEU();


            HETHONGBLL HETHONG = new HETHONGBLL();
            string chuoiketnoi = "";
            if (cmbAuthentication.SelectedIndex == 0)
            {
                chuoiketnoi = "Server=" + cboServers.Text.ToUpper() + ";Database=" + cmbDatabase.Text + ";Trusted_Connection=True;";
            }
            else chuoiketnoi = "Server=" + cboServers.Text.ToUpper() + ";Database=" + cmbDatabase.Text + ";User ID=" + txtUsername.Text + ";Password=" + txtPassword.Text;
            int kn = HETHONG.KetNoi(chuoiketnoi);
            if (kn == 1)
            {
                HETHONGDAL.Server = cboServers.Text.ToUpper();
                HETHONGDAL.userName = txtUsername.Text;
                HETHONGDAL.passWord = txtPassword.Text;
                HETHONGDAL.dataBase = cmbDatabase.Text;

                Reg.datkhoa("Server", MaHoa.Mahoa2Mahoa(HETHONGDAL.Server));
                Reg.datkhoa("Database", MaHoa.Mahoa2Mahoa(HETHONGDAL.dataBase));
                Reg.datkhoa("User ID", MaHoa.Mahoa2Mahoa(HETHONGDAL.userName));
                Reg.datkhoa("Password", MaHoa.Mahoa2Mahoa(HETHONGDAL.passWord));

                frm_nguoidung frm = new frm_nguoidung("dangnhap");
                frm.Shown += new EventHandler(Dong_FormKetNoi);
                frm.Show();
            }
            else DevComponents.DotNetBar.MessageBoxEx.Show("Không truy xuất được CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void Dong_FormKetNoi(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_laydanhsachserver_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                //get all available SQL Servers				
                List<string> LST_SERVER = new List<string>();
                LST_SERVER = new HETHONGBLL().DanhSachServer();
                if (LST_SERVER.Count > 0)
                {
                    for (int i = 0; i < LST_SERVER.Count; i++)
                        cboServers.Items.Add(LST_SERVER[i]);
                }
                if (this.cboServers.Items.Count > 0)
                    this.cboServers.SelectedIndex = 0;
                else
                    this.cboServers.Text = "<No available SQL Servers>";

                this.Cursor = Cursors.Default;
            }
            catch (Exception err)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(err.Message, "Lỗi");
            }
        }
    }
}
