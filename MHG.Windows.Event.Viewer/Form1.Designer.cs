namespace MHG.Windows.Event.Viewer
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
            this.txtOlayAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOlayKaynakAdi = new System.Windows.Forms.TextBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOlayTuru = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtOlayAdi
            // 
            this.txtOlayAdi.Location = new System.Drawing.Point(12, 37);
            this.txtOlayAdi.Multiline = true;
            this.txtOlayAdi.Name = "txtOlayAdi";
            this.txtOlayAdi.Size = new System.Drawing.Size(281, 67);
            this.txtOlayAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Olay Mesajınız";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Olay Kaynak Adı";
            // 
            // txtOlayKaynakAdi
            // 
            this.txtOlayKaynakAdi.Location = new System.Drawing.Point(12, 166);
            this.txtOlayKaynakAdi.Name = "txtOlayKaynakAdi";
            this.txtOlayKaynakAdi.Size = new System.Drawing.Size(281, 20);
            this.txtOlayKaynakAdi.TabIndex = 2;
            this.txtOlayKaynakAdi.Text = "muratoner.net";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(139, 192);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(154, 23);
            this.btnOlustur.TabIndex = 4;
            this.btnOlustur.Text = "Olay Adı ve Kaynağı Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Olay Türü";
            // 
            // cbOlayTuru
            // 
            this.cbOlayTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOlayTuru.FormattingEnabled = true;
            this.cbOlayTuru.Items.AddRange(new object[] {
            "Bilgi",
            "Uyarı",
            "Hata"});
            this.cbOlayTuru.Location = new System.Drawing.Point(12, 123);
            this.cbOlayTuru.Name = "cbOlayTuru";
            this.cbOlayTuru.Size = new System.Drawing.Size(281, 21);
            this.cbOlayTuru.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 224);
            this.Controls.Add(this.cbOlayTuru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOlayKaynakAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOlayAdi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOlayAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOlayKaynakAdi;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbOlayTuru;
    }
}

