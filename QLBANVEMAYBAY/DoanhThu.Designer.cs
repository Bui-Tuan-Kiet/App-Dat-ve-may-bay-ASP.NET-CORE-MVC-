namespace QLBANVEMAYBAY
{
    partial class DoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoanhThu));
            this.dgv_thongke = new System.Windows.Forms.DataGridView();
            this.dt_timesau = new System.Windows.Forms.DateTimePicker();
            this.btn_timkiemtatca = new System.Windows.Forms.Button();
            this.dt_timetruoc = new System.Windows.Forms.DateTimePicker();
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.txt_tong = new System.Windows.Forms.TextBox();
            this.btn_tinhtong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbtimkiem = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).BeginInit();
            this.gbtimkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_thongke
            // 
            this.dgv_thongke.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongke.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_thongke.Location = new System.Drawing.Point(16, 251);
            this.dgv_thongke.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_thongke.Name = "dgv_thongke";
            this.dgv_thongke.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_thongke.RowHeadersWidth = 51;
            this.dgv_thongke.Size = new System.Drawing.Size(803, 276);
            this.dgv_thongke.TabIndex = 96;
            // 
            // dt_timesau
            // 
            this.dt_timesau.CustomFormat = "MM/dd/yyyy";
            this.dt_timesau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_timesau.Location = new System.Drawing.Point(252, 32);
            this.dt_timesau.Margin = new System.Windows.Forms.Padding(4);
            this.dt_timesau.Name = "dt_timesau";
            this.dt_timesau.Size = new System.Drawing.Size(197, 32);
            this.dt_timesau.TabIndex = 85;
            // 
            // btn_timkiemtatca
            // 
            this.btn_timkiemtatca.BackColor = System.Drawing.Color.Transparent;
            this.btn_timkiemtatca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_timkiemtatca.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiemtatca.ForeColor = System.Drawing.Color.Indigo;
            this.btn_timkiemtatca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiemtatca.Location = new System.Drawing.Point(252, 79);
            this.btn_timkiemtatca.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiemtatca.Name = "btn_timkiemtatca";
            this.btn_timkiemtatca.Size = new System.Drawing.Size(199, 59);
            this.btn_timkiemtatca.TabIndex = 86;
            this.btn_timkiemtatca.Text = "Tìm tất cả hóa đơn";
            this.btn_timkiemtatca.UseVisualStyleBackColor = false;
            this.btn_timkiemtatca.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // dt_timetruoc
            // 
            this.dt_timetruoc.CustomFormat = "MM/dd/yyyy";
            this.dt_timetruoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_timetruoc.Location = new System.Drawing.Point(20, 31);
            this.dt_timetruoc.Margin = new System.Windows.Forms.Padding(4);
            this.dt_timetruoc.Name = "dt_timetruoc";
            this.dt_timetruoc.Size = new System.Drawing.Size(184, 32);
            this.dt_timetruoc.TabIndex = 84;
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.BackColor = System.Drawing.Color.Transparent;
            this.btn_Timkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Timkiem.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Timkiem.ForeColor = System.Drawing.Color.Indigo;
            this.btn_Timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Timkiem.Location = new System.Drawing.Point(20, 79);
            this.btn_Timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Timkiem.Size = new System.Drawing.Size(193, 59);
            this.btn_Timkiem.TabIndex = 4;
            this.btn_Timkiem.Text = "Tìm";
            this.btn_Timkiem.UseVisualStyleBackColor = false;
            this.btn_Timkiem.Click += new System.EventHandler(this.btnTimTheoKhoangtg_Click);
            // 
            // txt_tong
            // 
            this.txt_tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tong.Location = new System.Drawing.Point(540, 176);
            this.txt_tong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tong.Name = "txt_tong";
            this.txt_tong.Size = new System.Drawing.Size(219, 32);
            this.txt_tong.TabIndex = 100;
            // 
            // btn_tinhtong
            // 
            this.btn_tinhtong.BackColor = System.Drawing.Color.Transparent;
            this.btn_tinhtong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tinhtong.ForeColor = System.Drawing.Color.Indigo;
            this.btn_tinhtong.Location = new System.Drawing.Point(567, 103);
            this.btn_tinhtong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tinhtong.Name = "btn_tinhtong";
            this.btn_tinhtong.Size = new System.Drawing.Size(181, 41);
            this.btn_tinhtong.TabIndex = 99;
            this.btn_tinhtong.Text = "Tính tổng";
            this.btn_tinhtong.UseVisualStyleBackColor = false;
            this.btn_tinhtong.Click += new System.EventHandler(this.btn_tinhtong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(201, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 45);
            this.label2.TabIndex = 98;
            this.label2.Text = "BÁO CÁO THỐNG KÊ";
            // 
            // gbtimkiem
            // 
            this.gbtimkiem.BackColor = System.Drawing.Color.Maroon;
            this.gbtimkiem.Controls.Add(this.dt_timesau);
            this.gbtimkiem.Controls.Add(this.btn_timkiemtatca);
            this.gbtimkiem.Controls.Add(this.dt_timetruoc);
            this.gbtimkiem.Controls.Add(this.btn_Timkiem);
            this.gbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtimkiem.ForeColor = System.Drawing.Color.DarkOrange;
            this.gbtimkiem.Location = new System.Drawing.Point(16, 73);
            this.gbtimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.gbtimkiem.Name = "gbtimkiem";
            this.gbtimkiem.Padding = new System.Windows.Forms.Padding(4);
            this.gbtimkiem.Size = new System.Drawing.Size(488, 158);
            this.gbtimkiem.TabIndex = 97;
            this.gbtimkiem.TabStop = false;
            this.gbtimkiem.Text = "Tìm kiếm theo thời gian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(768, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 101;
            this.label1.Text = "VNĐ";
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_thongke);
            this.Controls.Add(this.txt_tong);
            this.Controls.Add(this.btn_tinhtong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbtimkiem);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoanhThu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).EndInit();
            this.gbtimkiem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_thongke;
        private System.Windows.Forms.DateTimePicker dt_timesau;
        private System.Windows.Forms.Button btn_timkiemtatca;
        private System.Windows.Forms.DateTimePicker dt_timetruoc;
        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.TextBox txt_tong;
        private System.Windows.Forms.Button btn_tinhtong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbtimkiem;
        private System.Windows.Forms.Label label1;
    }
}