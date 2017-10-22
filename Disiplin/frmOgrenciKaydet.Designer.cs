namespace Disiplin
{
    partial class frmOgrenciKaydet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtNumara);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(31, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numara";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(136, 34);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 29);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(136, 70);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 29);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(136, 105);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 29);
            this.txtNumara.TabIndex = 2;
            // 
            // frmOgrenciKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 360);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOgrenciKaydet";
            this.Text = "Öğrenci Kayıt ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}