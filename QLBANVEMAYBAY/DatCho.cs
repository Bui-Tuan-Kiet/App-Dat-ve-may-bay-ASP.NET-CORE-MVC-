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
    public partial class DatCho : Form
    {
        public DatCho()
        {
            InitializeComponent();
        }
        Connection cn = new Connection();
        private void DatCho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vemaybayDataSet1.DATCHO' table. You can move, or remove it, as needed.
            this.dATCHOTableAdapter.Fill(this.vemaybayDataSet1.DATCHO);
            cb3.DataSource = cn.ExecuteData("select * from CHUYENBAY ");
            cb3.ValueMember = "MACHUYENBAY";
            cb3.DisplayMember = "MACHUYENBAY";

            cb2.DataSource = cn.ExecuteData("select * from KHACHHANG ");
            cb2.ValueMember = "MAKH";
            cb2.DisplayMember = "MAKH";

            cb4.DataSource = cn.ExecuteData("select * from TUYENBAY ");
            cb4.ValueMember = "MATUYENBAY";
            cb4.DisplayMember = "MATUYENBAY";

            cb5.DataSource = cn.ExecuteData("select * from HANGVE ");
            cb5.ValueMember = "mahangve";
            cb5.DisplayMember = "tenhangve";

     
            dataGridView1.DataSource = cn.ExecuteData("select * from DATCHO");
        }     
        public DataTable SelectAll()
        {
            return cn.ExecuteData("select * from CHUYENBAY");
        }

        public int INSERT(string MAPHIEU, string MAKH, string MACHUYENBAY,string MATUYENBAY, string MAHANGVE, int SOGHEDAT, DateTime NGAYDAT, int GIATIEN)
        {
            string sql = "INSERT INTO DATCHO(MAPHIEU,MAKH,MACHUYENBAY,MATUYENBAY,MAHANGVE,SOGHEDAT,NGAYDAT,GIATIEN) VALUES (N'" + MAPHIEU + "',N'" + MAKH + "',N'" + MACHUYENBAY + "',N'" + MATUYENBAY + "',N'" + MAHANGVE + "',N'" + SOGHEDAT + "',N'" + NGAYDAT.ToString("MM/dd/ yyyy") + "',N'" + GIATIEN + "')";
            return cn.ExecuteNonQuery(sql);
        }
        public int UPDATE(string MAPHIEU, string MAKH, string MACHUYENBAY, string MATUYENBAY, string MAHANGVE, int SOGHEDAT, DateTime NGAYDAT, int GIATIEN)
        {
            string sql = "UPDATE DATCHO SET  MAKH=N'" + MAKH + "', MACHUYENBAY=N'" + MACHUYENBAY + "', MATUYENBAY=N'" + MATUYENBAY + "', MAHANGVE=N'" + MAHANGVE + "', SOGHEDAT=N'" + SOGHEDAT + "', NGAYDAT=N'" + NGAYDAT.ToString("MM/dd/ yyyy") + "', GIATIEN=N'" + GIATIEN + "' WHERE MAPHIEU=N'" + MAPHIEU + "'";
            return cn.ExecuteNonQuery(sql);
        }
        public int Delete(string MAPHIEU)
        {
            string sql = "DELETE FROM DATCHO WHERE [MAPHIEU]=N'" + MAPHIEU + "'";
            return cn.ExecuteNonQuery(sql);
        }

        private void bnt_luu_Click(object sender, EventArgs e)
        {

            if (txt1.Text.Trim() == "" || cb2.Text.Trim() == "" || cb3.Text.Trim() == "" || cb4.Text.Trim() == "" || cb5.Text.Trim() == "" || txt6.Text.Trim() == "" || dt7.Text.Trim() == "" || txt8.Text.Trim() == "" )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
                return;
            }
            if (INSERT(txt1.Text, cb2.Text, cb3.Text,cb4.Text, cb5.Text, int.Parse(txt6.Text), dt7.Value, int.Parse(txt8.Text)) != -1)
            {
                MessageBox.Show("Đã thêm phiếu đặt chỗ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DatCho_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm phiếu đặt chỗ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }          
        private void bnt_capnhat_Click(object sender, EventArgs e)
        {
            if (UPDATE(txt1.Text, cb2.Text, cb3.Text, cb4.Text, cb5.Text, int.Parse(txt6.Text), dt7.Value, int.Parse(txt8.Text)) != -1)
            {
                MessageBox.Show("Đã cập nhật phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               DatCho_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Cập nhật phiếu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bnt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnt_xoa_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                if (MessageBox.Show("Bạn muốn xóa phiếu: " + txt1.Text, "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Delete(txt1.Text) != -1)
                    {
                        MessageBox.Show("Đã xóa phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DatCho_Load(new object(), new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Xóa phiếu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

       

       
       

        private void txt6_TextChanged(object sender, EventArgs e)
        {
            double sl, gn, tt;
            if (txt8.Text == "")
                gn = 0;
            else
                gn = Convert.ToDouble(txt8.Text);
            if (txt6.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txt6.Text);
            tt = gn * sl;
            txt8.Text = tt.ToString();
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            // Reset all textboxes
            txt1.Text = "";
            cb2.Text = "";
            cb3.Text = "";
            cb4.Text = "";
            cb5.Text = "";
            txt6.Text = "";
            dt7.Text = "";
            txt8.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cb2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cb3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cb4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cb5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dt7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
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
                MessageBox.Show("Không tìm thấy mã phiếu vé đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
