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
    public partial class QLDichVu : Form
    {
        public QLDichVu()
        {
            InitializeComponent();
        }

        private void FormQLDichVu_Load(object sender, EventArgs e)
        {
            reset();
            reset3();
        }

        private DataTable table1;
        private DataTable table2;
        private DataTable table3;
        private Connection connector = new Connection();

        private void reset()
        {
            
        }

        private void reset2()
        {
        }

        private void reset3()
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radView_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
           
        }

        private bool check(int k)
        {
            
            return true;
        }

        private void butFree_Click(object sender, EventArgs e)
        {
            
        }
    }
}
