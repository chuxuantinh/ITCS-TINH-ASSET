using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThietBiBLL;
using System.IO;

using ThietBiDAL;

namespace ThietBiPY.HeThong
{
    public partial class frm_saoluu_phuchoi_CSDL : DevComponents.DotNetBar.Office2007Form
    {
        string yeucau = "";
        HETHONGBLL HETHONG = new HETHONGBLL();

        public frm_saoluu_phuchoi_CSDL()
        {
            InitializeComponent();
        }

        public frm_saoluu_phuchoi_CSDL(string yeucau)
        {
            InitializeComponent();
            this.yeucau = yeucau;

            switch (yeucau)
            {
                case "saoluu":
                    btn_thuchien.Text = "Sao lưu";
                    lbl_tieude.Text = "Sao lưu dữ liệu";
                    break;
                case "phuchoi":
                    btn_thuchien.Text = "Phục hồi";
                    lbl_tieude.Text = "Phục hồi dữ liệu";
                    break;
            }
        }

        private void btn_chonduongdan_Click(object sender, EventArgs e)
        {
            switch (yeucau)
            {
                case "saoluu":
                    SaveFileDialog sdiag = new SaveFileDialog();
                    sdiag.Title = "Chọn vị trí lưu CSDL";
                    sdiag.Filter = "Tệp tin BAK|*.bak";
                    sdiag.InitialDirectory = Application.StartupPath + "\\SaoLuu\\";
                    sdiag.FileName = new HETHONGBLL().TenCSDL() + DateTime.Now.ToString("ddMMyyyy");
                    if (sdiag.ShowDialog() == DialogResult.OK)
                    {
                        txt_duongdan.Text = sdiag.FileName.Trim();
                    }
                    break;
                case "phuchoi":
                    OpenFileDialog odiag = new OpenFileDialog();
                    odiag.Title = "Chọn vị trí CSDL";
                    odiag.Filter = "Tệp tin BAK|*.bak|Tất cả |*.*";
                    if (odiag.ShowDialog() == DialogResult.OK) txt_duongdan.Text = odiag.FileName;
                    break;
            }
        }


        private void btn_thuchien_Click(object sender, EventArgs e)
        {
            if (txt_duongdan.Text != "")
            {
                DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
                if (btn_thuchien.Text == "Sao lưu")
                {
                    this.Cursor = Cursors.WaitCursor;
                    HETHONG.SaoLuu(HETHONG.TenServer(), HETHONG.TenCSDL(), HETHONG.LayUSerID(), HETHONG.LayPwd(), txt_duongdan.Text);

                    DevComponents.DotNetBar.MessageBoxEx.Show("Sao lưu thành công", "Thông báo");
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    this.Cursor = Cursors.WaitCursor;
                    HETHONG.PhucHoi(HETHONG.TenServer(), HETHONG.TenCSDL(), HETHONG.LayUSerID(), HETHONG.LayPwd(), txt_duongdan.Text);
                    DevComponents.DotNetBar.MessageBoxEx.Show("Đã phục hồi", "Thông báo");
                    this.Cursor = Cursors.Default;
                    this.Dispose();
                }
            }
        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
