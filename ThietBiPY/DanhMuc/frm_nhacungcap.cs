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
using Net.SourceForge.Vietpad.InputMethod;
using ThietBiPY.LopHoTro;

namespace ThietBiPY.DanhMuc
{
    public partial class frm_nhacungcap : DevComponents.DotNetBar.Office2007Form 
    {
        public frm_nhacungcap()
        {
            InitializeComponent();
            lv_nhacungcap.DoubleClick += new EventHandler(lv_nhacungcap_DoubleClick);
            lv_nhacungcap.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(lv_nhacungcap_ItemSelectionChanged);
            btn_dieukhien_lamtuoi.Click += new EventHandler(btn_dieukhien_lamtuoi_Click);
            btn_dieukhien_themmoi.Click += new EventHandler(btn_dieukhien_themmoi_Click);
            btn_dieukhien_hieuchinh.Click += new EventHandler(btn_dieukhien_hieuchinh_Click);
            btn_dieukhien_xoa.Click += new EventHandler(btn_dieukhien_xoa_Click);
            txt_nhacungcap.TextChanged += new EventHandler(txt_nhacungcap_TextChanged);

            lv_nhacungcap.Columns.Add("STT", 40, HorizontalAlignment.Center);
            lv_nhacungcap.Columns.Add("Tên NCC", 200);
            lv_nhacungcap.Columns.Add("Họ tên người LH", 250);
            lv_nhacungcap.Columns.Add("Tỉnh/TP", 200);
            lv_nhacungcap.Columns.Add("Email");

            danhsach_nhacungcap(new NHACUNGCAP_BLL().nhacungcap_danhsach().ToList());
        }

        #region "Hàm xử lý"
        //
        public void thongke()
        {
            txt_thongke.Text = "Tổng số: " + lv_nhacungcap.Items.Count.ToString();
        }
        public void danhsach_nhacungcap(List<NHACUNGCAP> LST)
        {
            lv_nhacungcap.Items.Clear();
            if (LST.Count > 0)
            {
                ListViewItem item = null;
                int dem = 0;
                foreach (var NCC in LST)
                {
                    dem++;
                    item = new ListViewItem (dem.ToString ());
                    item.Tag = NCC.NCCID .ToString ();
                    lv_nhacungcap.Items.Add (item);
                    item.SubItems.Add (NCC.TenNCC );
                    item.SubItems.Add(NCC.HoNguoiLH + " " + NCC.TenNguoiLH);
                    item.SubItems.Add(NCC.TINH != null ? NCC.TINH.TenTinh : "Chưa xác định");
                    item.SubItems.Add(NCC.Email);

                    for (int cot = 0; cot < lv_nhacungcap.Columns.Count; cot++)
                    {
                        if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                    }
                }
            }
            thongke();
        }
        public void nhandulieu(string giatri)
        {
            if (giatri != null || giatri != "")
            {
                danhsach_nhacungcap(new NHACUNGCAP_BLL().nhacungcap_danhsach().ToList());
            }
        }
        public void bangdieukhien(int tt)
        {
            frm_nhacungcap_capnhat frm = null;
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            switch (tt)
            {
                case (int)DIEUKHIEN.them:
                    frm = new frm_nhacungcap_capnhat();
                    frm.DuLieu = new frm_nhacungcap_capnhat.passData(nhandulieu);
                    frm.ShowDialog();
                    break;

                case (int)DIEUKHIEN.sua :
                    if (lv_nhacungcap.SelectedItems.Count > 0)
                    {
                        frm = new frm_nhacungcap_capnhat(lv_nhacungcap.SelectedItems[0].Tag.ToString());
                        frm.DuLieu = new frm_nhacungcap_capnhat.passData(nhandulieu);
                        frm.ShowDialog();
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần hiệu chỉnh!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case (int)DIEUKHIEN.xoa :
                    if (lv_nhacungcap.SelectedItems.Count > 0)
                    {
                        if (DevComponents.DotNetBar.MessageBoxEx.Show("Xóa dòng đang chọn!", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            if (new NHACUNGCAP_BLL().nhacungcap_xoa(lv_nhacungcap.SelectedItems[0].Tag.ToString()) > 0)
                            {
                                lv_nhacungcap.Items.Remove(lv_nhacungcap.SelectedItems[0]);
                            }
                        }
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case (int)DIEUKHIEN.lamtuoi :
                    danhsach_nhacungcap(new NHACUNGCAP_BLL().nhacungcap_danhsach().ToList());
                    break;
            }
            thongke();
        }

        //
        #endregion

        #region "Sự kiện"
        private void frm_nhacungcap_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5: btn_dieukhien_lamtuoi_Click(null, null); break;
                case Keys.F6: btn_dieukhien_themmoi_Click(null, null); break;
                case Keys.F7: btn_dieukhien_hieuchinh_Click(null, null); break;
                case Keys.Delete: btn_dieukhien_xoa_Click(null, null); break;
                case Keys.Escape: this.Close(); break;
            }
        }
        //
        private void btn_dieukhien_lamtuoi_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)DIEUKHIEN.lamtuoi);
        }
        private void btn_dieukhien_themmoi_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)DIEUKHIEN.them);
        }
        private void btn_dieukhien_hieuchinh_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)DIEUKHIEN.sua);
        }
        private void btn_dieukhien_xoa_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)DIEUKHIEN.xoa);
        }

        private void txt_nhacungcap_TextChanged(object sender, EventArgs e)
        {
            if (txt_nhacungcap.Text != "")
            {
                danhsach_nhacungcap(new NHACUNGCAP_BLL().nhacungcap_danhsach().Where(c => c.TenNCC.ToUpper().Contains(txt_nhacungcap.Text.ToUpper())).ToList());
            }
            else danhsach_nhacungcap(new NHACUNGCAP_BLL().nhacungcap_danhsach().ToList());
        }
        private void lv_nhacungcap_DoubleClick(object sender, EventArgs e)
        {
            btn_dieukhien_hieuchinh_Click(null, null);
        }

        private void lv_nhacungcap_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_nhacungcap.SelectedItems.Count > 0)
            {
                var CT = new NHACUNGCAP_BLL().nhacungcap_thongtin(lv_nhacungcap.SelectedItems[0].Tag.ToString());
                string chitiet = "";
                chitiet += "Tên NCC: " + CT.TenNCC + Environment.NewLine;
                chitiet += "Người liên hệ: " + CT.HoNguoiLH + " " + CT.TenNguoiLH + Environment.NewLine;
                chitiet += "Chức vụ: " + CT.ChucVu + Environment.NewLine;
                chitiet += "Địa chỉ: " + CT.DiaChi + Environment.NewLine;
                chitiet += "Điện thoại: " + CT.DienThoai + Environment.NewLine;
                chitiet += "Email: " + CT.Email + Environment.NewLine;
                chitiet += "Website: " + CT.Website + Environment.NewLine;
                chitiet += "Ghi chú: " + CT.GhiChu + Environment.NewLine;

                rtb_chitiet.Text = chitiet;
                expandableSplitter1.Expanded = true;
                lv_nhacungcap.ContextMenuStrip = contextMenuStrip1;
            }
            else { lv_nhacungcap.ContextMenuStrip = null; rtb_chitiet.Text = ""; expandableSplitter1.Expanded = false; }
        }

        private void frm_nhacungcap_Load(object sender, EventArgs e)
        {
            txt_nhacungcap.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_nhacungcap).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }

        private void context_menu_hieuchinh_Click(object sender, EventArgs e)
        {
            btn_dieukhien_hieuchinh_Click(null, null);
        }
        private void context_meu_xoadong_Click(object sender, EventArgs e)
        {
            btn_dieukhien_xoa_Click(null, null);
        }

        private void btn_dieukhien_xoa_Click_1(object sender, EventArgs e)
        {

        }

       
        //
        #endregion
    }
}
