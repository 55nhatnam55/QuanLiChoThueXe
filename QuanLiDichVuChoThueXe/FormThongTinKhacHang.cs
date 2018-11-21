using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace QuanLiDichVuChoThueXe
{
    public partial class FormThongTinKhacHang : DevExpress.XtraEditors.XtraForm
    {
        private QL_ThuexeotoEntities connectdb = new QL_ThuexeotoEntities();
        public FormThongTinKhacHang()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string makh = gridKH.CurrentRow.Cells[0].Value.ToString();
                tbl_PHIEUTHUE pt = new tbl_PHIEUTHUE();
                pt = connectdb.tbl_PHIEUTHUE.FirstOrDefault(p => p.MaKH == makh);
                if(pt!=null)
                {
                    connectdb.tbl_PHIEUTHUE.Remove(pt);    
                }
                tbl_KHACHHANG kh = new tbl_KHACHHANG();
                kh = connectdb.tbl_KHACHHANG.Single(p => p.MaKH == makh);
                connectdb.tbl_KHACHHANG.Remove(kh);
                connectdb.SaveChanges();
                load();
                MessageBox.Show("Xóa thành công!");

            }
            else
            {
                MessageBox.Show("Xóa thất bại!");

            }
        }

        private void FormThongTinKhacHang_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            var query = from nv in connectdb.tbl_KHACHHANG
                        select nv;//Where(p => p.TenXe.Contains(b.Trim()));
            gridKH.DataSource = query.ToList();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtBanglai.Text = "";
            txtCMND.Text = "";
            txtSDT.Text = "";
            txtTenKH.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow row = gridKH.Rows[gridKH.Rows.Count - 1];
                string MaKHold = row.Cells[0].Value.ToString().Trim();
                int newint = int.Parse(MaKHold.Substring(3));
                newint = newint + 1;
                tbl_KHACHHANG kh = new tbl_KHACHHANG();
                kh.MaKH = "KH" + newint.ToString();
                kh.BangLai = txtBanglai.Text.Trim();
                kh.CMND = txtCMND.Text.Trim();
                kh.SDT = txtSDT.Text.Trim();
                kh.TenKH = txtTenKH.Text.Trim();
                if (kh.BangLai == "" || kh.CMND == "" || kh.TenKH == "" || kh.SDT == "")
                {
                    MessageBox.Show("Không bỏ trống các thông tin");
                }
                connectdb.tbl_KHACHHANG.Add(kh);
                connectdb.SaveChanges();
                load();
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");

            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string Makh = gridKH.CurrentRow.Cells[0].Value.ToString();
                tbl_KHACHHANG kh = connectdb.tbl_KHACHHANG.Single(p => p.MaKH == Makh);
                kh.BangLai = txtBanglai.Text.Trim();
                kh.CMND = txtCMND.Text.Trim();
                kh.SDT = txtSDT.Text.Trim();
                kh.TenKH = txtTenKH.Text.Trim();
                if (kh.BangLai == "" || kh.CMND == "" || kh.TenKH == "" || kh.SDT == "")
                {
                    MessageBox.Show("Không bỏ trống các thông tin");
                }
                connectdb.SaveChanges();
                MessageBox.Show("Sửa thành công");
                load();
            }
            catch
            {
                MessageBox.Show("Không sửa được!!!");
            }
        }

        private void gridKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridKH.Rows[e.RowIndex];
                txtBanglai.Text = row.Cells["BangLai"].Value.ToString();
                txtCMND.Text = row.Cells["CMND"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
            }
        }

        private void gridKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
