using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThietBiPY.LopHoTro;

namespace ThietBiPY.NghiepVu.capnhatphu
{
    public partial class frm_thanhlythietbi_capnhat_gt : DevComponents.DotNetBar.Office2007Form 
    {
        public frm_thanhlythietbi_capnhat_gt()
        {
            InitializeComponent();
        }

        public frm_thanhlythietbi_capnhat_gt( string dongia)
        {
            InitializeComponent();
            txt_dongia.Text = string.Format("{0:0,0}",decimal.Parse (dongia));
        }
        
        //
        public delegate void passData(string dongia);
        public passData DuLieu;
        public void guidulieu(string dongia)
        {
            if(DuLieu !=null)DuLieu (dongia );
        }

        //
        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            if (txt_dongia.Text == "")
            {
                txt_dongia.Focus();
                DevComponents.DotNetBar.MessageBoxEx.Show("Chưa nhập đơn giá", "Chú ý", MessageBoxButtons.OK);
            }
            else
            {
                guidulieu(txt_dongia.Text.Replace(",", "").Replace(".", "").Replace(" ", "").Trim());
                this.Close();
            }
        }
        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        private void frm_giaonhanthietbi_capnhatsl_dg_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: btn_dong_Click(null, null); break;
            }
        }
        private void txt_dongia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CHUYENKIEU objConvert = new CHUYENKIEU();
                lbl_dongia.Text = string.Format("({0})", objConvert.DecimalToString(decimal.Parse(txt_dongia.Text.Replace(",", "").Replace(".", "").Replace(" ", "").Trim())));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
