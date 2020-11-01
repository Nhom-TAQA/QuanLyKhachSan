using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void butKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang frm = new KhachHang();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

     
        private void butLogIn_Click(object sender, EventArgs e)
        {
           
        }

        private void butPhong_Click(object sender, EventArgs e)
        {
            Phong frm = new Phong();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void butDoDung_Click(object sender, EventArgs e)
        {
            DoDung frm = new DoDung();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void butDichVu_Click(object sender, EventArgs e)
        {
            DichVu frm = new DichVu();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void butQLDichVu_Click(object sender, EventArgs e)
        {
            QLDichVu frm = new QLDichVu();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void butQLDoDung_Click(object sender, EventArgs e)
        {
            QLDoDung frm = new QLDoDung();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void butQLPhong_Click(object sender, EventArgs e)
        {
            ThuePhong frm = new ThuePhong();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void butLogOut_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn đăng xuất khỏi ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)){
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HuongDan frm = new HuongDan();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }
    }
}
