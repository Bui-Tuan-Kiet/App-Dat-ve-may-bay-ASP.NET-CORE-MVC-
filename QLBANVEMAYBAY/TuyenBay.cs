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
    public partial class TuyenBay : Form
    {
        public TuyenBay()
        {
            InitializeComponent();
        }

        public DataTable SelectAll()
        {
            return cn.ExecuteData("select * from TUYENBAY");
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (txt_1.Text.Trim() == "" || cb1.Text.Trim() == "" || cb2.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
                return;
            }

            if (INSERT(txt_1.Text, cb1.Text, cb2.Text) != -1)
            {
                dataGridView1.DataSource = SelectAll();
                MessageBox.Show("Đã thêm thành công", "Thông báo");
                TuyenBay_Load(new object(), new EventArgs());

            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_1.Text != "")
            {
                if (MessageBox.Show("Bạn muốn xóa tuyến bay: " + txt_1.Text, "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Delete(txt_1.Text) != -1)
                    {
                        MessageBox.Show("Đã xóa tuyến bay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TuyenBay_Load(new object(), new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Xóa tuyến bay thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        Connection cn = new Connection();

        private void TuyenBay_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SelectAll();
            cb1.DataSource = cn.ExecuteData("select * from SANBAY");
            cb1.DisplayMember = "TENSANBAY";
            cb1.ValueMember = "MASANBAY";
            cb1.SelectedIndex = 0;

            cb2.DataSource = cn.ExecuteData("select * from SANBAY");
            cb2.DisplayMember = "TENSANBAY";
            cb2.ValueMember = "MASANBAY";
            cb2.SelectedIndex = 0;

        }

        public int INSERT(string MATUYENBAY, string MASANBAYDI, string MASANBAYDEN)
        {
            string sql = "INSERT INTO TUYENBAY(MATUYENBAY,MASANBAYDI,MASANBAYDEN) VALUES (N'" + MATUYENBAY + "',N'" + MASANBAYDI + "',N'" + MASANBAYDEN + "')";
            return cn.ExecuteNonQuery(sql);
        }

        public int Update(string MATUYENBAY, string MASANBAYDI, string MASANBAYDEN)
        {
            string sql = "UPDATE TUYENBAY SET MASANBAYDI = N'" + MASANBAYDI + "', MASANBAYDEN = N'" + MASANBAYDEN + "' WHERE MATUYENBAY = N'" + MATUYENBAY + "'";
            return cn.ExecuteNonQuery(sql);
        }
        public int Delete(string MATUYENBAY)
        {
           
            string sql = "DELETE FROM TUYENBAY WHERE [MATUYENBAY]=N'" + MATUYENBAY + "'" + " OR [MASANBAYDI] IS NULL" + " OR [MASANBAYDEN] IS NULL";
            return cn.ExecuteNonQuery(sql);
           
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cb1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cb2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_1.Text != "")
                {
                    if (Update(txt_1.Text, cb1.Text, cb2.Text) != -1)
                    {
                        dataGridView1.DataSource = SelectAll();
                        MessageBox.Show("Đã cập nhật thành công", "Thông báo");
                        TuyenBay_Load(new object(), new EventArgs());

                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tuyến bay cần cập nhật", "Thông báo");
                }
            }
            catch (Exception d)
            {
                MessageBox.Show("Cập nhật thất bại \n" + d.Message, "Thông báo");
            }

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string searchValue = txt_1.Text;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
