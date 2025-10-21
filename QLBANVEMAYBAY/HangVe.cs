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
    public partial class HangVe : Form
    {
        public HangVe()
        {
            InitializeComponent();
        }

        Connection cn = new Connection();
        private void frm_ThemHangVe_Load(object sender, EventArgs e)
        {
            cbHangve.DataSource = cn.ExecuteData("select * from HANGVE");
            cbHangve.ValueMember = "mahangve";
            cbHangve.DisplayMember = "tenhangve";
        }
        public int INSERT(string mahangve, string tenhangve)
        {
            string sql = "INSERT INTO HANGVE(mahangve,tenhangve) VALUES (N'" + mahangve + "',N'" + tenhangve + "')";
            return cn.ExecuteNonQuery(sql);
        }
        public int UPDATE(string mahangve, string tenhangve)
        {
            string sql = "UPDATE HANGVE SET [mahangve]=" + mahangve + ",[tenhangve]=" + tenhangve + " WHERE [mahangve]=N'" + mahangve + "'";
            return cn.ExecuteNonQuery(sql);
        }
        public int Delete(string mahangve)
        {
            string sql = "DELETE FROM HANGVE WHERE [mahangve]=N'" + mahangve + "'";
            return cn.ExecuteNonQuery(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmahangve.Text != "" && txttenhangve.Text != "")
                {
                    if (UPDATE(txtmahangve.Text, txttenhangve.Text) > 0)
                    {
                        MessageBox.Show("Đã cập nhật hạng vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbHangve.DataSource = cn.ExecuteData("select * from HANGVE");
                        cbHangve.ValueMember = "mahangve";
                        cbHangve.DisplayMember = "tenhangve";
                    }
                }
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmahangve.Text != "" && txttenhangve.Text != "")
                {
                    if (INSERT(txtmahangve.Text, txttenhangve.Text) > 0)
                    {
                        MessageBox.Show("Đã thêm hạng vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbHangve.DataSource = cn.ExecuteData("select * from HANGVE");
                        cbHangve.ValueMember = "mahangve";
                        cbHangve.DisplayMember = "tenhangve";
                        txtmahangve.Clear();
                        txttenhangve.Clear();
                    }
                }
            }
            catch { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txttenhangve.Text = cbHangve.Text;
            txtmahangve.Text = cbHangve.SelectedValue.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa hạng vé này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mahangve = cbHangve.SelectedValue.ToString();
                if (Delete(mahangve) > 0)
                {
                    MessageBox.Show("Đã xóa hạng vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbHangve.DataSource = cn.ExecuteData("select * from HANGVE");
                    cbHangve.ValueMember = "mahangve";
                    cbHangve.DisplayMember = "tenhangve";
                }
            }
        }
    }
}
