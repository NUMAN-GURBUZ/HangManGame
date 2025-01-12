namespace AdamAsmaca
{
    partial class KelımeGosterımı
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
            this.KelimeGösterimi = new System.Windows.Forms.Label();
            this.GırısButtonu = new System.Windows.Forms.Button();
            this.KelimeGirisBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(765, 161);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(765, 161);
            this.label2.TabIndex = 0;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KelimeGösterimi
            // 
            this.KelimeGösterimi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.KelimeGösterimi.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KelimeGösterimi.Location = new System.Drawing.Point(71, 9);
            this.KelimeGösterimi.Name = "KelimeGösterimi";
            this.KelimeGösterimi.Size = new System.Drawing.Size(850, 92);
            this.KelimeGösterimi.TabIndex = 0;
            this.KelimeGösterimi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GırısButtonu
            // 
            this.GırısButtonu.BackColor = System.Drawing.Color.LightCyan;
            this.GırısButtonu.Font = new System.Drawing.Font("Modern No. 20", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GırısButtonu.Location = new System.Drawing.Point(560, 433);
            this.GırısButtonu.Name = "GırısButtonu";
            this.GırısButtonu.Size = new System.Drawing.Size(226, 72);
            this.GırısButtonu.TabIndex = 1;
            this.GırısButtonu.Text = "GİRİŞ\r\n";
            this.GırısButtonu.UseVisualStyleBackColor = false;
            this.GırısButtonu.Click += new System.EventHandler(this.GırısButtonu_Click);
            // 
            // KelimeGirisBox
            // 
            this.KelimeGirisBox.BackColor = System.Drawing.Color.LightCyan;
            this.KelimeGirisBox.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KelimeGirisBox.Location = new System.Drawing.Point(257, 436);
            this.KelimeGirisBox.Multiline = true;
            this.KelimeGirisBox.Name = "KelimeGirisBox";
            this.KelimeGirisBox.Size = new System.Drawing.Size(150, 72);
            this.KelimeGirisBox.TabIndex = 2;
            this.KelimeGirisBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(71, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(850, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // KelımeGosterımı
            // 
            this.Appearance.BackColor = System.Drawing.Color.Tan;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 546);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.KelimeGirisBox);
            this.Controls.Add(this.GırısButtonu);
            this.Controls.Add(this.KelimeGösterimi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KelımeGosterımı";
            this.Text = "Adam Asmaca Oyunu";
            this.Load += new System.EventHandler(this.KelımeGosterımı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label KelimeGösterimi;
        private System.Windows.Forms.Button GırısButtonu;
        private System.Windows.Forms.TextBox KelimeGirisBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

