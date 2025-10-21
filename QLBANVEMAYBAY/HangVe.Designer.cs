namespace QLBANVEMAYBAY
{
    partial class HangVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangVe));
            this.label3 = new System.Windows.Forms.Label();
            this.cbHangve = new System.Windows.Forms.ComboBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttenhangve = new System.Windows.Forms.TextBox();
            this.txtmahangve = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Hạng Vé ";
            // 
            // cbHangve
            // 
            this.cbHangve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbHangve.FormattingEnabled = true;
            this.cbHangve.Location = new System.Drawing.Point(191, 74);
            this.cbHangve.Margin = new System.Windows.Forms.Padding(4);
            this.cbHangve.Name = "cbHangve";
            this.cbHangve.Size = new System.Drawing.Size(253, 33);
            this.cbHangve.TabIndex = 16;
            this.cbHangve.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbHangve.Click += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Thistle;
            this.btn_xoa.Location = new System.Drawing.Point(340, 251);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(124, 37);
            this.btn_xoa.TabIndex = 15;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên Hạng Vé ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã Hạng Vé ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txttenhangve
            // 
            this.txttenhangve.Location = new System.Drawing.Point(191, 196);
            this.txttenhangve.Margin = new System.Windows.Forms.Padding(4);
            this.txttenhangve.Multiline = true;
            this.txttenhangve.Name = "txttenhangve";
            this.txttenhangve.Size = new System.Drawing.Size(253, 34);
            this.txttenhangve.TabIndex = 12;
            // 
            // txtmahangve
            // 
            this.txtmahangve.Location = new System.Drawing.Point(191, 137);
            this.txtmahangve.Margin = new System.Windows.Forms.Padding(4);
            this.txtmahangve.Multiline = true;
            this.txtmahangve.Name = "txtmahangve";
            this.txtmahangve.Size = new System.Drawing.Size(253, 36);
            this.txtmahangve.TabIndex = 11;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Black;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Thistle;
            this.btn_Them.Location = new System.Drawing.Point(32, 251);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(124, 37);
            this.btn_Them.TabIndex = 10;
            this.btn_Them.Text = "Thêm mới";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Thistle;
            this.btn_sua.Location = new System.Drawing.Point(191, 251);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(123, 37);
            this.btn_sua.TabIndex = 9;
            this.btn_sua.Text = "Cập nhật";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(176, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "HẠNG VÉ";
            // 
            // HangVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(477, 313);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbHangve);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttenhangve);
            this.Controls.Add(this.txtmahangve);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_sua);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HangVe";
            this.Text = "Hạng Vé";
            this.Load += new System.EventHandler(this.frm_ThemHangVe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHangve;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenhangve;
        private System.Windows.Forms.TextBox txtmahangve;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label label4;
    }
}