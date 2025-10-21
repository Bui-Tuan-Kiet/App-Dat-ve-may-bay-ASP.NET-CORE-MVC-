namespace QLBANVEMAYBAY
{
    partial class SanBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanBay));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Masanbay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensanbay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masanbay,
            this.Tensanbay});
            this.dataGridView1.Location = new System.Drawing.Point(11, 242);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(541, 140);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Masanbay
            // 
            this.Masanbay.DataPropertyName = "MASANBAY";
            this.Masanbay.HeaderText = "Mã sân bay";
            this.Masanbay.MinimumWidth = 6;
            this.Masanbay.Name = "Masanbay";
            this.Masanbay.ReadOnly = true;
            this.Masanbay.Width = 140;
            // 
            // Tensanbay
            // 
            this.Tensanbay.DataPropertyName = "Tensanbay";
            this.Tensanbay.HeaderText = "Tên sân bay";
            this.Tensanbay.MinimumWidth = 6;
            this.Tensanbay.Name = "Tensanbay";
            this.Tensanbay.ReadOnly = true;
            this.Tensanbay.Width = 220;
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(171, 185);
            this.txt_2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_2.Multiline = true;
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(220, 36);
            this.txt_2.TabIndex = 13;
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(171, 130);
            this.txt_1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_1.Multiline = true;
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(220, 36);
            this.txt_1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên Sân Bay";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã Sân Bay";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(180, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "THÊM SÂN BAY";
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.Green;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.Color.Tomato;
            this.bt_xoa.Location = new System.Drawing.Point(416, 197);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(100, 38);
            this.bt_xoa.TabIndex = 17;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.Green;
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.ForeColor = System.Drawing.Color.Salmon;
            this.bt_sua.Location = new System.Drawing.Point(416, 150);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(100, 39);
            this.bt_sua.TabIndex = 16;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_capnhat_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.Green;
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.Color.Salmon;
            this.bt_them.Location = new System.Drawing.Point(416, 111);
            this.bt_them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(100, 32);
            this.bt_them.TabIndex = 15;
            this.bt_them.Text = "Thêm ";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // SanBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 405);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SanBay";
            this.Text = "Sân Bay";
            this.Load += new System.EventHandler(this.frm_ThemSanBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masanbay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensanbay;
    }
}