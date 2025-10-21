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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        Connection cn = new Connection();
       
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtmatkhau.Focus();
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Login_Click_1(new object(), new EventArgs());
            }
        }

       

        private void Btn_Login_Click_1(object sender, EventArgs e)
        {
            string sql = "select manv, tennv from NHANVIEN where manv ='" + txtdangnhap.Text + "' and matkhau='" + txtmatkhau.Text + "'";
            DataTable dt = cn.ExecuteData(sql);
            if (dt.Rows.Count > 0)
            {
                if (txtmatkhau.Text == "123456789")
                {
                    if (MessageBox.Show("Bạn đang dùng mật khẩu mặc định.\nHãy đổi mật khẩu", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DoiMatKhau dmk = new DoiMatKhau();
                        dmk.manv = dt.Rows[0][0].ToString();
                        dmk.tennv = dt.Rows[0][1].ToString();
                        dmk.ShowDialog();
                    }
                }
                Main frmMain = new Main();
                frmMain.Manv = dt.Rows[0][0].ToString();
                frmMain.Tennv = dt.Rows[0][1].ToString();
                this.Hide();
                frmMain.ShowDialog();
                this.Show();
                txtmatkhau.Clear();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            txtdangnhap.Clear();
            txtmatkhau.Clear();
        }
    }
}
