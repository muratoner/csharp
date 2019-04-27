namespace MHG.ImageProcess
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.pbProcessed = new System.Windows.Forms.PictureBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.cbProcessType = new System.Windows.Forms.ComboBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.tbBrightness = new System.Windows.Forms.TrackBar();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProcessed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBrightness);
            this.panel1.Controls.Add(this.tbBrightness);
            this.panel1.Controls.Add(this.btnUploadImage);
            this.panel1.Controls.Add(this.cbProcessType);
            this.panel1.Controls.Add(this.btnProcess);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 42);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pbOriginal);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pbProcessed);
            this.splitContainer1.Size = new System.Drawing.Size(800, 408);
            this.splitContainer1.SplitterDistance = 387;
            this.splitContainer1.TabIndex = 1;
            // 
            // pbOriginal
            // 
            this.pbOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbOriginal.Image = global::MHG.ImageProcess.Properties.Resources.shutterstock_291252509;
            this.pbOriginal.Location = new System.Drawing.Point(0, 0);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(387, 408);
            this.pbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbOriginal.TabIndex = 0;
            this.pbOriginal.TabStop = false;
            // 
            // pbProcessed
            // 
            this.pbProcessed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProcessed.Location = new System.Drawing.Point(0, 0);
            this.pbProcessed.Name = "pbProcessed";
            this.pbProcessed.Size = new System.Drawing.Size(409, 408);
            this.pbProcessed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbProcessed.TabIndex = 0;
            this.pbProcessed.TabStop = false;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(239, 6);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // cbProcessType
            // 
            this.cbProcessType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProcessType.FormattingEnabled = true;
            this.cbProcessType.Items.AddRange(new object[] {
            "Gray",
            "Negative",
            "Black And White",
            "Brightness"});
            this.cbProcessType.Location = new System.Drawing.Point(112, 7);
            this.cbProcessType.Name = "cbProcessType";
            this.cbProcessType.Size = new System.Drawing.Size(121, 21);
            this.cbProcessType.TabIndex = 1;
            this.cbProcessType.SelectedIndexChanged += new System.EventHandler(this.cbProcessType_SelectedIndexChanged);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(3, 6);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(104, 23);
            this.btnUploadImage.TabIndex = 2;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // tbBrightness
            // 
            this.tbBrightness.Location = new System.Drawing.Point(320, 6);
            this.tbBrightness.Maximum = 255;
            this.tbBrightness.Minimum = -50;
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.Size = new System.Drawing.Size(441, 45);
            this.tbBrightness.TabIndex = 3;
            this.tbBrightness.Visible = false;
            this.tbBrightness.ValueChanged += new System.EventHandler(this.tbBrightness_ValueChanged);
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightness.Location = new System.Drawing.Point(756, 12);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(21, 24);
            this.lblBrightness.TabIndex = 4;
            this.lblBrightness.Text = "0";
            this.lblBrightness.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProcessed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.PictureBox pbProcessed;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.ComboBox cbProcessType;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.TrackBar tbBrightness;
        private System.Windows.Forms.Label lblBrightness;
    }
}

