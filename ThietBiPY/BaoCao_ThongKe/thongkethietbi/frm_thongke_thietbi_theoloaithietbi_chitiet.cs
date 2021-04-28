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

namespace ThietBiPY.BaoCao_ThongKe.thongkethietbi
{
    public partial class frm_thongke_thietbi_theoloaithietbi_chitiet : DevComponents.DotNetBar.Office2007Form 
    {
        public frm_thongke_thietbi_theoloaithietbi_chitiet()
        {
            InitializeComponent();
            lv_thietbi.Columns.Add("STT", 50,HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Số hiệu", 100);
            lv_thietbi.Columns.Add("Tên thiết bị", 400);
            lv_thietbi.Columns.Add("Nước sản xuất", 150);
        }

        //
        string LoaiTBID = "";
        public frm_thongke_thietbi_theoloaithietbi_chitiet(string LoaiTBID)
        {
            InitializeComponent();
            this.LoaiTBID = LoaiTBID;
            lv_thietbi.Columns.Add("STT", 50,HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Số hiệu", 100);
            lv_thietbi.Columns.Add("Tên thiết bị", 400);
            lv_thietbi.Columns.Add("Nước sản xuất", 150);

            var LTB = new LOAITHIETBI_BLL().loaithietbi_danhsach().Single(c => c.LoaiTBID == int.Parse(LoaiTBID));
            this.Text = "Loại thiết bị: " + LTB.TenLoaiTB;
            danhsach_thietbi_theoloaithietbi();
        }
        
        //
        public void danhsach_thietbi_theoloaithietbi()
        {
            var LST_THIETBI = new THIETBI_BLL().thietbi_danhsach().Where(c => c.LoaiTBID == int.Parse(LoaiTBID)).ToList();

            lv_thietbi.Items.Clear();
            if (LST_THIETBI.Count > 0)
            {
                ListViewItem item = null;
                int dem = 0;
                foreach (var TB in LST_THIETBI)
                {
                    dem++;
                    item = new ListViewItem(dem.ToString());
                    item.Tag = TB.ThietBiID.ToString();
                    lv_thietbi.Items.Add(item);
                    item.SubItems.Add(TB.SoHieu);
                    item.SubItems.Add(TB.TenThietBi);
                    item.SubItems.Add(TB.NuocSX != 0 ? TB.NUOC.TenNuoc : "Chưa xác định");

                    for (int cot = 0; cot < lv_thietbi.Columns.Count; cot++)
                    {
                        if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                    }
                }
            }
        }
    }

}
