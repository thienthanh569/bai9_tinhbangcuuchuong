namespace bai9
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.ListBox();
            this.nubBangCuuChuong = new System.Windows.Forms.NumericUpDown();
            this.btTinh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nubBangCuuChuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÍNH BẢNG CỬU CHƯƠNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "chọn bảng cửu chương";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(54, 116);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(0, 13);
            this.lblKQ.TabIndex = 1;
            this.lblKQ.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbKQ
            // 
            this.lbKQ.FormattingEnabled = true;
            this.lbKQ.Location = new System.Drawing.Point(126, 116);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(120, 147);
            this.lbKQ.TabIndex = 2;
            this.lbKQ.SelectedIndexChanged += new System.EventHandler(this.lbKQ_SelectedIndexChanged);
            // 
            // nubBangCuuChuong
            // 
            this.nubBangCuuChuong.Location = new System.Drawing.Point(136, 64);
            this.nubBangCuuChuong.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nubBangCuuChuong.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nubBangCuuChuong.Name = "nubBangCuuChuong";
            this.nubBangCuuChuong.Size = new System.Drawing.Size(120, 20);
            this.nubBangCuuChuong.TabIndex = 3;
            this.nubBangCuuChuong.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nubBangCuuChuong.ValueChanged += new System.EventHandler(this.nubBangCuuChuong_ValueChanged);
            // 
            // btTinh
            // 
            this.btTinh.Location = new System.Drawing.Point(262, 61);
            this.btTinh.Name = "btTinh";
            this.btTinh.Size = new System.Drawing.Size(75, 23);
            this.btTinh.TabIndex = 4;
            this.btTinh.Text = "tính";
            this.btTinh.UseVisualStyleBackColor = true;
            this.btTinh.Click += new System.EventHandler(this.btTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btTinh);
            this.Controls.Add(this.nubBangCuuChuong);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nubBangCuuChuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.ListBox lbKQ;
        private System.Windows.Forms.NumericUpDown nubBangCuuChuong;
        private System.Windows.Forms.Button btTinh;
    }
}

