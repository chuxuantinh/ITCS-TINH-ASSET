using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ThietBiDAL;
using ThietBiBLL;

namespace ThietBiPY.DanhMuc.thongtinthietbi
{
    public partial class frm_tylehaomon_capnhat : DevComponents.DotNetBar.Office2007Form
    {
        string ID = "";
        public frm_tylehaomon_capnhat()
        {
            InitializeComponent();
            danhmuc_loaithietbi("");

        }
        public frm_tylehaomon_capnhat(string ID)
        {
            InitializeComponent();
            this.ID = ID;
            var HAOMON = new TYLEHAOMON_BLL().tylehaomon_thongtin(ID);
            danhmuc_loaithietbi(HAOMON.LoaiTBID.ToString());
            input_thoigiansudung.Value = (int)HAOMON.ThoiGianSD;
            dinput_tylehaomon.Value = (double)HAOMON.TLHaoMon;
        }

        #region "Hàm xử lý"
        //
        public delegate void passData(string giatri);
        public passData DuLieu;
        public void guidulieu(string giatri)
        {
            if (DuLieu != null) DuLieu(giatri);
        }

        //
        public void danhmuc_loaithietbi(string giatri)
        {
            BindingSource binding_source = new BindingSource();
            binding_source.DataSource = new LOAITHIETBI_BLL().loaithietbi_danhsach().Select(c => new
            {
                LoaiTBID = c.LoaiTBID,
                TenLoaiTB = c.TenLoaiTB,
                TenNhomTB = (c.NhomTBID != 0 ? c.NHOMTHIETBI.TenNhomTB : "Chưa xác định"),
            }).ToList();

            cbo_loaithietbi.DataSource = binding_source;
            cbo_loaithietbi.DisplayMembers = "TenLoaiTB";
            cbo_loaithietbi.GroupingMembers = "TenNhomTB";
            cbo_loaithietbi.ValueMember = "LoaiTBID";
            if (giatri != "") cbo_loaithietbi.SelectedValue = int.Parse(giatri);
            else cbo_loaithietbi.SelectedIndex = 0;
        }

        //
        public void xuly()
        {
            TYLEHAOMON_BLL HAOMON = new TYLEHAOMON_BLL();
            HAOMON.TYLEHAOMON_DTO.LoaiTBID = (int)cbo_loaithietbi.SelectedValue;
            HAOMON.TYLEHAOMON_DTO.ThoiGianSD = (Int16)input_thoigiansudung.Value;
            HAOMON.TYLEHAOMON_DTO.TLHaoMon = (float)dinput_tylehaomon.Value;

            if (ID == "")
            {
                if (HAOMON.tylehaomon_them() > 0)
                {
                    guidulieu(HAOMON.TYLEHAOMON_DTO.TyLeHaoMonID.ToString());
                    this.Close();
                }
            }
            else
            {
                if (HAOMON.tylehaomon_sua(ID) > 0)
                {
                    guidulieu(HAOMON.TYLEHAOMON_DTO.TyLeHaoMonID.ToString());
                    this.Close();
                }
            }
        }
        #endregion

        #region "Sự kiện"
        private void btn_luulai_Click(object sender, EventArgs e)
        {
            xuly();
        }
        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_tylehaomon_capnhat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F8: btn_luulai_Click(null, null); break;
                case Keys.Escape: btn_dong_Click(null, null); break;
            }
        }

        private void cbo_loaithietbi_Validated(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            if (ID == "")
            {
                if (new TYLEHAOMON_BLL().tylehaomon_ktloaithietbi(cbo_loaithietbi.SelectedValue.ToString()) == true)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Loại thiết bị này đã có tỷ lệ hao mòn!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbo_loaithietbi.Focus();
                }
            }
            else
            {
                if ((int)cbo_loaithietbi.SelectedValue != new TYLEHAOMON_BLL().tylehaomon_thongtin(ID).LoaiTBID)
                {
                    if (new TYLEHAOMON_BLL().tylehaomon_ktloaithietbi(cbo_loaithietbi.SelectedValue.ToString()) == true)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Loại thiết bị này đã có tỷ lệ hao mòn!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbo_loaithietbi.Focus();
                    }
                }
            }
        }
        private void btn_themloaithietbi_Click(object sender, EventArgs e)
        {
            frm_loaithietbi_capnhat frm = new frm_loaithietbi_capnhat();
            frm.DuLieu = new frm_loaithietbi_capnhat.passData(danhmuc_loaithietbi);
            frm.ShowDialog();
        }
        #endregion

    }
}
