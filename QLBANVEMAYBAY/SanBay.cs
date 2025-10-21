using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBANVEMAYBAY
{
    public partial class SanBay : Form
    {
        public SanBay()
        {
            InitializeComponent();
        }

        Connection cn = new Connection();

        private void bt_them_Click(object sender, EventArgs e)
        {

            if (txt_1.Text.Trim() == "" || txt_2.Text.Trim() == "" )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
                return;
            }

            if (INSERT(txt_1.Text,txt_2.Text) != -1)
            {
                MessageBox.Show("Thêm thành công");
                dataGridView1.DataSource = SelectAll();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            
        }
        public int INSERT(string MASANBAY, string TENSANBAY)
        {
            string sql = "INSERT INTO SANBAY(MASANBAY,TENSANBAY) VALUES (N'" + MASANBAY + "',N'" + TENSANBAY + "')";
            return cn.ExecuteNonQuery(sql);
        }
        public int UPDATE(string MASANBAY, string TENSANBAY)
        {
            string sql = "UPDATE SANBAY SET  [MASANBAY]=N'" + MASANBAY + "' WHERE [TENSANBAY]=N'" + TENSANBAY + "'";
            return cn.ExecuteNonQuery(sql);
        }
        public int Delete(string MASANBAY)
        {
            string sql = "DELETE FROM SANBAY WHERE [MASANBAY]=N'" + MASANBAY + "'";
            return cn.ExecuteNonQuery(sql);
        }

        public DataTable SelectAll()
        {
            return cn.ExecuteData("select * from SANBAY");
        }

        private void frm_ThemSanBay_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SelectAll();
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            if (UPDATE(txt_1.Text, txt_2.Text) != -1)
            {
                MessageBox.Show("Đã cập nhật sân bay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_ThemSanBay_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Cập nhật sân bay thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (txt_1.Text != "")
            {
                if (MessageBox.Show("Bạn muốn xóa sân bay: " + txt_1.Text, "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Delete(txt_1.Text) != -1)
                    {
                        MessageBox.Show("Đã xóa sân bay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_ThemSanBay_Load(new object(), new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Xóa sân bay thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
