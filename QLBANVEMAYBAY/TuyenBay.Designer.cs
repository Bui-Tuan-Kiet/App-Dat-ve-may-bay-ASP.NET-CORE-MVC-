namespace QLBANVEMAYBAY
{
    partial class TuyenBay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TuyenBay));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MATUYENBAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASANBAYDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASANBAYDEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATUYENBAY,
            this.MASANBAYDI,
            this.MASANBAYDEN});
            this.dataGridView1.Location = new System.Drawing.Point(11, 265);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(788, 278);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // MATUYENBAY
            // 
            this.MATUYENBAY.DataPropertyName = "MATUYENBAY";
            this.MATUYENBAY.HeaderText = "Mã tuyến bay";
            this.MATUYENBAY.MinimumWidth = 6;
            this.MATUYENBAY.Name = "MATUYENBAY";
            this.MATUYENBAY.Width = 150;
            // 
            // MASANBAYDI
            // 
            this.MASANBAYDI.DataPropertyName = "MASANBAYDI";
            this.MASANBAYDI.HeaderText = "Mã Sân Bay Đi";
            this.MASANBAYDI.MinimumWidth = 6;
            this.MASANBAYDI.Name = "MASANBAYDI";
            this.MASANBAYDI.Width = 200;
            // 
            // MASANBAYDEN
            // 
            this.MASANBAYDEN.DataPropertyName = "MASANBAYDEN";
            this.MASANBAYDEN.HeaderText = "Mã Sân Bay Đến";
            this.MASANBAYDEN.MinimumWidth = 6;
            this.MASANBAYDEN.Name = "MASANBAYDEN";
            this.MASANBAYDEN.Width = 200;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SandyBrown;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 34);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tên Sân Bay đi:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            "Nhật Bản",
            "Hàn Quốc",
            "Trung Quốc",
            "Nga",
            "Vương Quốc Anh",
            "Mỹ"});
            this.cb2.Location = new System.Drawing.Point(288, 214);
            this.cb2.Margin = new System.Windows.Forms.Padding(5);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(292, 24);
            this.cb2.TabIndex = 30;
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(288, 149);
            this.cb1.Margin = new System.Windows.Forms.Padding(5);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(292, 24);
            this.cb1.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SandyBrown;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 33);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tên Sân Bay đến:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SandyBrown;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 33);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã Tuyến Bay:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(283, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "THÊM TUYẾN BAY";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(651, 144);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(5);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(131, 37);
            this.btn_xoa.TabIndex = 28;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(651, 84);
            this.btn_them.Margin = new System.Windows.Forms.Padding(5);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(131, 37);
            this.btn_them.TabIndex = 26;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(651, 201);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(5);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(131, 37);
            this.btn_sua.TabIndex = 32;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(651, 22);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(5);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(131, 37);
            this.btn_timkiem.TabIndex = 33;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(288, 81);
            this.txt_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_1.Multiline = true;
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(292, 36);
            this.txt_1.TabIndex = 127;
            // 
            // TuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 548);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TuyenBay";
            this.Text = "Tuyến Bay";
            this.Load += new System.EventHandler(this.TuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATUYENBAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASANBAYDI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASANBAYDEN;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_1;
    }
}