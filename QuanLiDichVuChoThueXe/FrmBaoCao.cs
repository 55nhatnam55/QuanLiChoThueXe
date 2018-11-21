using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLiDichVuChoThueXe
{
    public partial class FrmBaoCao : DevExpress.XtraEditors.XtraForm
    {
        private QL_ThuexeotoEntities connectdb = new QL_ThuexeotoEntities();
        public FrmBaoCao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = connectdb.ThongKePhieuThueTheoThoiGian(dateTimePicker1.Value, dateTimePicker2.Value).ToList();
            txtTongSoXe.Text = dataGridView1.RowCount.ToString();
           // txtXeduocthuenhieu.Text = connectdb.TopXethue(dateTimePicker1.Value, dateTimePicker2.Value).Select(p => p.SoXe).ToString();
            var topxethue= connectdb.TopXethue(dateTimePicker1.Value, dateTimePicker2.Value).FirstOrDefault();
            if (topxethue != null)
                txtXeduocthuenhieu.Text = topxethue.SoXe.ToString();
                txtSolanthue.Text = topxethue.Solanthue.ToString();
        }
    }
}