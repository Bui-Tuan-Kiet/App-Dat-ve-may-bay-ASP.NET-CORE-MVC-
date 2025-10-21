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
using System.Globalization;

namespace QLBANVEMAYBAY
{
    public partial class LichBay : Form
    {
        public LichBay()
        {
            InitializeComponent();
        }

        Connection cn = new Connection();

        private void frm_ThemChuyenBay_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = SelectAll();
            cb2.DataSource = cn.ExecuteData("select * from SANBAY ");
            cb2.DisplayMember = "TENSANBAY";
            cb2.ValueMember = "MASANBAY";
            cb2.SelectedIndex = 0;

            cb3.DataSource = cn.ExecuteData("select * from SANBAY");
            cb3.DisplayMember = "TENSANBAY";
            cb3.ValueMember = "MASANBAY";
            cb3.SelectedIndex = 0;
        }
        public DataTable SelectAll()
        {
            return cn.ExecuteData("select * from CHUYENBAY");
        }
        public int INSERT(string MACHUYENBAY, string SANBAYDI, string SANBAYDEN, DateTime NGAYGIO, DateTime THOIGIANBAY, int SOLUONGGHEHANG1, int SOLUONGGHEHANG2)
        {
            string sql = "INSERT INTO CHUYENBAY(MACHUYENBAY,SANBAYDI,SANBAYDEN,NGAYGIO,THOIGIANBAY,SOLUONGGHEHANG1,SOLUONGGHEHANG2) VALUES (N'" + MACHUYENBAY + "',N'" + SANBAYDI + "',N'" + SANBAYDEN + "',N'" + NGAYGIO.ToString("MM/dd/yyyy") + "',N'" + THOIGIANBAY.ToString("hh:mm:ss ") + "',N'" + SOLUONGGHEHANG1 + "',N'" + SOLUONGGHEHANG2 + "')";
            return cn.ExecuteNonQuery(sql);
        }
        public int UPDATE(string MACHUYENBAY, string SANBAYDI, string SANBAYDEN, DateTime NGAYGIO, DateTime THOIGIANBAY, int SOLUONGGHEHANG1, int SOLUONGGHEHANG2)
        {
            string sql = "UPDATE CHUYENBAY SET [MACHUYENBAY]=N'" + MACHUYENBAY + "',[SANBAYDI]=N'" + SANBAYDI + "',[SANBAYDEN]=N'" + SANBAYDEN + "',[NGAYGIO]=N'" + NGAYGIO.ToString("MM/dd/yyyy") + "',[THOIGIANBAY]=N'" + THOIGIANBAY.ToString("hh:mm:ss ") + "',[SOLUONGGHEHANG1]=N'" + SOLUONGGHEHANG1 + "',[SOLUONGGHEHANG2]=N'" + SOLUONGGHEHANG2 + "' WHERE [MACHUYENBAY]=N'" + MACHUYENBAY + "'";
            return cn.ExecuteNonQuery(sql);
        }
        public int Delete(string MACHUYENBAY)
        {
            string sql = "DELETE FROM CHUYENBAY WHERE [MACHUYENBAY]=N'" + MACHUYENBAY + "'";
            return cn.ExecuteNonQuery(sql);
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (INSERT(txt1.Text, cb2.Text, cb3.Text, dt4.Value, dt5.Value, int.Parse(txt6.Text), int.Parse(txt7.Text)) != -1)
                {
                    dataGridView1.DataSource = SelectAll();
                    MessageBox.Show("Thêm dữ liệu thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại", "Thông báo");
                }
            }
            catch (Exception m) { MessageBox.Show(m.Message, "Thông báo"); }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cb2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cb3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dt4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dt5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            
            if (UPDATE(txt1.Text, cb2.Text, cb3.Text, dt4.Value, dt5.Value, int.Parse(txt6.Text), int.Parse(txt7.Text)) != -1)
            {
                MessageBox.Show("Đã cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_ThemChuyenBay_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                if (MessageBox.Show("Bạn muốn xóa chuyến bay: " + txt1.Text, "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Delete(txt1.Text) != -1)
                    {
                        MessageBox.Show("Đã xóa chuyến bay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_ThemChuyenBay_Load(new object(), new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Xóa chuyến bay thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void bt_re_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt6.Clear();
            txt7.Clear();
            
        }
       
        
    }
}
