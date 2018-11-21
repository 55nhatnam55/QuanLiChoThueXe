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
    public partial class FormDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        private QL_ThuexeotoEntities connectdb = new QL_ThuexeotoEntities();
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.Text.Trim()==txtMatKhauMoi.Text.Trim() && txtMatKhauMoi.Text!="")
            {
                User_Login us = connectdb.User_Login.Single(p => p.id == Session.id);
                us.Matkhau = txtMatKhauMoi.Text.Trim();
                connectdb.SaveChanges();
                MessageBox.Show("Đổi mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng khớp hoặc bỏ trống");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dia == DialogResult.OK)
            {
                this.Close();              
            }
        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {
            var GetLogin = connectdb.User_Login.FirstOrDefault(i => i.id==Session.id);
            if (GetLogin != null)
            {
                lbTenAcc.Text = GetLogin.TenDn.Trim().ToString();
            }
        }
    }
}
