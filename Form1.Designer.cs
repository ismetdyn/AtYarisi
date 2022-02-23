
namespace Proje5._32_AtYarisi
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
            this.components = new System.ComponentModel.Container();
            this.btnBaslatDurdur = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lDurum = new System.Windows.Forms.Label();
            this.lBitisNoktasi = new System.Windows.Forms.Label();
            this.pbAt3 = new System.Windows.Forms.PictureBox();
            this.pbAt2 = new System.Windows.Forms.PictureBox();
            this.pbAt4 = new System.Windows.Forms.PictureBox();
            this.pbAt1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaslatDurdur
            // 
            this.btnBaslatDurdur.AutoSize = true;
            this.btnBaslatDurdur.Location = new System.Drawing.Point(12, 13);
            this.btnBaslatDurdur.Name = "btnBaslatDurdur";
            this.btnBaslatDurdur.Size = new System.Drawing.Size(99, 26);
            this.btnBaslatDurdur.TabIndex = 4;
            this.btnBaslatDurdur.Text = "Başlat/Durdur";
            this.btnBaslatDurdur.UseVisualStyleBackColor = true;
            this.btnBaslatDurdur.Click += new System.EventHandler(this.btnBaslatDurdur_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Yarış Durumu:";
            // 
            // lDurum
            // 
            this.lDurum.AutoSize = true;
            this.lDurum.Location = new System.Drawing.Point(264, 18);
            this.lDurum.Name = "lDurum";
            this.lDurum.Size = new System.Drawing.Size(44, 16);
            this.lDurum.TabIndex = 6;
            this.lDurum.Text = "label2";
            // 
            // lBitisNoktasi
            // 
            this.lBitisNoktasi.BackColor = System.Drawing.Color.Red;
            this.lBitisNoktasi.Location = new System.Drawing.Point(1500, 20);
            this.lBitisNoktasi.Name = "lBitisNoktasi";
            this.lBitisNoktasi.Size = new System.Drawing.Size(13, 521);
            this.lBitisNoktasi.TabIndex = 7;
            // 
            // pbAt3
            // 
            this.pbAt3.Image = global::Proje5._32_AtYarisi.Properties.Resources.at_hareketli_resim_3;
            this.pbAt3.Location = new System.Drawing.Point(2, 291);
            this.pbAt3.Name = "pbAt3";
            this.pbAt3.Size = new System.Drawing.Size(100, 50);
            this.pbAt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAt3.TabIndex = 3;
            this.pbAt3.TabStop = false;
            // 
            // pbAt2
            // 
            this.pbAt2.Image = global::Proje5._32_AtYarisi.Properties.Resources.at_hareketli_resim_2;
            this.pbAt2.Location = new System.Drawing.Point(2, 187);
            this.pbAt2.Name = "pbAt2";
            this.pbAt2.Size = new System.Drawing.Size(100, 50);
            this.pbAt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAt2.TabIndex = 2;
            this.pbAt2.TabStop = false;
            // 
            // pbAt4
            // 
            this.pbAt4.Image = global::Proje5._32_AtYarisi.Properties.Resources.at_hareketli_resim_4;
            this.pbAt4.Location = new System.Drawing.Point(2, 389);
            this.pbAt4.Name = "pbAt4";
            this.pbAt4.Size = new System.Drawing.Size(100, 50);
            this.pbAt4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAt4.TabIndex = 1;
            this.pbAt4.TabStop = false;
            // 
            // pbAt1
            // 
            this.pbAt1.Image = global::Proje5._32_AtYarisi.Properties.Resources.at_hareketli_resim_1;
            this.pbAt1.Location = new System.Drawing.Point(2, 83);
            this.pbAt1.Name = "pbAt1";
            this.pbAt1.Size = new System.Drawing.Size(100, 50);
            this.pbAt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAt1.TabIndex = 0;
            this.pbAt1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 550);
            this.Controls.Add(this.lBitisNoktasi);
            this.Controls.Add(this.lDurum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBaslatDurdur);
            this.Controls.Add(this.pbAt3);
            this.Controls.Add(this.pbAt2);
            this.Controls.Add(this.pbAt4);
            this.Controls.Add(this.pbAt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAt1;
        private System.Windows.Forms.PictureBox pbAt4;
        private System.Windows.Forms.PictureBox pbAt2;
        private System.Windows.Forms.PictureBox pbAt3;
        private System.Windows.Forms.Button btnBaslatDurdur;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lDurum;
        private System.Windows.Forms.Label lBitisNoktasi;
    }
}

