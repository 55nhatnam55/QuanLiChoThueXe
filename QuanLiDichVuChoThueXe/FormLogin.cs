using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiDichVuChoThueXe
{
    public partial class FormLogin : Form
    {
        private QL_ThuexeotoEntities connectdb = new QL_ThuexeotoEntities();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            User_Login us = new User_Login();
            if (txtTaikhoan.Text == "" || txtTaikhoan.Text == null)
            {
                MessageBox.Show("Chưa nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMatKhau.Text == "" || txtMatKhau.Text == null)
            {
                MessageBox.Show("Chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
                var GetLogin = connectdb.User_Login.FirstOrDefault(i => i.TenDn.Equals(txtTaikhoan.Text.Trim()) && i.Matkhau.Equals(txtMatKhau.Text.Trim()));
                if(GetLogin!=null)
                {
                    Session.id = GetLogin.id;
                    Form1 fr = new Form1();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dia == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Session.id = -1;
        }
    }
}
