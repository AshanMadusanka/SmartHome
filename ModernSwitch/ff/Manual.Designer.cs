namespace ModernSwitch.ff
{
    partial class Manual
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.offbtn = new System.Windows.Forms.Button();
            this.onbtn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
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
            this.panel1.Size = new System.Drawing.Size(733, 144);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(158, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manual Mode";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ModernSwitch.Properties.Resources.icons8_slider_96px;
            this.pictureBox1.Location = new System.Drawing.Point(28, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // offbtn
            // 
            this.offbtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offbtn.Image = global::ModernSwitch.Properties.Resources.icons8_disconnected_80px;
            this.offbtn.Location = new System.Drawing.Point(433, 239);
            this.offbtn.Name = "offbtn";
            this.offbtn.Size = new System.Drawing.Size(172, 111);
            this.offbtn.TabIndex = 3;
            this.offbtn.Text = "OFF";
            this.offbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.offbtn.UseVisualStyleBackColor = true;
            this.offbtn.Click += new System.EventHandler(this.offbtn_Click);
            // 
            // onbtn
            // 
            this.onbtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onbtn.Image = global::ModernSwitch.Properties.Resources.icons8_connected_80px;
            this.onbtn.Location = new System.Drawing.Point(92, 239);
            this.onbtn.Name = "onbtn";
            this.onbtn.Size = new System.Drawing.Size(172, 111);
            this.onbtn.TabIndex = 4;
            this.onbtn.Text = "ON";
            this.onbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.onbtn.UseVisualStyleBackColor = true;
            this.onbtn.Click += new System.EventHandler(this.onbtn_Click);
            // 
            // Manual
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(733, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.offbtn);
            this.Controls.Add(this.onbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Manual";
            this.Text = "Manual";
            this.Load += new System.EventHandler(this.Manual_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button offbtn;
        private System.Windows.Forms.Button onbtn;
        private System.IO.Ports.SerialPort serialPort1;
    }
}