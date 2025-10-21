using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBANVEMAYBAY
{
    public partial class QuyDinh : Form
    {
        public QuyDinh()
        {
            InitializeComponent();
        }
        Connection ketnoi = new Connection();
        private void bnt_2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DataTable SelectAll()
        {
            return ketnoi.ExecuteData("select * from THOIGIAN");
        }
        private void frm_Thongso1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SelectAll();

        }
        public int INSERT(string ThoiGianBayToiThieu, string SoSanBayTrungGianToiDa, string ThoiGianDungToiThieu, string ThoiGianDungToiDa, string TGChamNhatDatVe, string TGChamNhatHuyDatVe)
        {

            string sql = "INSERT INTO THOIGIAN(ThoiGianBayToiThieu,SoSanBayTrungGianToiDa,ThoiGianDungToiThieu,ThoiGianDungToiDa,TGChamNhatDatVe,TGChamNhatHuyDatVe) VALUES (N'" + ThoiGianBayToiThieu + "',N'" + SoSanBayTrungGianToiDa + "',N'" + ThoiGianDungToiThieu + "',N'" + ThoiGianDungToiDa + "',N'" + TGChamNhatDatVe + "',N'" + TGChamNhatHuyDatVe + "')";

            return ketnoi.ExecuteNonQuery(sql);

        }
        public int UPDATE(string ThoiGianBayToiThieu, string SoSanBayTrungGianToiDa, string ThoiGianDungToiThieu, string ThoiGianDungToiDa, string TGChamNhatDatVe, string TGChamNhatHuyDatVe)
        {
            string sql = "UPDATE THOIGIAN SET SoSanBayTrungGianToiDa=N'" + SoSanBayTrungGianToiDa + "', ThoiGianDungToiThieu=N'" + ThoiGianDungToiThieu + "', ThoiGianDungToiDa=N'" + ThoiGianDungToiDa + "', TGChamNhatDatVe=N'" + TGChamNhatDatVe + "', TGChamNhatHuyDatVe=N'" + TGChamNhatHuyDatVe + "' WHERE ThoiGianBayToiThieu=N'" + ThoiGianBayToiThieu + "'";
            return ketnoi.ExecuteNonQuery(sql);
        }
        public int Delete(string ThoiGianBayToiThieu)
        {
            string sql = "DELETE FROM THOIGIAN WHERE [ThoiGianBayToiThieu]=N'" + ThoiGianBayToiThieu + "'";
            return ketnoi.ExecuteNonQuery(sql);
        }

       
         

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_1.Text != "")
            {
                if (MessageBox.Show("Bạn muốn xóa quy định: " + txt_1.Text, "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Delete(txt_1.Text) != -1)
                    {
                        MessageBox.Show("Đã xóa quy định thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_Thongso1_Load(new object(), new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Xóa quy định thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {

            if (txt_1.Text.Trim() == "" || txt_2.Text.Trim() == "" || txt_3.Text.Trim() == "" || txt_4.Text.Trim() == "" || txt5.Text.Trim() == "" || txt6.Text.Trim() == "" )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
                return;
            }

            if (INSERT(txt_1.Text, txt_2.Text, txt_3.Text, txt_4.Text, txt5.Text, txt6.Text) != -1)
            {
                MessageBox.Show("Đã thêm nhân viên thành công!", "Thông báo");
                frm_Thongso1_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (UPDATE(txt_1.Text, txt_2.Text, txt_3.Text, txt_4.Text, txt5.Text, txt6.Text) != -1)
            {
                MessageBox.Show("Đã cập nhật phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Thongso1_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Cập nhật phiếu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
