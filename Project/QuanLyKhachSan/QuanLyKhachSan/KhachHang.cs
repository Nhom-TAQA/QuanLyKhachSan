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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            reset();
        }

        private DataTable table;
        private Connection connector = new Connection();

        private void reset()
        {
            listView1.Items.Clear();
            table = new DataTable();
            table = connector.LoadData("1");
            int i = 0;
            foreach (DataRow row in table.Rows)
            {
                listView1.Items.Add(row[0].ToString());
                listView1.Items[i].SubItems.Add(row[1].ToString());
                i++;
            }
        }

        private void reset2()
        {
            listView1.Items.Clear();
            table = connector.FindObject("1", textSearch.Text.Trim());
            int i = 0;
            foreach (DataRow row in table.Rows)
            {
                listView1.Items.Add(row[0].ToString());
                listView1.Items[i].SubItems.Add(row[1].ToString());
                i++;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedItems[0].Index;
                textID.Text = table.Rows[index][0].ToString();
                textName.Text = table.Rows[index][1].ToString();
                textCMND.Text = table.Rows[index][2].ToString();
                textPhone.Text = table.Rows[index][3].ToString();
            }
        }

        private void radView_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rad = (RadioButton)(sender);
            if (rad.Checked == true)
            {
                butFree.Text = rad.Text;
                if (rad.Text == "Xem")
                {
                    butFree.Enabled = false;
                    textCMND.ReadOnly = textName.ReadOnly = textID.ReadOnly = textPhone.ReadOnly = true;
                }
                else
                {
                    butFree.Enabled = true;
                    textID.ReadOnly = true;
                    textCMND.ReadOnly = textName.ReadOnly = textPhone.ReadOnly = false;
                    if (rad.Text == "Thêm")
                    {
                        textID.ReadOnly = false;
                        textCMND.Text = textName.Text = textID.Text = textPhone.Text = "";
                    }
                }
            }
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                connector.DeleteObject("1", textID.Text.Trim(), "");
                if (butSearch.Text.Trim() == "Hủy")
                {
                    reset2();
                }
                else reset();
                textCMND.Text = textName.Text = textID.Text = textPhone.Text = "";
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            i
            }
            else
            {
                butSearch.Text = "Tìm";
                reset();
            }
        }
        private bool check(int k)
        {
            if (k == 1)
            {
                if (textID.Text.Trim() == "")
                {
                    MessageBox.Show("Không được để trống Mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textID.Focus();
                    return false;
                }
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (textID.Text.Trim() == table.Rows[i][0].ToString().Trim())
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        textID.Focus();
                        return false;
                    }
                }
            }
            if (textName.Text.Trim() == "")
            {
                MessageBox.Show("Họ tên khách hàng không được phép để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textName.Focus();
                return false;
            }
            if (textCMND.Text.Trim() == "")
            {
                MessageBox.Show("CMND không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textCMND.Focus();
                return false;
            }
            if (textPhone.Text.Trim() == "")
            {
                MessageBox.Show("SĐT không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textPhone.Focus();
                return false;
            }
            int b;
            if (int.TryParse(textPhone.Text, out b) == false)
            {
                MessageBox.Show("SĐT không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textPhone.Focus();
                return false;
            }
            return true;
        }

        private void butFree_Click(object sender, EventArgs e)
        {
            if (butFree.Text == "Thêm")
            {
                if (check(1) == false) return;
                connector.InsertUpdateObject("AddObject", "1", textID.Text, textCMND.Text, textName.Text, "1/1/1994", "1/1/1994", textPhone.Text);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (check(2) == false) return;
                connector.InsertUpdateObject("EditObject", "1", textID.Text, textCMND.Text, textName.Text, "1/1/1994", "1/1/1994", textPhone.Text);
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (butSearch.Text.Trim() == "Tìm") reset();
            else reset2();
        }
    }
}
