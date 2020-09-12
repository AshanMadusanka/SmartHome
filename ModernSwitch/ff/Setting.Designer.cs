namespace ModernSwitch.ff
{
    partial class Setting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Portbox = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cntbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 144);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(133, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Setting";
            // 
            // Portbox
            // 
            this.Portbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Portbox.FormattingEnabled = true;
            this.Portbox.Location = new System.Drawing.Point(84, 272);
            this.Portbox.Name = "Portbox";
            this.Portbox.Size = new System.Drawing.Size(141, 39);
            this.Portbox.TabIndex = 5;
            this.Portbox.SelectedIndexChanged += new System.EventHandler(this.Portbox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ModernSwitch.Properties.Resources.icons8_settings_96px;
            this.pictureBox1.Location = new System.Drawing.Point(17, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cntbtn
            // 
            this.cntbtn.BackColor = System.Drawing.Color.Cornsilk;
            this.cntbtn.FlatAppearance.BorderSize = 2;
            this.cntbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cntbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntbtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.cntbtn.Image = global::ModernSwitch.Properties.Resources.icons8_online_64px;
            this.cntbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cntbtn.Location = new System.Drawing.Point(414, 232);
            this.cntbtn.Name = "cntbtn";
            this.cntbtn.Size = new System.Drawing.Size(182, 98);
            this.cntbtn.TabIndex = 4;
            this.cntbtn.Text = " Connect";
            this.cntbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cntbtn.UseVisualStyleBackColor = false;
            this.cntbtn.Click += new System.EventHandler(this.cntbtn_Click);
            // 
            // Setting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(683, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Portbox);
            this.Controls.Add(this.cntbtn);
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Portbox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button cntbtn;
    }
}