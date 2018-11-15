using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiDichVuChoThueXe
{
    public partial class frmThongTinNguoiDung : Form
    {
        User_Login model = new User_Login();
        private int IDchucVu;
        private QL_ThuexeotoEntities connectdb = new QL_ThuexeotoEntities();

        public frmThongTinNguoiDung()
        {
            InitializeComponent();
        }

        private void cmbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadGrid();

        }

        private void frmThongTinNguoiDung_Load(object sender, EventArgs e)
        {

        }
        public void ReloadGrid()
        {
            if (cmbChucVu.SelectedIndex == 1)
            {
                IDchucVu = 1;
            }
            if (cmbChucVu.SelectedIndex == 0)
            {
                IDchucVu = 2;
            }

            var query = connectdb.User_Login.Where(p => p.ChucVu == IDchucVu)
                        .Select(x => new { x.id, x.TenNhanVien, x.Email, x.SDT, x.DiaChi, x.TenDn, x.Matkhau, x.Luong }).ToList();
            dgvQLNguoiDung.DataSource = query.ToList();
            dgvQLNguoiDung.Update();

        }
        private void btnXem_Click(object sender, EventArgs e)
        {

            //dgvQLNguoiDung.DataSource = quanLi.VaiTroNguoiDungModels();

            //DataTable dt = quanLi.ExecuteDataTable("sp_XemVaiTro", null);
            //dgvQLNguoiDung.DataSource = dt;


        }

        private void dgvQLNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvQLNguoiDung.Rows[e.RowIndex];
                txtTenNhanVien.Text = row.Cells["TenNhanVien"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtDiaChi.Text = row.Cells["diaChi"].Value.ToString();
                txtTaiKhoan.Text = row.Cells["taiKhoan"].Value.ToString();
                txtMatKhau.Text = row.Cells["matKhau"].Value.ToString();
                txtLuong.Text = row.Cells["luong"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = int.Parse(dgvQLNguoiDung.CurrentRow.Cells[0].Value.ToString());
                model = connectdb.User_Login.Single(p => p.id == id);
                connectdb.User_Login.Remove(model);
                connectdb.SaveChanges();
                ReloadGrid();
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");

            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbChucVu.SelectedIndex == 1)
            {
                IDchucVu = 1;
            }
            if (cmbChucVu.SelectedIndex == 0)
            {
                IDchucVu = 2;
            }

            if ((txtTenNhanVien.Text == null || txtTenNhanVien.Text == "") || (txtEmail.Text == null || txtEmail.Text == ""))
            {
                MessageBox.Show("Không thêm được!!!");
            }
            else
            {

                try
                {
                    User_Login us = new User_Login();
                    us.TenNhanVien = txtTenNhanVien.Text;
                    us.Email = txtEmail.Text;
                    us.SDT = int.Parse(txtSoDienThoai.Text);
                    us.DiaChi = txtDiaChi.Text;
                    us.TenDn = txtTaiKhoan.Text;
                    us.Matkhau = txtMatKhau.Text;
                    us.Luong = int.Parse(txtLuong.Text);
                    us.ChucVu = IDchucVu;
                    connectdb.User_Login.Add(us);
                    connectdb.SaveChanges();
                    ReloadGrid();
                    MessageBox.Show("đã thêm");
                }
                catch
                {
                    MessageBox.Show("không thêm được");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cmbChucVu.SelectedIndex == 1)
            {
                IDchucVu = 1;
            }
            if (cmbChucVu.SelectedIndex == 0)
            {
                IDchucVu = 2;
            }

            try
            {
                int id = int.Parse(dgvQLNguoiDung.CurrentRow.Cells[0].Value.ToString());
                User_Login model1 = connectdb.User_Login.Single(p => p.id == id);
                model1.TenNhanVien = txtTenNhanVien.Text;
                model1.Email = txtEmail.Text;
                model1.SDT = int.Parse(txtSoDienThoai.Text);
                model1.DiaChi = txtDiaChi.Text;
                model1.TenDn = txtTaiKhoan.Text;
                model1.Matkhau = txtMatKhau.Text;
                model1.Luong = int.Parse(txtLuong.Text);
                model1.ChucVu = IDchucVu;
                if (model1.TenDn == "" || model1.TenNhanVien == "" || model1.Email == "")
                {
                    MessageBox.Show("không sửa được");

                }
                connectdb.SaveChanges();
                MessageBox.Show("Sửa thành công");
                ReloadGrid();
            }
            catch
            {
                MessageBox.Show("Không sửa được!!!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenNhanVien.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtLuong.Text = "";
            txtSoDienThoai.Text = "";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
        }
    }
}
