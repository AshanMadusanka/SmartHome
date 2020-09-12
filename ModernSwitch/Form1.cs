using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernSwitch
{
    public partial class Form1 : Form
    {
        
        
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Smart Switch 2.0";
            this.ControlBox = true;
            
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ff.Manual(), sender);

        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm!= null ) 
                activeForm.Close ( ) ;
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront ( ) ;
            childForm.Show ( ) ;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ff.Setting(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ff.Timer(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ff.Voice(), sender);
        }
    }
}
