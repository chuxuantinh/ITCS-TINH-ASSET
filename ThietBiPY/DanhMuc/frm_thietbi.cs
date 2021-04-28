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

namespace ThietBiPY.DanhMuc
{
    public partial class frm_thietbi : DevComponents.DotNetBar .Office2007Form 
    {
        public frm_thietbi()
        {
            InitializeComponent();
            dockContainerItem1.Text = "Chi tiết";

            lv_thietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Thiết bị", 200);
            lv_thietbi.Columns.Add("Số hiệu", 100);
            lv_thietbi.Columns.Add("Đơn vị tính", 80,HorizontalAlignment.Center);

            lv_thietbi.Columns.Add("Nước SX", 100);
            lv_thietbi.Columns.Add("Năm SX", 80);
            lv_thietbi.Columns.Add("Tài liệu đính kèm", 100,HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Mô tả thêm", 200);

            danhmuc_loaithietbi("");
            txt_tenthietbi.TextChanged += new EventHandler(txt_tenthietbi_TextChanged);
        }

        //
        private void cbo_loaithietbi_SelectIndex_Changed(object sender, EventArgs e)
        {
            loc_danhsachthietbi();
        }
        private void txt_tenthietbi_TextChanged(object sender, EventArgs e)
        {
            loc_danhsachthietbi();
        }

        //Hàm xử lý
        public void nhandulieu(string giatri)
        {
            if (giatri != null)
            {
                danhmuc_loaithietbi(new THIETBI_BLL().thietbi_thongtin(giatri).LoaiTBID.ToString());
            }
        }
        public void thongke()
        {
            txt_thongke.Text = "Số lượng: " + lv_thietbi.Items.Count.ToString();
        }

        public void danhmuc_loaithietbi(string giatri)
        {
            BindingSource binding_loaithietbi = new BindingSource();
            binding_loaithietbi.DataSource = new LOAITHIETBI_BLL().loaithietbi_danhsach().Select(c => new
            {
                LoaiTBID = c.LoaiTBID,
                TenLoaiTB = c.TenLoaiTB,
                DienGiai = c.DienGiai,
                TenNhomTB = (c.NhomTBID != 0 ? c.NHOMTHIETBI.TenNhomTB : "Chưa xác định"),
            });
            binding_loaithietbi.Add(new
            {
                LoaiTBID = 0,
                TenLoaiTB = "Chưa xác định",
                DienGiai = "",
                TenNhomTB = "Chưa xác định",
            });
            cbo_loaithietbi.DataSource = binding_loaithietbi;
            cbo_loaithietbi.ValueMember = "LoaiTBID";
            cbo_loaithietbi.DisplayMembers = "TenLoaiTB";
            cbo_loaithietbi.GroupingMembers = "TenNhomTB";

            if (giatri == "") cbo_loaithietbi.SelectedIndex = 0;
            else cbo_loaithietbi.SelectedValue = int.Parse(giatri);

            cbo_loaithietbi.SelectedIndexChanged += new EventHandler(cbo_loaithietbi_SelectIndex_Changed);
            cbo_loaithietbi_SelectIndex_Changed(null, null);
        }
        public void hienthi_danhsachthietbi(List<THIETBI> LST)
        {
            lv_thietbi.Items.Clear();
            if (LST.Count > 0)
            {
                ListViewItem item = null;
                int dem = 0;

                foreach (var TB in LST)
                {
                    dem++;
                    item = new ListViewItem(dem.ToString());
                    item.Tag = TB.ThietBiID.ToString();
                    lv_thietbi.Items.Add(item);
                    item.SubItems.Add(TB.TenThietBi);
                    item.SubItems.Add(TB.SoHieu);
                    item.SubItems.Add(TB.DVTID != 0 ? TB.DONVITINH.TenDVT : "Chưa xác định");
                    item.SubItems.Add(TB.NuocSX != 0 ? TB.NUOC.TenNuoc : "Chưa xác định");
                    item.SubItems.Add(TB.NamSX != 0 ? TB.NamSX.ToString() : "Chưa xác định");
                    item.SubItems.Add(TB.TaiLieuKT != "" ? "Có" : "Không");

                    item.SubItems.Add(TB.MoTaThem != "" ? TB.MoTaThem : "[Chưa cập nhật]");

                    for (int cot = 0; cot < lv_thietbi.Columns.Count; cot++)
                    {
                        if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                        item.SubItems[0].Font = new System.Drawing.Font("Times New Roman", 10, System.Drawing.FontStyle.Bold);
                        if (item.SubItems[6].Text == "Không")
                        {
                            item.SubItems[6].BackColor = Color.Tomato;
                        }
                        else
                        {
                            item.SubItems[6].ForeColor = Color.Blue;
                            item.SubItems[6].BackColor = Color.White;
                        }
                    }
                }
            }
            thongke();
        }
        public void loc_danhsachthietbi()
        {
            var LST = new THIETBI_BLL().thietbi_danhsach().ToList();
            if (cbo_loaithietbi.SelectedIndex >= 0)
            {
                LST = LST.Where(c => c.LoaiTBID == (int)cbo_loaithietbi.SelectedValue).ToList();
            }
            if (txt_tenthietbi.Text != "")
            {
                LST = LST.Where(c => c.TenThietBi.ToUpper().Contains(txt_tenthietbi.Text.ToUpper())).ToList();
            }
            hienthi_danhsachthietbi(LST);
        }
        public void bangdieukhien(int tt)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            frm_thietbi_capnhat frm = null;
            switch (tt)
            {
                case (int)LopHoTro.DIEUKHIEN.them:
                    frm = new frm_thietbi_capnhat(cbo_loaithietbi.SelectedValue.ToString());
                    frm.DuLieu = new frm_thietbi_capnhat.passData(nhandulieu);
                    frm.ShowDialog();
                    break;

                case (int)LopHoTro.DIEUKHIEN.sua:
                    if (lv_thietbi.SelectedItems.Count > 0)
                    {
                        frm = new frm_thietbi_capnhat(lv_thietbi.SelectedItems[0].Tag.ToString(),cbo_loaithietbi.SelectedValue.ToString());
                        frm.DuLieu = new frm_thietbi_capnhat.passData(nhandulieu);
                        frm.ShowDialog();
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần hiệu chỉnh!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case (int)LopHoTro.DIEUKHIEN .xoa :
                    if (lv_thietbi.SelectedItems.Count > 0)
                    {
                        if (DevComponents.DotNetBar.MessageBoxEx.Show("Xóa dòng đang chọn!", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                                if (new THIETBI_BLL().thietbi_xoa(lv_thietbi.SelectedItems[0].Tag.ToString()) > 0)
                                {
                                    lv_thietbi.Items.Remove(lv_thietbi.SelectedItems[0]);
                                }
                                else
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show("Vui lòng kiểm tra lại trước khi xóa!", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                        }
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case (int)LopHoTro.DIEUKHIEN.lamtuoi :
                    int vitricu = (int)cbo_loaithietbi.SelectedValue;
                    txt_tenthietbi.Text = "";
                    danhmuc_loaithietbi(vitricu.ToString());
                    break;
            }
            thongke();
        }

        //
        private void btn_lamtuoi_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.lamtuoi);
        }
        private void btn_themthietbi_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.them);
        }
        private void btn_hieuchinh_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.sua);
        }
        private void btn_xoadong_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.xoa);
        }
        
        //
        private void frm_thietbi_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5: btn_lamtuoi_Click(null, null); break;
                case Keys.F6: btn_themthietbi_Click(null, null); break;
                case Keys.F7: btn_hieuchinh_Click(null, null); break;
                case Keys.Delete: btn_xoadong_Click(null, null); break;
                case Keys.Escape: this.Close(); break;
            }
        }
        private void frm_thietbi_Load(object sender, EventArgs e)
        {
            txt_tenthietbi.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_tenthietbi).OnKeyPress);
            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }

        //
        private void lv_thietbi_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            string chitiet = "";
            if (lv_thietbi.SelectedItems.Count > 0)
            {
                var TB = new THIETBI_BLL().thietbi_thongtin(lv_thietbi.SelectedItems[0].Tag.ToString());
                dockContainerItem1.Text = "Thiết bị: "+ TB.SoHieu;
                toolTip1.SetToolTip(pic_hinhanh, lv_thietbi.SelectedItems[0].SubItems[1].Text);
                lv_thietbi.ContextMenuStrip = contextmenu_thietbi;

                pic_hinhanh.Image = new LopHoTro.CHUYENKIEU().BinaryToImage(TB.HinhAnh);

                chitiet += " * Thiết bị: " + TB.TenThietBi + Environment.NewLine;
                chitiet += " * Thông tin:" + Environment.NewLine;
                chitiet += " * Hạn bảo hành: " + TB.HanBaoHanh.ToString() + " tháng" + Environment.NewLine;
                chitiet += " * Thông tin thêm: " + Environment.NewLine + (TB.MoTaThem!=""?TB.MoTaThem :"[Chưa cập nhật..]") + Environment.NewLine;
                chitiet += " * Thông số kỹ thuật: " + Environment.NewLine + (TB.ThongSoKT != "" ? TB.ThongSoKT : "[Chưa cập nhật..]");

                if (TB.TaiLieuKT != "")
                {
                    llbl_tailieudinhkem.Enabled = true;
                    llbl_tailieudinhkem.Click += new EventHandler(llbl_tailieudinhkem_Click);
                }
                else llbl_tailieudinhkem.Enabled = false;
                rtb_chitiet.Text = chitiet;
            }
            else
            {
                dockContainerItem1.Text = "Chi tiết";
                lv_thietbi.ContextMenuStrip = null;
                llbl_tailieudinhkem.Enabled = false;
                pic_hinhanh.Image = null;
                rtb_chitiet.Text = chitiet;
            }
        }
        private void lv_thietbi_DoubleClick(object sender, EventArgs e)
        {
            btn_hieuchinh_Click(null, null);
        }
        
        //
        private void llbl_tailieudinhkem_Click(object sender, EventArgs e)
        {
            try
            {
                var TB = new THIETBI_BLL().thietbi_thongtin(lv_thietbi.SelectedItems[0].Tag.ToString());
                if (System.IO.File.Exists(System.IO.Path.GetTempPath() + "\\" + TB.TaiLieuKT))
                {
                    System.IO.File.Delete(System.IO.Path.GetTempPath() + "\\" + TB.TaiLieuKT);
                }

                new LopHoTro.CHUYENKIEU().BinaryToFile(TB.NDTaiLieuKT, System.IO.Path.GetTempPath() + "\\" + TB.TaiLieuKT);
                System.Diagnostics.Process.Start(System.IO.Path.GetTempPath() + "\\" + TB.TaiLieuKT);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //
        private void contextmenu_thietbi_hieuchinh_Click(object sender, EventArgs e)
        {
            btn_hieuchinh_Click(null, null);
        }
        private void contextmenu_thietbi_xoadong_Click(object sender, EventArgs e)
        {
            btn_xoadong_Click(null, null);
        }

        //
    }
}
