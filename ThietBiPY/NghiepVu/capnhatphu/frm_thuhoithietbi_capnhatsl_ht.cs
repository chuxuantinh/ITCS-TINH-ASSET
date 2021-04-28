using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Net.SourceForge.Vietpad.InputMethod;

namespace ThietBiPY.NghiepVu.capnhatphu
{
    public partial class frm_thuhoithietbi_capnhatsl_ht : DevComponents.DotNetBar.Office2007Form
    {
        public frm_thuhoithietbi_capnhatsl_ht()
        {
            InitializeComponent();
        }
        public frm_thuhoithietbi_capnhatsl_ht(string soluong,string hientrang)
        {
            InitializeComponent();
            input_soluong.Value = int.Parse(soluong);
            txt_hientrang.Text = hientrang;
        }

        //
        public delegate void passData(string soluong, string hientrang);
        public passData DuLieu;
        public void guidulieu(string soluong, string hientrang)
        {
            if (DuLieu != null) DuLieu(soluong, hientrang);
        }

        //
        private void btn_luulai_Click(object sender, EventArgs e)
        {
            guidulieu(input_soluong.Value.ToString(), txt_hientrang.Text);
            this.Close();
        }

        private void frm_thuhoithietbi_capnhatsl_ht_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F8:
                    btn_luulai_Click(null, null);
                    break;
                case Keys.Escape :
                    this.Close();
                    break;
            }
        }
        private void frm_thuhoithietbi_capnhatsl_ht_Load(object sender, EventArgs e)
        {
            txt_hientrang.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_hientrang).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
    }
}
