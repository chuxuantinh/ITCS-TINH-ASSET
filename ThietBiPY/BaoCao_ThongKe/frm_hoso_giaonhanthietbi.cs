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
using ThietBiPY.BaoCao_ThongKe.report;

namespace ThietBiPY.BaoCao_ThongKe
{
    public partial class frm_hoso_giaonhanthietbi : DevComponents.DotNetBar.Office2007Form 
    {
        List<PHIEUNHAP> LST_PHIEUNHAP = new List<PHIEUNHAP>();

        int kieunhap = 0, DonViID = 0;

        public frm_hoso_giaonhanthietbi()
        {
            InitializeComponent();
        }
        public frm_hoso_giaonhanthietbi(int kieu)
        {
            InitializeComponent();
            kieunhap = kieu;

            switch (kieu)
            {
                case (int)LopHoTro.KIEUPHIEUNHAP.tunhacungcap:
                    this.Name = "frm_hoso_giaonhan_tunhacungcap";
                    this.Text = "Hồ sơ chứng từ giao nhận từ nhà cung cấp";

                    lv_giaonhanthietbi.Columns.Add("STT", 40, HorizontalAlignment.Center);
                    lv_giaonhanthietbi.Columns.Add("Ngày văn bản", 100);
                    lv_giaonhanthietbi.Columns.Add("Số văn bản", 200);
                    lv_giaonhanthietbi.Columns.Add("Nhà cung cấp", 300);
                    lv_giaonhanthietbi.Columns.Add("Số lượng nhập", 100, HorizontalAlignment.Center);

                    break;

                case (int)LopHoTro.KIEUPHIEUNHAP.tunguonkhac:
                    this.Name = "frm_hoso_giaonhan_tunguonkhac";
                    this.Text = "Hồ sơ chứng từ giao nhận từ nguồn khác";

                    lv_giaonhanthietbi.Columns.Add("STT", 40, HorizontalAlignment.Center);
                    lv_giaonhanthietbi.Columns.Add("Ngày nhập", 100);
                    lv_giaonhanthietbi.Columns.Add("Đơn vị", 200);
                    lv_giaonhanthietbi.Columns.Add("Bộ phận", 300);
                    lv_giaonhanthietbi.Columns.Add("Số lượng nhập", 100, HorizontalAlignment.Center);

                    break;
            }

            danhsach_giaonhanthietbi();
            danhsach_namnhapthietbi();
            cbo_namnhapthietbi_SelectValueChanged(null, null);
        }

        //
        #region "Hàm xử lý"
        public void danhsach_namnhapthietbi()
        {
            int NamGiaoNhan =(cbo_namgiaonhan.Text!=""? int.Parse(cbo_namgiaonhan.Text.Trim()):0);

            if (DonViID == 0)
            {
                var NAM_GN_TC = new PHIEUNHAP_BLL().phieunhap_danhsach().Where(c => (kieunhap == (int)LopHoTro.KIEUPHIEUNHAP.tunhacungcap ? c.NCCID != 0 : c.NCCID == 0)).OrderByDescending(c => c.NgayNhap.Value.Year).Select(c => c.NgayNhap.Value.Year).Distinct().ToList();
                cbo_namgiaonhan.DataSource = NAM_GN_TC;
            }
            else
            {
                var NAM_GN_DV = new PHIEUNHAP_BLL().phieunhap_danhsach().Where(c =>(c.DonViNhan==DonViID)&& (kieunhap == (int)LopHoTro.KIEUPHIEUNHAP.tunhacungcap ? c.NCCID != 0 : c.NCCID == 0)).OrderByDescending(c => c.NgayNhap.Value.Year).Select(c => c.NgayNhap.Value.Year).Distinct().ToList();
                cbo_namgiaonhan.DataSource = NAM_GN_DV;
                if (NAM_GN_DV.Contains(NamGiaoNhan)) cbo_namgiaonhan.Text = NamGiaoNhan.ToString();
            }
            
            cbo_namgiaonhan.SelectedValueChanged += new EventHandler(cbo_namnhapthietbi_SelectValueChanged);
        }
        public void danhsach_giaonhanthietbi()
        {
            LST_PHIEUNHAP = new PHIEUNHAP_BLL().phieunhap_danhsach().Where(c=>(kieunhap==(int)LopHoTro.KIEUPHIEUNHAP.tunhacungcap?c.NCCID!=0:c.NCCID==0)).OrderByDescending (c=>c.NgayNhap.Value).ToList();

            if (cbo_namgiaonhan.SelectedIndex >= 0)
            {
                LST_PHIEUNHAP = LST_PHIEUNHAP.Where(c => c.NgayNhap.Value.Year == int.Parse(cbo_namgiaonhan.Text.Trim())).ToList();
            }
            if (DonViID != 0) LST_PHIEUNHAP = LST_PHIEUNHAP.Where(c => c.DonViNhan == DonViID).ToList();
            
            //
            lv_giaonhanthietbi.Items.Clear();
            if (LST_PHIEUNHAP.Count > 0)
            {
                ListViewItem item = null;
                int dem = 0;

                if (kieunhap == (int)LopHoTro.KIEUPHIEUNHAP.tunhacungcap)
                {
                    foreach (var GN in LST_PHIEUNHAP)
                    {
                        dem++;
                        item = new ListViewItem(dem.ToString());
                        item.Tag = GN.PhieuNhapID.ToString();
                        lv_giaonhanthietbi.Items.Add(item);
                        item.SubItems.Add(GN.NgayNhap.Value.Date.ToString("dd/MM/yyyy"));
                        item.SubItems.Add(GN.SoVanBan);
                        item.SubItems.Add(GN.NHACUNGCAP.TenNCC);
                        item.SubItems.Add(new CTPHIEUNHAP_BLL().ctphieunhap_danhsach().Where(c => c.PhieuNhapID == GN.PhieuNhapID).Sum(c => c.SoLuong).ToString());

                        for (int cot = 0; cot < lv_giaonhanthietbi.Columns.Count; cot++)
                        {
                            if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                            item.SubItems[0].BackColor = Color.WhiteSmoke;
                        }
                    }
                }
                else
                {
                    foreach (var GN in LST_PHIEUNHAP)
                    {
                        dem++;
                        item = new ListViewItem(dem.ToString());
                        item.Tag = GN.PhieuNhapID.ToString();
                        lv_giaonhanthietbi.Items.Add(item);
                        item.SubItems.Add(GN.NgayNhap.Value.Date.ToString("dd/MM/yyyy"));
                        item.SubItems.Add(GN.DonViNhan != 0 ? GN.DONVI.TenDonVi : "");
                        item.SubItems.Add(GN.BoPhanNhan != 0 ? GN.BOPHAN.TenBoPhan : "");

                        item.SubItems.Add(new CTPHIEUNHAP_BLL().ctphieunhap_danhsach().Where(c => c.PhieuNhapID == GN.PhieuNhapID).Sum(c => c.SoLuong).ToString());

                        for (int cot = 0; cot < lv_giaonhanthietbi.Columns.Count; cot++)
                        {
                            if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                            item.SubItems[0].BackColor = Color.WhiteSmoke;
                        }
                    }
                }
            }
            lbl_thongke.Text = "Số lượng: " + lv_giaonhanthietbi.Items.Count.ToString();
        }

        //
        public void bangdieukhien(int tt)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            List<PHIEUNHAP> LST_INPHIEUNHAP = new List<PHIEUNHAP>();
            switch (tt)
            {
                case (int)LopHoTro.DIEUKHIEN.invanban:
                    if (lv_giaonhanthietbi.SelectedItems.Count > 0)
                    {
                        frm_bienban_giaonhanthietbi frm = new frm_bienban_giaonhanthietbi(lv_giaonhanthietbi.SelectedItems[0].Tag.ToString());
                        frm.WindowState = FormWindowState.Maximized;
                        frm.ShowDialog();
                    }
                    break;

                case (int)LopHoTro.DIEUKHIEN.xoa :
                    if (lv_giaonhanthietbi.SelectedItems.Count > 0)
                    {
                        if (DevComponents.DotNetBar.MessageBoxEx.Show("Xóa dòng đang chọn?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            if (new PHIEUNHAP_BLL().phieunhap_xoa(lv_giaonhanthietbi.SelectedItems[0].Tag.ToString()) > 0)
                            {
                                lv_giaonhanthietbi.Items.Remove(lv_giaonhanthietbi.SelectedItems[0]);
                                lbl_thongke.Text = "Số lượng: " + lv_giaonhanthietbi.Items.Count.ToString();
                            }
                        }
                    }
                    break;
                case (int)LopHoTro.DIEUKHIEN.lamtuoi :
                    danhsach_namnhapthietbi();
                    break;
            }
        }
        public void nhandulieu(string giatri)
        {
            if (giatri != null)
            {
                var PN = new PHIEUNHAP_BLL().phieunhap_thongtin(giatri).NgayNhap.Value.Year;
                cbo_namgiaonhan.SelectedText = PN.ToString();
                cbo_namnhapthietbi_SelectValueChanged(null, null);
            }
        }
        #endregion

        #region "Sự kiện"
        //
        private void cbo_namnhapthietbi_SelectValueChanged(object sender, EventArgs e)
        {
            danhsach_giaonhanthietbi();
        }
        private void btn_lamtuoi_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.lamtuoi);
        }
        private void btn_invanban_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.invanban);
        }
        private void btn_hieuchinh_Click(object sender, EventArgs e)
        {
            if (lv_giaonhanthietbi.SelectedItems.Count > 0)
            {
                NghiepVu.frm_giaonhanthietbi_capnhat frm = new ThietBiPY.NghiepVu.frm_giaonhanthietbi_capnhat(lv_giaonhanthietbi.SelectedItems[0].Tag.ToString());
                frm.DuLieu = new ThietBiPY.NghiepVu.frm_giaonhanthietbi_capnhat.passData(nhandulieu);
                frm.ShowDialog();
            }
        }
        private void btn_xoadong_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.xoa);
        }

        //
        private void frm_hoso_giaonhanthietbi_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: this.Close(); break;
                case Keys.Delete: btn_xoadong_Click(null, null); break;
                case Keys.F5: btn_lamtuoi_Click(null, null); break;
            }
        }
        
        private void lv_giaonhanthietbi_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_giaonhanthietbi.SelectedItems.Count > 0)
            {
                lv_giaonhanthietbi.ContextMenuStrip = contextmenu_bangdieukhien;
            }
            else lv_giaonhanthietbi.ContextMenuStrip = null;
        }
        private void lv_giaonhanthietbi_DoubleClick(object sender, EventArgs e)
        {
            btn_hieuchinh_Click(null, null);
        }
        private void lv_giaonhanthietbi_KeyDown(object sender, KeyEventArgs e)
        {
            if (lv_giaonhanthietbi.SelectedItems.Count > 0)
            {
                switch (e.KeyCode)
                {
                    case Keys.F7: btn_hieuchinh_Click(null, null); break;
                    case Keys.Delete: btn_xoadong_Click(null, null); break;
                    case Keys.F11: btn_invanban_Click(null, null); break;
                }
            }
        }
        #endregion

        #region "ContextMenu"
        private void contextmenu_bangdieukhien_inhoso_Click(object sender, EventArgs e)
        {
            btn_invanban_Click(null, null);
        }
        private void contextmenu_bangdieukhien_hieuchinh_Click(object sender, EventArgs e)
        {
            btn_hieuchinh_Click(null, null);
        }
        private void contextmenu_bangdieukhien_xoadong_Click(object sender, EventArgs e)
        {
            btn_xoadong_Click(null, null);
        }
        #endregion

        private void btn_chondonvi_Click(object sender, EventArgs e)
        {
            string giatri = "";
            if (new HOPCHON_DONVIGIAONHAN().InputBox("", "Chọn đơn vị", ref giatri) == DialogResult.OK)
            {
                DonViID = int.Parse(giatri);
                danhsach_namnhapthietbi();
                cbo_namnhapthietbi_SelectValueChanged(null, null);
            }
        }
    }

    //
    public class HOPCHON_DONVIGIAONHAN
    {
        public DialogResult InputBox(string title, string promptText, ref string value)
        {
            //Form form = new Form();

            DevComponents.DotNetBar.Office2007Form form = new DevComponents.DotNetBar.Office2007Form();
            DevComponents.DotNetBar.LabelX label = new DevComponents.DotNetBar.LabelX();

            DevComponents.DotNetBar.Controls.ComboBoxEx combo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            DevComponents.DotNetBar.ButtonX buttonOk = new DevComponents.DotNetBar.ButtonX();
            DevComponents.DotNetBar.ButtonX buttonCancel = new DevComponents.DotNetBar.ButtonX();

            form.EnableGlass = false;
            form.Text = title;
            label.Text = promptText;
            //combo.SelectedValue = int.Parse(value);

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            combo.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            combo.Anchor = combo.Anchor | AnchorStyles.Right;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;

            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, combo, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            var LST_DV = new PHIEUNHAP_BLL().phieunhap_danhsach().Select(c => new
            {
                DonViID = c.DonViNhan,
                TenDonVi = c.DONVI.TenDonVi,
            }).Distinct().OrderBy(c => c.TenDonVi).ToList();
            LST_DV.Add(new { DonViID = 0, TenDonVi = "Tất cả" });

            combo.DataSource = LST_DV;

            combo.DisplayMember = "TenDonVi";
            combo.ValueMember = "DonViID";

            DialogResult dialogResult = form.ShowDialog();
            value = combo.SelectedValue.ToString();
            return dialogResult;
        }
    }
    //
}
//Bùi Thành Nhân - 13/06/2011 : Xử lý nghiệp vụ giao nhận thiết bị