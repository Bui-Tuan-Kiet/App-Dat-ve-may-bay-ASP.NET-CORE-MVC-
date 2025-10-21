using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace QLBANVEMAYBAY
{
    public partial class HangKhach : Form
    {
        public HangKhach()
        {
            InitializeComponent();
        }
        Connection cn = new Connection();
        public int INSERT(string MAKH, string TENKH, string CMND, string DIENTHOAI)
        {
            string sql = "INSERT INTO KHACHHANG(MAKH,CMND,TENKH,DIENTHOAI) VALUES (N'" + MAKH + "',N'" + CMND + "',N'" + TENKH + "',N'" + DIENTHOAI + "')";
            return cn.ExecuteNonQuery(sql);
        }
        public int UPDATE(string MAKH, string TENKH, string CMND, string DIENTHOAI)
        {
            string sql = "UPDATE KHACHHANG SET TENKH=N'" + TENKH + "', CMND=N'" + CMND + "', DIENTHOAI=N'" + DIENTHOAI + "' WHERE MAKH=N'" + MAKH + "'";
            return cn.ExecuteNonQuery(sql);
        }
        public int Delete(string MAKH)
        {
            string sql = "DELETE FROM KHACHHANG WHERE [MAKH]=N'" + MAKH + "'";
            return cn.ExecuteNonQuery(sql);
        }
        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            string sql = "select * from KHACHHANG";
            dataGridView1.DataSource = cn.ExecuteData(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (INSERT(txt1.Text,txt3.Text, txt2.Text, txt4.Text) != -1)
            {
                MessageBox.Show("Thêm thành công");
                dataGridView1.DataSource = cn.ExecuteData("select * from KHACHHANG");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }


     

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (UPDATE(txt1.Text, txt3.Text, txt2.Text, txt4.Text) != -1)
            {
                MessageBox.Show("Đã cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_KhachHang_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Cập nhật khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                if (MessageBox.Show("Bạn muốn xóa khách hàng: " + txt1.Text, "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Delete(txt1.Text) != -1)
                    {
                        MessageBox.Show("Đã xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_KhachHang_Load(new object(), new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string tonghop = "select DATCHO.MAKH,MACHUYENBAY,MATUYENBAY,MAHANGVE,SOGHEDAT,NGAYDAT,GIATIEN,CMND,TENKH,DIENTHOAI\r\nfrom DATCHO, KHACHHANG where DATCHO.MAKH = KHACHHANG.MAKH";
            dataGridView1.DataSource = cn.ExecuteData(tonghop);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.ExecuteData("select * from KHACHHANG");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Reset all textboxes
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string searchValue = txt1.Text;
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
